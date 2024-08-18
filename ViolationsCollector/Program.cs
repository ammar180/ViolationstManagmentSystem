using System;
using System.Windows.Forms;
using ViolationsCollector.Model.Repositories;
using ViolationsCollector.Presenter;
using ViolationsCollector.View;

namespace ViolationsCollector
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

			IMainView mainView = new MainView();
			IRepository repository = new Repository();
			new MainPresenter(mainView, repository);

			Application.Run((Form)mainView);
		}
	}
}
