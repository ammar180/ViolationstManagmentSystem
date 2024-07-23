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
	public class HomePresenter
	{
		private IHomeView view;
		private IRepository repository;
		private ICollection<Violation> violationsList;

		public HomePresenter(IHomeView _view, IRepository _repository)
		{
			view = _view;
			repository = _repository;

			view.HandleGetViolationsList += GetList;
			view.HandleImport += ImportExcel;
			view.UpdateDG += UpdateDataGrid;

		}

		private void UpdateDataGrid(object sender, EventArgs e)
		{
			List<string> codes = sender as List<string>;
			view.HomeViewBS.DataSource = violationsList.Where(v => codes.Contains(v.TruckCode)).ToList();
		}

		private void GetList(object sender, EventArgs e)
		{
			view.loading.Show();

			violationsList = repository.GetViolationsByCode(view.TruckCodeDigits, view.TruckCodeChars).Result;

			view.ExploredCodesOfTrucks = violationsList.Where(x => 
				x.Truck.IsExplored??true)?
				.Select(x => x.TruckCode)
				.ToHashSet() ?? new HashSet<string>();
			view.HomeViewBS.DataSource = violationsList;
			
			view.FillCodeFiltercheckedList(violationsList.Select(x => x.TruckCode).Distinct().ToList());
			
			view.loading.Hide();
		}
		private async void ImportExcel(object sender, EventArgs e)
		{
			try
			{
				view.loading.Show();
				var violations = ExcelHelper.Import(ExcelHelper.GetFilePath());
				if (violations.Count > 0)
				{
					//List<Truck> trucks = violations.Select(x => x.Truck).ToList();
					//List<Truck> distinctedTrucks = trucks.Distinct().ToList();

					// AddTrucks toDataBase
					//await repository.AddTrucksRange(distinctedTrucks);

					await repository.AddViolationRange(violations);

					MessageHelper.Allert("تم الاضافة بنجاح");
				}
				else
					MessageHelper.Allert("يبدو أن هناك مشكلة اثناء الإدراج");

				view.loading.Hide();
			}
			catch (Exception ex)
			{
				MessageHelper.ErrorMessage(ex.Message);
				view.loading.Hide();
			}
		}
	}
}
