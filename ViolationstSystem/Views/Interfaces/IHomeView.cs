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
		bool[] ExploredCodesOfTrucks { get; set; }
		bool[] dublicatedDateCode { get; set; }

		event EventHandler HandleGetViolationsList;
		event EventHandler UpdateDG;
		event EventHandler HandleImport;

		//event EventHandler HandleGridEdit;
		//event EventHandler HandleGridAdd;
		//event EventHandler HandleGridDelete;
		event EventHandler SaveChangesEvent;
		event EventHandler PrintEvent;
		List<string> FillCodeFiltercheckedList { set; }
		List<Violation> ModifiedViolations { get; set; }
		List<Violation> DeletedViolations { get; set; }
	}
}
