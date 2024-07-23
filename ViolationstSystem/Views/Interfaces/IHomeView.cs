using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ViolationsCollecting.View.CustomeComponants;
using ViolationSystem.Data.Entities;

namespace ViolationsSystem.Views.Interfaces
{
	public interface IHomeView
	{
		string TruckCode { get; }
		string TruckCodeChars { get; }
		string TruckCodeDigits { get; }

		BindingSource HomeViewBS { get; set; }
		LoadingForm loading { get; }
		HashSet<string> ExploredCodesOfTrucks { get; set; }

		event EventHandler HandleImport;
		event EventHandler HandleGetViolationsList;
		event EventHandler UpdateDG;

		event EventHandler HandleGridEdit;
		event EventHandler HandleGridAdd;
		event EventHandler HandleGridDelete;

		void FillCodeFiltercheckedList(List<string> list);
	}
}
