using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using ViolationsCollecting.View.CustomeComponants;

namespace ViolationsSystem.Views.Interfaces
{
	public interface ISendTrafficView
	{
		//Properties - Fields
		LoadingForm LoadingForm { get; set; }
		int TrucksCount { get;}
		DateTime? StartDate { get;}
		string TargetUnit { get; }
		//Events
		event EventHandler GetResultEvent;
		ReportViewer report { get; }
		//Methods
	}
}
