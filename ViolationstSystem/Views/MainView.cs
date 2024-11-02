using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ViolationsSystem.Presenter;
using ViolationsSystem.Views;
using ViolationstSystem.Views;
using ViolationSystem.Data.Repositories;

namespace ViolationsSystem
{
	public partial class MainView : Form
	{
		//Fields
		//Properties
		private string SelectedConnection
		{
			get => (radioBtnLocal.Checked) ? "ViolationstSystem.Properties.Settings.SqlConnectionLocal" :
				(radioBtnTCP.Checked) ? "ViolationstSystem.Properties.Settings.SqlConnectionTCP" : "";
		}
		//Events
		public event EventHandler ShowView;


		//Constructor
		public MainView()
		{
			InitializeComponent();
			// init presenters
			string connectionStr = ViolationstSystem.Properties.Settings.Default.SelectedConnectionType;
			radioBtnLocal.Checked = connectionStr == "ViolationstSystem.Properties.Settings.SqlConnectionLocal";
			radioBtnTCP.Checked = connectionStr == "ViolationstSystem.Properties.Settings.SqlConnectionTCP";

			Version version = Assembly.GetExecutingAssembly().GetName().Version;

			labCurrentVersion.Text += version.ToString();

			var HomeView = this.homeTP.Controls.OfType<HomeView>().FirstOrDefault();
			var TrafficView = this.sendTrafficTP.Controls.OfType<SendTrafficView>().FirstOrDefault();

			new HomePresenter(HomeView, new Repository(connectionStr));
			new SendTrafficPresenter(TrafficView, new Repository(connectionStr));

			homeTP.Enter += HomeTP_Enter;
		}

		private void HomeTP_Enter(object sender, EventArgs e)
		{
			var HomeView = this.homeTP.Controls.OfType<HomeView>().FirstOrDefault();
			HomeView.dataGridView.AllowUserToDeleteRows = AdminLogin.IsAdmin;

			for (int i = 2; i< HomeView.dataGridView.Columns.Count; i++)
				HomeView.dataGridView.Columns[i].ReadOnly = !AdminLogin.IsAdmin;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if(SelectedConnection != "")
			{
				ViolationstSystem.Properties.Settings.Default.SelectedConnectionType = SelectedConnection;
				ViolationstSystem.Properties.Settings.Default.Save();
				MessageBox.Show("يرجى إعادة تشغيل البرنامج");
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				// Get the path of the update.exe file in the same directory as the application
				string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
				string updateFilePath = Path.Combine(appDirectory, "updater.exe");

				// Check if the update.exe file exists
				if (File.Exists(updateFilePath))
				{
					// Start the update.exe process
					System.Diagnostics.Process.Start(updateFilePath);
				}
				else
				{
					MessageBox.Show("Update file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				// Handle any errors that may occur when trying to start the process
				MessageBox.Show($"An error occurred while trying to start the update: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
