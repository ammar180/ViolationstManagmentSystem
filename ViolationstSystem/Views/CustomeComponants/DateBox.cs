using System;
using System.Windows.Forms;

namespace ViolationsCollecting.View.CustomeComponants
{
	public partial class DateBox : UserControl
	{
		public DateTime? Date
		{
			get
			{
				try
				{
					return new DateTime(2000 + (int)YearNum.Value, (int)MonthNum.Value, (int)DayNum.Value);
				}
				catch (ArgumentOutOfRangeException)
				{
					return null;
				}
			}
		}
		public DateBox()
		{
			InitializeComponent();


		}

		internal void Initialize()
		{
			YearNum.Value = DateTime.Now.Year - 2000;
			MonthNum.Value = DateTime.Now.Month;
			DayNum.Value = DateTime.Now.Day;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			YearNum.Value = 0;
			MonthNum.Value = 0;
			DayNum.Value = 0;
		}

		private void btnCurrentDate_Click(object sender, EventArgs e)
		{
			Initialize();
		}
	}
}
