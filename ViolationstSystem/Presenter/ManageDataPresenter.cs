using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationsSystem.Presenter.Helpers;
using ViolationsSystem.Views.Interfaces;
using ViolationstSystem.Presenter.Helpers;
using ViolationSystem.Data.Entities;
using ViolationSystem.Data.Repositories;

namespace ViolationsSystem.Presenter
{
	public class ManageDataPresenter
	{
		private IManageDataView view;
		private IRepository repository;
		private BindingSource violationsBindingSource;
		private List<Violation> violationsList;

		public ManageDataPresenter(IManageDataView _view, IRepository _repository)
		{
			violationsBindingSource = new BindingSource();
			view = _view;
			repository = _repository;
			view.HandleImport += ImportExcel;

			LoadAllViolationsList();
		}

		private async void ImportExcel(object sender, EventArgs e)
		{
			try
			{
				var violations = ExcelHelper.Import(ExcelHelper.GetFilePath());
				if (violations.Count > 0)
				{
					var trucks = violations.Select(x => x.TruckCode).Distinct().ToList();
					// AddTrucks If Not Added in database
					//await repository.AddTrucksRange(trucks);
					await repository.AddViolationRange(violations);
					MessageHelper.Allert("تم الاضافة بنجاح");
				}
				else
					MessageHelper.Allert("حدث مشكلة اثناء الإدراج");
			}catch(Exception ex)
			{
				MessageHelper.ErrorMessage(ex.Message);
			}
		}

		//Methods
		private void LoadAllViolationsList()
		{

		}
	}
}
