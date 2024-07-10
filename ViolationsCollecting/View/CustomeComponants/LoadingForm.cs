using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolationsCollecting.View.CustomeComponants
{
	public partial class LoadingForm : Form
	{
		private static LoadingForm? loading;
		private static MainView _main;

		public LoadingForm()
		{
			InitializeComponent();
			this.Owner = _main;

		}
		public static LoadingForm Instance(MainView main)
		{
			_main = main;
			return loading ?? (loading = new LoadingForm());
		}
	}
}
