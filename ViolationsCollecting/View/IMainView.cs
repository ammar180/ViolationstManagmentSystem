using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolationsCollecting.View
{
	public interface IMainView
	{
		// feilds - properties
		bool IsInAddingMode { get; set; }
		string TruckCode { get;}
		string ResponableUnit { get; }
		string Elmanfas { get;}
		DateTime TheDate { get;}
		string SearchData { get; }

		BindingSource MainViewBS { get; set; }

		// events
		event EventHandler SearchItems;
		event EventHandler Save;
		// methods
		void ClearTextBoxes();
	}
}
