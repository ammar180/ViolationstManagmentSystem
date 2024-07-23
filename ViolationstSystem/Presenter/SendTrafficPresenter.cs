using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ViolationsSystem.Views.Interfaces;
using ViolationSystem.Data.Repositories;

namespace ViolationsSystem.Presenter
{
	public class SendTrafficPresenter
	{
		private ISendTrafficView view;
		private IRepository repository;

		private List<string> TruckCodeList;
		public SendTrafficPresenter(ISendTrafficView view, IRepository repository)
	    {
			TruckCodeList = new List<string>();
			this.view = view;
			this.repository = repository;

			//Subscribe event handler methods to view events
			//this.view.GetResultEvent += GetResult;
		}

		//private void GetResult(object sender, EventArgs e)
		//{
		//	if (repository.IsCanConnect())
		//	{
		//		view.dgv.Rows.Clear();
		//		TruckCodeList = repository.GetNumTrucksByS_E_Date(view.TrucksCount, view.StartDate, view.EndDate);

		//		int crt = 1;
		//		TruckCodeList.ForEach(x =>
		//		{
		//			view.dgv.Rows.Add($"{crt}",x, "");
		//			crt++;
		//		});
		//	}
		//	else
		//		MessageBox.Show("قاعدة البيانات ليست متصله");
		//}
	}
}