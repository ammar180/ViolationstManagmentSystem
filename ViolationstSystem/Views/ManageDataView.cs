using System;
using System.Windows.Forms;
using ViolationsSystem.Views.Interfaces;

namespace ViolationsSystem.Views
{
    public partial class ManageDataView : UserControl, IManageDataView
    {
        public ManageDataView()
        {
            InitializeComponent();
            btnImportExcel.Click += delegate { HandleImport?.Invoke(null, EventArgs.Empty); };
        }
        public BindingSource HomeViewBS { get => violationBindingSource; set => violationBindingSource = value; }
        public event EventHandler HandleImport;
        
        private static ManageDataView instance;
        public static ManageDataView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new ManageDataView();
            return instance;
        }

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
