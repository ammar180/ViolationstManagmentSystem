using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationsSystem.Presenter.Helpers;
using ViolationsSystem.Views.Interfaces;
using ViolationstSystem.Presenter.Helpers;
using ViolationstSystem.Views;
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
			view.SaveChangesEvent += SaveChanges;
			view.PrintEvent += Print;

		}

		private void Print(object sender, EventArgs e)
		{
			var list = sender as List<Violation>;
			ReportDataSource rs = new ReportDataSource();
			var helperForm = HelperForm.GetInstance();
			rs.Name = "TruckViolations";
			rs.Value = list;
			helperForm.reportViewer.LocalReport.DataSources.Clear();
			helperForm.reportViewer.LocalReport.DataSources.Add(rs);
			helperForm.ShowDialog();
		}

		private void SaveChanges(object sender, EventArgs e)
		{
			violationsList = sender as List<Violation>;
			repository.UpdateViolations(view.ModifiedViolations);
			repository.RemoveViolations(view.DeletedViolations);
		}

		private void UpdateDataGrid(object sender, EventArgs e)
		{
			List<string> list = sender as List<string>;
			view.HomeViewBS.DataSource = violationsList.Where(v => 
				list.Contains(v.TruckCode) 
				&& list.Contains(v.Unit)
				).ToList();
		}

		private void GetList(object sender, EventArgs e)
		{
			view.loading.Show();

			violationsList = repository.GetViolationsByCode(view.TruckCodeDigits, view.TruckCodeChars).Result;

			view.ExploredCodesOfTrucks = GetExploredCodesOfTrucks();

			view.dublicatedDateCode = GetdublicatedDateCodeIndcies();

			view.HomeViewBS.DataSource = violationsList;

			view.FillCodeFiltercheckedList = violationsList.Select(x => x.TruckCode).Distinct().ToList();
			
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

		#region Methods

		private bool[] GetExploredCodesOfTrucks()
		{
			bool[] result = new bool[violationsList.Count];
			result.Initialize();
			for (int i = 0; i < result.Length; i++)
				result[i] = violationsList.ElementAt(i).Truck.IsExplored??false;
			
			return result;
		}
		private bool[] GetdublicatedDateCodeIndcies()
		{
			var seenValues = new HashSet<DateCode>(new DateCodeComparer());

			bool[] result = new bool[violationsList.Count];
			result.Initialize();
			for (int i = 0; i < result.Length; i++)
			{
				if (seenValues.Contains(
					new DateCode
					{
						ViolationDate = violationsList.ElementAt(i).ViolationDate,
						TruckCode = violationsList.ElementAt(i).TruckCode
					}))
					result[i] = true;
				else
					seenValues.Add(
					new DateCode
					{
						ViolationDate = violationsList.ElementAt(i).ViolationDate,
						TruckCode = violationsList.ElementAt(i).TruckCode
					});

			}
			return result;
		}
		#endregion
	}
    class DateCode
    {
		public DateTime ViolationDate { get; set; }
		public string TruckCode { get; set; }
		public bool Equals(DateCode other)
		{
			if (other == null) return false;
			return this.TruckCode == other.TruckCode && this.ViolationDate == other.ViolationDate;
		}

		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			if (obj.GetType() != this.GetType()) return false;
			return Equals(obj as DateCode);
		}

		public override int GetHashCode()
		{
			return TruckCode?.GetHashCode() + ViolationDate.GetHashCode() ?? 0;
		}
	}

	class DateCodeComparer : IEqualityComparer<DateCode>
	{
		public bool Equals(DateCode x, DateCode y)
		{
			if (x == null && y == null) return true;
			if (x == null || y == null) return false;
			return x.TruckCode == y.TruckCode && x.ViolationDate == y.ViolationDate;
		}

		public int GetHashCode(DateCode obj)
		{
			if (obj == null) return 0;
			int hashTruckCode = obj.TruckCode == null ? 0 : obj.TruckCode.GetHashCode();
			int hashViolationDate = obj.ViolationDate.GetHashCode();
			return hashTruckCode ^ hashViolationDate;
		}
	}
}
