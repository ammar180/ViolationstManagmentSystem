using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using ViolationsSystem;
using ViolationsSystem.Presenter;
using ViolationsSystem.Views;
using ViolationsSystem.Views.Interfaces;
using ViolationSystem.Data.Repositories;

namespace ViolationstSystem
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//IMainView view = new MainView();
			//new MainPresenter(view);

			Application.Run(new MainView());
		}
	}
}
