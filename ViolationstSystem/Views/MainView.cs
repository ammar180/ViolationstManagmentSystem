using System;
using System.Linq;
using System.Windows.Forms;
using ViolationsSystem.Presenter;
using ViolationsSystem.Views;
using ViolationsSystem.Views.Interfaces;
using ViolationSystem.Data.Repositories;

namespace ViolationsSystem
{
	public partial class MainView : Form, IMainView
	{
		//Fields
		public Panel Container { get; }
		//Properties
		//Events
		public event EventHandler ShowView;


		//Constructor
		public MainView()
		{
			InitializeComponent();

			// init presenters
			new HomePresenter(this.homeTP.Controls.OfType<HomeView>().FirstOrDefault(), Repository.GetInstance());
		}

	}
}
