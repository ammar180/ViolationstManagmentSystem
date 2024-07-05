using System;
using System.Windows.Forms;
using ViolationsSystem.Views;
using ViolationsSystem.Views.Interfaces;
using static ViolationsSystem.Views.Interfaces.IMainView;

namespace ViolationsSystem
{
	public partial class MainView : Form, IMainView
	{
		//Fields
		public Panel Container { get => panelContainer; }
		//Properties


		//Constructor
		public MainView()
		{
			InitializeComponent();

			// init event
			btnMainScreen.Click += delegate { ShowView?.Invoke(HomeView.GetInstance(), EventArgs.Empty); };
			btnSendTraffic.Click += delegate { ShowView?.Invoke(SendTrafficView.GetInstance(), EventArgs.Empty); };
			//btnSearchRecord.Click += delegate { ShowView.Invoke(.GetInstance()); };
			//btnManageData.Click += delegate { ShowView.Invoke(.GetInstance()); };
			//btnTeamplets.Click += delegate { ShowView.Invoke(.GetInstance()); };
			//btnSettings.Click += delegate { ShowView.Invoke(.GetInstance()); };
		}

		//Events
		public event EventHandler ShowView;

        //Methods

    }
}
