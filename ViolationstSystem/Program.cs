using System;
using System.Configuration;
using System.Windows.Forms;
using ViolationsSystem;
using ViolationsSystem.Presenter;
using ViolationsSystem.Views.Interfaces;
using ViolationSystem.Data.EF;

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

			IMainView view = new MainView();
			new MainPresenter(view);
			Application.Run((Form)view);
		}
	}
}
