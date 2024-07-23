using System.Windows.Forms;
using ViolationsSystem;
using ViolationsSystem.Views;

namespace ViolationsCollecting.View.CustomeComponants
{
	public partial class LoadingForm : Form
	{
		private static LoadingForm loading;
		private static MainView mainInstance;

		public LoadingForm()
		{
			InitializeComponent();
			this.Owner = OwnerFormInstance();
		}
		private MainView OwnerFormInstance()
		{
			return mainInstance ?? (mainInstance = new MainView());
		}
		public static LoadingForm Instance()
		{
			return loading ?? (loading = new LoadingForm());
		}
	}
}
