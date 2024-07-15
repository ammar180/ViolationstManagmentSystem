using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationsCollecting.View.CustomeComponants;

namespace ViolationsCollecting.View
{
	public interface IMainView
	{
		// feilds
		string TruckCode { get;}
		string ResponableUnit { get; }
		string ElManfaz { get;}
		DateTime TheDate { get;}
		LoadingForm loading { get; }
		// properties
		bool IsInAddingMode { get; set; }
		int UpdatedViolationId { get; set; }
		BindingSource MainViewBS { get; set; }
		int MonthToExport { get;}
		// Validations Lables
		string CodeMessage { set; }
		string UnitMessage { set; }
		string ElManfazMessage { set; }

		// events
		event EventHandler SearchItems;

		delegate Task AsyncEventHandler();
		event AsyncEventHandler Save;
		event EventHandler OnTimerTick;
		event AsyncEventHandler ExportEvent;
		// methods
		void ClearTextBoxes();
	}
}
