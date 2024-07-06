using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ViolationsCollecting.Model;
using ViolationsCollecting.Model.Repositories;
using ViolationsCollecting.View;

/* Featurs List
 * Extraction Controls
 * Admin Contorles
 * Search Id
 * Edit Functionality
 * Editing Time Limitation
*/
namespace ViolationsSystem.Presenter
{
	public class MainPresenter
	{
		private IMainView view;
		private IRepository repository;
		private Violation Violation;
		private List<ViolationLayer> ViolationsLayer;
		private Truck Truck;
		public MainPresenter(IMainView _view, IRepository _repository)
		{
			view = _view;
			repository = _repository;

			Violation = new Violation();
			Truck = new Truck();
			ViolationsLayer = new List<ViolationLayer>();

			view.Save += SaveViolation;
			view.SearchItems += SearchViolations;
		}

		// Methods
		private void SearchViolations(object sender, EventArgs e)
		{
		}

		private void SaveViolation(object sender, EventArgs e)
		{
			// {DataBase Handling}

			// assosiat data on object
			Truck.Code = view.TruckCode;
			Truck.IsExplored = false;

			Violation.ViolationDate = view.TheDate;
			Violation.ResponsibleUnit = view.ResponableUnit;
			Violation.elManfath = view.Elmanfas;
			Violation.Truck = Truck;
			Violation.TruckId = 1;

			if (view.IsInAddingMode)
			{
				// Add Truck: if exest? get id : add to database and update, finally get Id
				Violation.TruckId = repository.TryAddTruckAndGetId(Truck);

				// Add violation
				repository.AddViolation(Violation);
				view.ClearTextBoxes();
				
				ViolationsLayer.Add(new ViolationLayer(Violation) {TimeCreation = DateTime.Now});
			}
			else
			{
				// Edit violation
				repository.EditViolation(Violation);
				view.ClearTextBoxes();
			}
			// DataGridHandling
			TimeSpan timeExpierd = ViolationsCollecting.Properties.Settings.Default.TimeToExpired;
			ViolationsLayer = ViolationsLayer.Where(x => x.TimeCreation.Add(timeExpierd) > DateTime.Now).ToList();
			view.MainViewBS.DataSource = ViolationsLayer;

		}

	}
	public class ViolationLayer : Violation
	{
        public ViolationLayer() { }
        public ViolationLayer(Violation violation) 
		{
			Id = violation.Id;
			ViolationDate = violation.ViolationDate;
			Truck = violation.Truck;
			TruckCode = violation.TruckCode;
			ResponsibleUnit = violation.ResponsibleUnit;
			elManfath = violation.elManfath;
		}
        public DateTime TimeCreation { get; set; }
	}
}
