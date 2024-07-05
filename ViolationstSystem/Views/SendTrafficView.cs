using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationsSystem.Views.Interfaces;

namespace ViolationsSystem.Views
{
	public partial class SendTrafficView : UserControl, ISendTrafficView
	{
		//Properties - Fields
		private static SendTrafficView instance;
		public SendTrafficView()
		{
			InitializeComponent();
			btnGetResult.Click += delegate { GetResultEvent.Invoke(this, EventArgs.Empty); };
		}

		public int TrucksCount { get => ((int)countTrucks.Value); }
		public DateTime StartDate { get => dateStart.Value; }
		public DateTime EndDate { get => dateEnd.Value; }
		public DataGridView dgv { get => dataGridView; set => dataGridView = value; }


		//Events
		public event EventHandler GetResultEvent;

		//Methods
		public static SendTrafficView GetInstance()
		{
			if (instance == null || instance.IsDisposed)
				instance = new SendTrafficView();
			return instance;
		}
	}
}
