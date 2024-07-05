using System;
using System.Windows.Forms;

namespace ViolationsSystem.Views.Interfaces
{
	public interface ISendTrafficView
	{
		//Properties - Fields
		int TrucksCount { get;}
		DateTime StartDate { get;}
		DateTime EndDate { get;}
		//Events
		event EventHandler GetResultEvent;
		DataGridView dgv { get; set; }
		//Methods
	}
}
