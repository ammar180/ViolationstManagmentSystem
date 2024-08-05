using System;
using System.Windows.Forms;
using ViolationsSystem;
using ViolationsSystem.Views;

namespace ViolationsCollecting.View.CustomeComponants
{
	public partial class LoadingForm : Form
	{
		private static LoadingForm loading;
		public static MainView mainViewInstance;

		public LoadingForm()
		{
			InitializeComponent();
			this.Owner = mainViewInstance;
		}
		public static LoadingForm Instance()
		{
			return loading ?? (loading = new LoadingForm());
		}
		// Define the custom event
		public event EventHandler FormHiding;

		// Override the Hide method
		public new void Hide()
		{
			// Raise the custom event before hiding the form
			FormHiding?.Invoke(this, EventArgs.Empty);

			// Call the base Hide method
			base.Hide();
		}
		// Define the custom event
		public event EventHandler FormShown;

		// Override the Hide method
		public new void Show()
		{
			// Raise the custom event before hiding the form
			FormShown?.Invoke(this, EventArgs.Empty);

			// Call the base Hide method
			base.Show();
		}

	}
}
