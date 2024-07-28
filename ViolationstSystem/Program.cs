using System;
using System.Windows.Forms;
using ViolationsCollecting.View.CustomeComponants;
using ViolationsSystem;
using ViolationstSystem.Views;

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

			var view = new MainView();
			//new MainPresenter(view);
			LoadingForm.mainViewInstance = view;
			HelperForm.MainView = view;

			Application.Run(view);
		}
	}
}
