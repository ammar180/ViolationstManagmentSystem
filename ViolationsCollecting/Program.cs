using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationsCollecting.Model.Repositories;
using ViolationsCollecting.View;
using ViolationsSystem.Presenter;

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
			
			Application.Run((Form) mainView);
		}
	}
}
