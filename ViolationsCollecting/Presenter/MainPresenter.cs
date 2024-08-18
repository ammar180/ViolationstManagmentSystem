using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.Data;
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
			view.ExportEvent += ExtractData;
			loadRows();
		}

		private async void loadRows()
		{
			ViolationsLayer = await repository.GetViolationsInDateRange(DateTime.Now - Properties.Settings.Default.TimeToExpired, DateTime.Now);
			view.MainViewBS.DataSource = ViolationsLayer;
		}

		private async Task ExtractData()
		{
			int monthToExport = view.MonthToExport;

			if (Properties.Settings.Default.ExportPath == "")
			{
				if (MessageBoxHelper.SelectBath())
				{
					Properties.Settings.Default.ExportPath = ExcelHelper.GetPath();
					Properties.Settings.Default.Save();
					ExtractData();
				}
			}
			else
			{
				// extrackt...

				if (MessageBoxHelper.AlertExportDate(monthToExport))
				{
					// sitting up Arguments..
					var ViolationsToExport = await repository.GetViolationsInMonth(monthToExport);
					
					string u = Properties.Settings.Default.AppUnit;
					string exportName = $"({DateTime.Now.Year }-{monthToExport})_{u}";

					DataTable dataTable = new DataTable();
					using (var reader = FastMember.ObjectReader.Create(ViolationsToExport))
					{
						dataTable.Load(reader);
					}
					dataTable = ExcelHelper.ArrangeDataTable(dataTable);

					ExcelHelper.Export(dataTable, exportName, Properties.Settings.Default.ExportPath);

					MessageBoxHelper.ExtrationDone();
					ExcelHelper.OpenDir(Properties.Settings.Default.ExportPath);

					//await repository.RemoveViolationsRange(ViolationsToExport);
				}
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
			view.MainViewBS.DataSource = ViolationsLayer.Where(x => x.TruckCode.Contains(sender.ToString())).ToList();
		}

		private async Task SaveViolationAsync()
		{
			Properties.Settings.Default.AppUnit = view.ResponableUnit;
			Properties.Settings.Default.Save();

			try
			{
				// assosiat data on object
				var violation = new Violation()
				{
					ViolationDate = view.TheDate,
					Unit = Properties.Settings.Default.AppUnit,
					ElManfaz = view.ElManfaz,
					TruckCode = view.TruckCode,
					RegistrationDate = DateTime.Now,
				};

				Validate(violation);

				if (!repository.CanConnect())
					throw new Exception("لا يمكن الوصول لقاعدة البينات، يرجى التحقق من الاتصال من ثم اعادة المحاولة");

				if (validation.IsValid )
				{
					view.loading.Show();
					if (view.IsInAddingMode)
					{
						//Check Truck Exest
						//if (!await repository.CheckTruckExest(view.TruckCode))
						//	await repository.AddTruck(truck);


						// Add violation
						if (await repository.CheckViolationInsertedBefore(violation.TruckCode, violation.ViolationDate))
							throw new Exception("عذرا! لا يمكن تسجيل مخالفة لنفس السيارة اكثر من مرة في اليوم");
						else if (await repository.AddViolation(violation))
						{
							ViolationsLayer.Add(violation);
							view.ClearTextBoxes();
						}
					}
					else
					{
						// Edit violation
						violation.Id = view.UpdatedViolationId;

						if (await repository.EditViolation(violation))
						{
							view.ClearTextBoxes();
							// DataGridHandling
							var index = ViolationsLayer.FindIndex(x => x.Id == violation.Id);

							if (index > -1)
								ViolationsLayer[index] = violation;
						}
					}
					view.MainViewBS.DataSource = ViolationsLayer.ToList();
					view.loading.Hide();
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "خطأ أثناء العملية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				view.loading.Hide();
			}


		}

		private void Validate(Violation violation)
		{
			var validationResults = validation.GetValidationResult(violation);

			view.CodeMessage = validationResults?.FirstOrDefault(x => x.MemberNames?.First() == nameof(violation.TruckCode))?.ErrorMessage?? "";
			view.UnitMessage = validationResults?.FirstOrDefault(x => x.MemberNames?.First() == nameof(violation.Unit))?.ErrorMessage ?? "";
			view.ElManfazMessage = validationResults?.FirstOrDefault(x => x.MemberNames?.First() == nameof(violation.ElManfaz))?.ErrorMessage ?? "";
		}
	}
}
