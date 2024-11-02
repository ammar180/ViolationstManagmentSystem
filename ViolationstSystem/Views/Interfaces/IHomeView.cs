using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ViolationsCollecting.View.CustomeComponants;
using ViolationSystem.Data.Entities;

namespace ViolationsSystem.Views.Interfaces
{
	public interface IHomeView
	{
		// Fields
		string TruckCodeChars { get; }
		string TruckCodeDigits { get; }
		string PrintName { get; }
		// Properties
		BindingSource HomeViewBS { get; set; }
		LoadingForm loading { get; }
		List<bool> ExploredCodesOfTrucks { get; set; }
		List<bool> DublicatedDateCode { get; set; }
		List<string> FillCodeFiltercheckedList { set; }
		List<Violation> ModifiedViolations { get; set; }
		List<Violation> DeletedViolations { get; set; }

		// Events
		event EventHandler HandleGetViolationsList;
		event EventHandler UpdateDG;
		event EventHandler HandleImport;

		event EventHandler SaveChangesEvent;
		event EventHandler PrintEvent;
	}
}
