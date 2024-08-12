using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using ViolationsCollecting.View.CustomeComponants;
using ViolationsSystem.Views.Interfaces;

namespace ViolationsSystem.Views
{
	public partial class SendTrafficView : UserControl, ISendTrafficView
	{
		//Properties - Fields
		public LoadingForm LoadingForm { get; set; }
		public SendTrafficView()
		{
			InitializeComponent();
			LoadingForm = new LoadingForm();
			btnGetResult.Click += delegate { GetResultEvent.Invoke(this, EventArgs.Empty); };

			LoadingForm.FormShown += LoadingForm_FormShown;
			LoadingForm.FormHiding += LoadingForm_FormHiding;
		}

		public int TrucksCount { get => ((int)countTrucks.Value); }
		public DateTime? StartDate { get => dateBox1.Date; }
		public string TargetUnit { get => comboUnits.Text; }
		public ReportViewer report { get => reportViewer; }


		//Events
		public event EventHandler GetResultEvent;

		//Methods
		private void LoadingForm_FormHiding(object sender, EventArgs e)
			=> this.Enabled = true;
		private void LoadingForm_FormShown(object sender, EventArgs e)
			=> this.Enabled = false;

	}
}
