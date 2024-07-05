using System;
using System.Windows.Forms;
using ViolationsSystem.Views.Interfaces;

namespace ViolationsSystem.Views
{
    public partial class HomeView : UserControl, IHomeView
    {
        public HomeView()
        {
            InitializeComponent();
            dataGridView.EditModeChanged += delegate{ HandleGridEdit?.Invoke(this, EventArgs.Empty);  };
            dataGridView.UserAddedRow += delegate{ HandleGridAdd?.Invoke(this, EventArgs.Empty);  };
        }
        public BindingSource HomeViewBS { get => violationBindingSource; set => violationBindingSource = value; }
        
        public event EventHandler HandleGridEdit;
        public event EventHandler HandleGridAdd;

        private static HomeView instance;
        public static HomeView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new HomeView();
            return instance;
        }

    }
}
