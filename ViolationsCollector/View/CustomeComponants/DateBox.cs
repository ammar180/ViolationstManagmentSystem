using System;
using System.Windows.Forms;

namespace ViolationsCollector.View.CustomeComponants
{
	public partial class DateBox : UserControl
	{
		public DateTime Date
		{
			get
			{
				return new DateTime(2000 + (int)YearNum.Value, (int)MonthNum.Value, (int)DayNum.Value); ;
			}
			set
			{
				YearNum.Value = value.Year - 2000;
				MonthNum.Value = value.Month;
				DayNum.Value = value.Day;
			}
		}
		public DateBox()
		{
			InitializeComponent();

			YearNum.Value = DateTime.Now.Year - 2000;
			MonthNum.Value = DateTime.Now.Month;
			DayNum.Value = DateTime.Now.Day;
		}
	}
}
