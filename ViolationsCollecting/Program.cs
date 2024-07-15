using System.Diagnostics;
using System.Reflection;
using ViolationsCollecting.Model.Repositories;
using ViolationsCollecting.Presenter;
using ViolationsCollecting.View;

namespace ViolationsCollecting
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
