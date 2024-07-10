using ViolationsCollecting.Model.Entities;
using ViolationsCollecting.View.CustomeComponants;
using static ViolationsCollecting.View.IMainView;

namespace ViolationsCollecting.View
{
	public partial class MainView : Form, IMainView
	{
		public bool IsInAddingMode { get; set; }
		string IMainView.TruckCode { get => truckCodeBodx1.txtTruckCode; }
		public string ResponableUnit { get => comboUnit.Text; }
		public string ElManfaz { get => txtElManfaz.Text; }
		public DateTime TheDate { get => new DateTime(2000 + (int)YearNum.Value, (int)MonthNum.Value, (int)DayNum.Value); }
		public string SearchData { get => SearchBar.Text; }
		public BindingSource MainViewBS { get => violationBindingSource; set => violationBindingSource = value; }
		public string Message { get => labelMessage.Text; set => labelMessage.Text = value; }
		public int UpdatedViolationId { get; set; }

		public LoadingForm loading { get => LoadingForm.Instance(this); }
		public MainView()
		{
			InitializeComponent();

			InitializeValues();

			AssesuateEvents();

			HandleEnterNxav();

			AttachEnterEventHandlers(this);
		}

		private void AssesuateEvents()
		{
			btnSave.Click += async delegate { await Save?.Invoke(); };
			SearchBar.TextChanged += delegate { SearchItems?.Invoke(this, EventArgs.Empty); };
			EditTimer.Tick += delegate { OnTimerTick?.Invoke(null, EventArgs.Empty); };
		}

		private void InitializeValues()
		{
			IsInAddingMode = true;
			YearNum.Value = DateTime.Now.Year - 2000;
			MonthNum.Value = DateTime.Now.Month;
			DayNum.Value = DateTime.Now.Day;

			panelWP.Visible = Properties.Settings.Default.ShowWeightAndPyload;
			payloadDataGridViewTextBoxColumn.Visible = Properties.Settings.Default.ShowWeightAndPyload;
			weightDataGridViewTextBoxColumn.Visible = Properties.Settings.Default.ShowWeightAndPyload;

			EditTimer.Interval = (1000 * 60) * 10;
			EditTimer.Start();
		}

		private void HandleEnterNxav()
		{
			comboUnit.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					txtElManfaz.Focus();
			};
			txtElManfaz.KeyDown += (s, e) =>
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
					btnSave.Focus();
			};

		}
		private void AttachEnterEventHandlers(Control parent)
		{
			foreach (Control control in parent.Controls)
			{
				if (control is TextBox textBox)
					textBox.Enter += TextBox_Enter;
				else if (control is ComboBox combo)
					combo.Enter += TextBox_Enter;
				else
					// Recursively call this method for container controls (e.g., panels, group boxes)
					AttachEnterEventHandlers(control);

			}
		}
		private void TextBox_Enter(object sender, EventArgs e)
		{
			if (sender is TextBox textBox)
				textBox.SelectAll();
			else if (sender is ComboBox combo)
				combo.SelectAll();
		}

		public event EventHandler SearchItems;
		public event AsyncEventHandler Save;
		public event EventHandler OnTimerTick;

		private void btnAddMode_Click(object sender, EventArgs e)
		{
			IsInAddingMode = true;
			btnAddMode.BackColor = Color.DeepSkyBlue;
			btnEditMode.BackColor = Color.Gainsboro;

			ClearTextBoxes();
			dataGridView.SelectionChanged -= GetRowData;
		}

		private void btnEditMode_Click(object sender, EventArgs e)
		{
			IsInAddingMode = false;
			btnAddMode.BackColor = Color.Gainsboro;
			btnEditMode.BackColor = Color.DeepSkyBlue;

			ClearTextBoxes();
			dataGridView.SelectionChanged += GetRowData;

		}
		private void GetRowData(object sender, EventArgs e)
		{
			if (dataGridView.CurrentRow != null)
			{
				var violation = (Violation)dataGridView.CurrentRow.DataBoundItem;
				if (violation != null)
				{
					UpdatedViolationId = violation.Id;

					truckCodeBodx1.txtTruckCode = violation.TruckCode;
					comboUnit.Text = violation.Unit;
					txtElManfaz.Text = violation.ElManfaz;
					DayNum.Value = violation.ViolationDate.Day;
					MonthNum.Value = violation.ViolationDate.Month;
					YearNum.Value = violation.ViolationDate.Year - 2000;
					txtWeight.Text = violation.Weight;
					txtPyload.Text = violation.Payload;
				}
			}
		}
		public void SetDeafultSelectedRow()
		{
			dataGridView.Refresh();
			if (dataGridView.Rows.Count > 0)
				dataGridView.Rows[dataGridView.Rows.Count - 1].Selected = true; // Select the desired row
		}

		public void ClearTextBoxes()
		{
			truckCodeBodx1.ClearCodeBoxes();
			SearchBar.Text = "";

			comboUnit.SelectAll();
			txtElManfaz.SelectAll();
			DayNum.Select();
			MonthNum.Select();
			YearNum.Select();
		}
	}
}
