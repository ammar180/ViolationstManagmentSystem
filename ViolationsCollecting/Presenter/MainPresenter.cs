using ViolationsCollecting.Model.Entities;
using ViolationsCollecting.Model.Repositories;
using ViolationsCollecting.View;

/* Featurs List:
 * Extraction Controls => 1th per Month && in Day 15 or Greater
 * Admin Contorles 
*/
namespace ViolationsCollecting.Presenter
{
	public class MainPresenter
	{
		private IMainView view;
		private IRepository repository;
		private Validation<Violation> validation;
		private List<Violation> ViolationsLayer;
		public MainPresenter(IMainView _view, IRepository _repository)
		{
			view = _view;
			repository = _repository;

			ViolationsLayer = new List<Violation>();
			validation = new Validation<Violation>();

			view.Save += SaveViolationAsync;
			view.SearchItems += SearchViolations;
			view.OnTimerTick += HandleEditingTimeLimitation;

			ExtractData();
		}

		private bool CheckExport(int dayToExport, int monthToExport)
		{
			// check is day to extrackt && NotExtraktd
			return (dayToExport >= DateTime.Now.Day
				&& dayToExport <= (DateTime.Now.Day + 3)
				&& monthToExport == DateTime.Now.Month);
		}

		private void ExtractData()
		{
			int dayToExport = Properties.Settings.Default.DayToExport;
			int monthToExport = Properties.Settings.Default.MonthToExport;

			if (CheckExport(dayToExport, monthToExport))
			{
				// extrackt...
				DateTime StartDate = new DateTime(DateTime.Now.Year, monthToExport -1, dayToExport );
				DateTime EndDate = new DateTime(DateTime.Now.Year, monthToExport, dayToExport);

				var ViolationsToExport = repository.GetViolationsInDateRange(StartDate, EndDate).Result;

				Properties.Settings.Default.MonthToExport++;
			}
		}

		private void HandleEditingTimeLimitation(object sender, EventArgs e)
		{
			TimeSpan timeExpierd = Properties.Settings.Default.TimeToExpired;
			ViolationsLayer = ViolationsLayer.Where(x => x.RegistrationDate.Add(timeExpierd) > DateTime.Now).ToList();
			view.MainViewBS.DataSource = ViolationsLayer;
		}

		// Methods
		private void SearchViolations(object sender, EventArgs e)
		{
			view.MainViewBS.DataSource = ViolationsLayer.Where(x => x.TruckCode.Contains(view.SearchData)).ToList();
		}

		private async Task SaveViolationAsync()
		{
			try
			{
				// assosiat data on object
				var violation = new Violation()
				{
					ViolationDate = view.TheDate,
					Unit = view.ResponableUnit,
					ElManfaz = view.ElManfaz,
					TruckCode = view.TruckCode,
					RegistrationDate = DateTime.Now,
				};

				var truck = new Truck()
				{
					TruckCode = view.TruckCode,
					IsExplored = false,
				};

				view.Message = "";
				view.Message += string.Join(Environment.NewLine, validation.GetValidationResult(violation).Select(vr => vr.ErrorMessage));
				
				if (!repository.CanConnect())
					throw new Exception("لا يمكن الوصول لقاعدة البينات، يرجى التحقق من الاتصال من ثم اعادة المحاولة");
				
				if (validation.IsValid )
				{
					view.loading.Show();
					if (view.IsInAddingMode)
					{
						//Check Truck Exest
						if (!await repository.CheckTruckExest(view.TruckCode))
							await repository.AddTruck(truck);


						// Add violation
						violation.Id = new int();
						if (await repository.AddViolation(violation))
						{
							ViolationsLayer.Add(violation);
							view.ClearTextBoxes();
						}
					}
					else
					{
						// Edit violation
						violation.Id = view.UpdatedViolationId;

						if (repository.EditViolation(violation).Result)
							view.ClearTextBoxes();
						// DataGridHandling
						var index = ViolationsLayer.FindIndex(x => x.Id == violation.Id);

						if (index > -1)
							ViolationsLayer[index] = violation;
					}
					view.MainViewBS.DataSource = ViolationsLayer.ToList();
					view.SetDeafultSelectedRow();

					view.loading.Hide();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "خطأ أثناء العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			
		}

	}
}
