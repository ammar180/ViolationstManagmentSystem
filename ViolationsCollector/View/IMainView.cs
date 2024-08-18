using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationsCollector.View.CustomeComponants;

namespace ViolationsCollector.View
{
	public delegate Task AsyncEventHandler();
	public interface IMainView
	{
		// feilds
		string TruckCode { get;}
		string ResponableUnit { get; }
		string ElManfaz { get;}
		DateTime TheDate { get;}
		LoadingForm loading { get; }
		// properties
		bool IsInAddingMode { get; }
		int UpdatedViolationId { get; set; }
		BindingSource MainViewBS { get; set; }
		int MonthToExport { get;}
		// Validations Lables
		string CodeMessage { set; }
		string UnitMessage { set; }
		string ElManfazMessage { set; }

		// events
		event EventHandler SearchItems;
		event AsyncEventHandler Save;
		event EventHandler OnTimerTick;
		event AsyncEventHandler ExportEvent;
		event AsyncEventHandler UpdateRowsEvent;
		// methods
		void ClearTextBoxes();
	}
}
