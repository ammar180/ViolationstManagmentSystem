using System;
using ViolationsSystem.Views.Interfaces;
using ViolationSystem.Data.Repositories;
using Microsoft.Reporting.WinForms;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using ViolationSystem.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ViolationsSystem.Presenter
{
	public class SendTrafficPresenter
	{
		private ISendTrafficView view;
		private IRepository repository;

		private ReportDataSource rs1;
		private ReportDataSource rs2;
		private List<Truck> list;
		public SendTrafficPresenter(ISendTrafficView view, IRepository repository)
		{
			this.view = view;
			this.repository = repository;

			rs1 = new ReportDataSource("TrafficReportDataSet1");
			rs2 = new ReportDataSource("TrafficReportDataSet2");
			//Subscribe event handler methods to view events
			view.GetResultEvent += GetResult;
			view.report.PrintingBegin += Report_PrintingBegin;
		}

		private void Report_PrintingBegin(object sender, ReportPrintEventArgs e)
		{
			repository.UpdateTrucksToExplored(list);
		}

		private async void GetResult(object sender, EventArgs e)
		{
			view.LoadingForm.Show();
			list = await repository.GetTrafficTrucks(view.TrucksCount, view.TargetUnit, view.StartDate);
			var l1 = new List<Truck>();
			var l2 = new List<Truck>();

			for (int i = 0, j = list.Count -1; i < (list.Count / 2); i++, j--)
            {
				l1.Add(list[i]);
				l2.Add(list[j]);
            }
			view.LoadingForm.Hide();

			view.report.LocalReport.SetParameters(new ReportParameter("StartCount", $"{l1.Count}"));

			rs1.Value = l1;
			rs2.Value = l2;

            view.report.LocalReport.DataSources.Clear();
			
			view.report.LocalReport.DataSources.Add(rs1);
			view.report.LocalReport.DataSources.Add(rs2);
			view.report.RefreshReport();
		}
	}
}