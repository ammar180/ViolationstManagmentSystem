using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolationsCollecting.View.CustomeComponants
{
	public partial class DateBox : UserControl
	{
        public DateTime Date
		{
			get; set;
		}
        public DateBox()
		{
			InitializeComponent();

		}
	}
}
