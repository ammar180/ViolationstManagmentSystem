using System.Windows.Forms;
using ViolationsSystem;
using ViolationsSystem.Views;

namespace ViolationsCollecting.View.CustomeComponants
{
	public partial class LoadingForm : Form
	{
		private static LoadingForm loading;
		public static MainView mainViewInstance;

		public LoadingForm()
		{
			InitializeComponent();
			this.Owner = mainViewInstance;
		}
		public static LoadingForm Instance()
		{
			return loading ?? (loading = new LoadingForm());
		}
	}
}
