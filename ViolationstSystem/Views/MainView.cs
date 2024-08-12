using System;
using System.Linq;
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

			var HomeView = this.homeTP.Controls.OfType<HomeView>().FirstOrDefault();

			new HomePresenter(HomeView, new Repository(connectionStr));
			new SendTrafficPresenter(this.sendTrafficTP.Controls.OfType<SendTrafficView>().FirstOrDefault(), new Repository(connectionStr));

			homeTP.Enter += HomeTP_Enter;
		}

		private void HomeTP_Enter(object sender, EventArgs e)
		{
			var HomeView = this.homeTP.Controls.OfType<HomeView>().FirstOrDefault();
			HomeView.dataGridView.AllowUserToDeleteRows = AdminLogin.IsAdmin;
			HomeView.dataGridView.Columns[2].ReadOnly = !AdminLogin.IsAdmin;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if(SelectedConnection != "")
			{
				ViolationstSystem.Properties.Settings.Default.SelectedConnectionType = SelectedConnection;
				ViolationstSystem.Properties.Settings.Default.Save();
			}
		}
	}
}
