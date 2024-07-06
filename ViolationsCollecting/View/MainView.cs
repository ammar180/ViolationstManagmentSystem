using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolationsCollecting.View
{
	public partial class MainView : Form, IMainView
	{
		public bool IsInAddingMode { get; set; }
		string IMainView.TruckCode { get => txtCode.Text; }
		public string ResponableUnit { get => comboUnit.Text;}
		public string Elmanfas { get => txtElmanfath.Text;}
		public DateTime TheDate { get => new DateTime(2000 + (int)YearNum.Value, (int)MonthNum.Value, (int)DayNum.Value); }
		public string SearchData { get => SearchBar.Text;}
		public BindingSource MainViewBS { get => violationLayerBindingSource; set => violationLayerBindingSource = value; }

		public MainView()
		{
			InitializeComponent();
			IsInAddingMode = true;
			YearNum.Value = DateTime.Now.Year - 2000;
			MonthNum.Value = DateTime.Now.Month;
			DayNum.Value = DateTime.Now.Day;

			btnSave.Click += delegate { Save?.Invoke(this, EventArgs.Empty); };
			SearchBar.TextChanged += delegate { SearchItems?.Invoke(this, EventArgs.Empty); };

			HandleEnterNxav();
		}

		private void HandleEnterNxav()
		{
			txtCode.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					comboUnit.Focus();
			};
			comboUnit.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					txtElmanfath.Focus();
			};
			txtElmanfath.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					DayNum.Focus();
			};

			DayNum.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					MonthNum.Focus();
			};
			MonthNum.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					YearNum.Focus();
			};
			YearNum.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					Save?.Invoke(this, EventArgs.Empty);
			};

		}

		public event EventHandler SearchItems;
		public event EventHandler Save;

		private void DateGroupBox_Enter(object sender, EventArgs e)
		{

		}

		private void btnAddMode_Click(object sender, EventArgs e)
		{
			IsInAddingMode = true;
			btnAddMode.BackColor = Color.DeepSkyBlue;
			btnEditMode.BackColor = Color.Gainsboro;

			ClearTextBoxes();
		}

		private void btnEditMode_Click(object sender, EventArgs e)
		{
			IsInAddingMode = false;
			btnAddMode.BackColor = Color.Gainsboro;
			btnEditMode.BackColor = Color.DeepSkyBlue;

			ClearTextBoxes();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			MessageBox.Show(ResponableUnit);
		}

		public void ClearTextBoxes()
		{
			txtCode.Text = "";
			SearchBar.Text = "";

			comboUnit.SelectAll();
			txtElmanfath.SelectAll();
			DayNum.Select();
			MonthNum.Select();
			YearNum.Select();
		}
	}
}
