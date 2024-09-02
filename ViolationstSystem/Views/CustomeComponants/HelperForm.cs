using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ViolationsSystem;

namespace ViolationstSystem.Views
{
	public partial class HelperForm : Form
	{
		public static MainView MainView { get; set; }
		public HelperForm()
		{
			InitializeComponent();
			this.Owner = MainView;
		}

		private void HelperForm_Load(object sender, EventArgs e)
		{
			this.reportViewer.RefreshReport();
		}
		private static HelperForm instance;
		public static HelperForm GetInstance()
		{
			if (instance == null || instance.IsDisposed)
				instance = new HelperForm();
			return instance;
		}

	}
}
