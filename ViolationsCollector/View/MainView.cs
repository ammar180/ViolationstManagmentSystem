using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationsCollector.Model.Entities;
using ViolationsCollector.Presenter;
using ViolationsCollector.View.CustomeComponants;

namespace ViolationsCollector.View
{
	public partial class MainView : Form, IMainView
	{
		#region Failds
		public bool IsInAddingMode { get => btnAddMode.Checked; }
		string IMainView.TruckCode { get => truckCodeBodx1.txtTruckCode; }
		public string ResponableUnit { get => comboUnit.Text; }
		public string ElManfaz { get => txtElManfaz.Text; }
		public DateTime TheDate { get => dateBox1.Date; }
		public BindingSource MainViewBS { get => violationBindingSource; set => violationBindingSource = value; }
		public int UpdatedViolationId { get; set; }
		public int MonthToExport { get => (int)dateBox1.MonthNum.Value; }
		public LoadingForm loading { get => LoadingForm.Instance(this); }
		// Validations Message
		public string CodeMessage { set => labCodeMessage.Text = value; }
		public string UnitMessage { set => labUnitMessage.Text = value; }
		public string ElManfazMessage { set => labElManfazMessage.Text = value; }
		#endregion
		public MainView()
		{
			InitializeComponent();

			AssesuateEvents();

			InitializeValues();			
		}

		private void AssesuateEvents()
		{
			btnSave.Click += async delegate { await Save?.Invoke(); };
			//truckCodeBoxSearch.TruckCodeChange += delegate { SearchItems?.Invoke(this, EventArgs.Empty); };
			//EditTimer.Tick += delegate { OnTimerTick?.Invoke(null, EventArgs.Empty); };
			btnExport.Click += async delegate { await ExportEvent?.Invoke(); };
			truckCodeBodx1.n4.KeyDown += async (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				    await Save?.Invoke();
			};
			dateBox1.MonthNum.ValueChanged += async delegate
			{
				await UpdateRowsEvent?.Invoke();
			};
			dataGridView.CellFormatting += dataGridView_CellFormatting;

		}

		private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.ColumnIndex == 1 && e.Value != null)
			{
				string originalTruckCode = e.Value.ToString();

				if (originalTruckCode.Length > 5)
				{
					var digits = originalTruckCode.Substring(originalTruckCode.Length - 4);
					var chars = string.Join(" ", originalTruckCode.Substring(0, (originalTruckCode.Length - 4)).ToCharArray());

					string formattedValue = string.Join(" ", chars, digits);
					e.Value = formattedValue;
					e.FormattingApplied = true;
				}
			}
		}

		private void InitializeValues()
		{
			panelWP.Visible = Properties.Settings.Default.ShowWeightAndPyload;
			payloadDataGridViewTextBoxColumn.Visible = Properties.Settings.Default.ShowWeightAndPyload;
			weightDataGridViewTextBoxColumn.Visible = Properties.Settings.Default.ShowWeightAndPyload;
			comboUnit.Text = Properties.Settings.Default.AppUnit;

			UpdatedViolationId = -1;

			EditTimer.Interval = (1000 * 60) * 10;
			EditTimer.Start();

			truckCodeBodx1.a1.Focus();
		}
		public event EventHandler SearchItems;
		public event AsyncEventHandler Save;
		public event EventHandler OnTimerTick;
		public event AsyncEventHandler ExportEvent;
		public event AsyncEventHandler UpdateRowsEvent;

		private void btnAddMode_CheckedChanged(object sender, EventArgs e)
		{
			//MessageBox.Show(
			//	"جميع الحقوق محفوظة للمبرمج عمار احمد عمران ©2024 - الطالب بمدرسة السويدي الدولية \n" +
			//	" اذا واجهت مشكلة يرجى التواصل على الايميل: ammaromran.work@gmail.com",
			//	"حول",
			//	MessageBoxButtons.OK,
			//	MessageBoxIcon.Information
			//	);
			btnAddMode.BackColor = btnAddMode.Checked ? Color.LightGreen : Color.Transparent;
			btnEditMode.BackColor = btnAddMode.Checked ? Color.Transparent : Color.LightGreen;
			
			ClearTextBoxes();

			if (IsInAddingMode)
				dataGridView.SelectionChanged -= GetRowData;
			else // Edit Mode
			{
				dataGridView.SelectionChanged += GetRowData;
				GetRowData(null, EventArgs.Empty);
			}
		}
		private void GetRowData(object sender, EventArgs e)
		{
			try
			{
				if (dataGridView.CurrentRow != null)
				{
					var violation = (Violation)dataGridView.CurrentRow.DataBoundItem;
					if (violation != null && !ViolationEditExpaired(violation))
					{
						UpdatedViolationId = violation.Id;

						truckCodeBodx1.txtTruckCode = violation.TruckCode;
						comboUnit.Text = violation.Unit;
						txtElManfaz.Text = violation.ElManfaz;

						dateBox1.Date = violation.ViolationDate;

						txtWeight.Text = violation.Weight;
						txtPyload.Text = violation.Payload;
					}
					else
					{
						UpdatedViolationId = -1;
						ClearTextBoxes();
					}
				}
			}
			catch { }
		}

		private bool ViolationEditExpaired(Violation violation) 
			=> DateTime.Now > violation.RegistrationDate + Properties.Settings.Default.TimeToExpired;

		public void ClearTextBoxes()
		{
			truckCodeBodx1.ClearCodeBoxes();

			comboUnit.SelectAll();
			txtElManfaz.SelectAll();

			truckCodeBodx1.a1.Focus();
		}

		private void comboUnit_SelectedIndexChanged(object sender, EventArgs e)
		{
			var ListOfElMnafez = new string[] { };
			switch (comboUnit.Text)
			{
				case "كرداسة":
					ListOfElMnafez = new string[] { "صفط", "المعتمدية", "ابورواش", "كرداسة", "الصليبة" };
					break;
				case "البدرشين":
					ListOfElMnafez = new string[] { "مزغونة", "أبوربع" };
					break;
				case "منشاة القناطر":
					ListOfElMnafez = new string[] { "المحطة", "القطا", "الدرية", "نكلا الرهاوي", "كوبري القناطر", "نكلا المرور" };
					break;
				case "الصف":
					ListOfElMnafez = new string[] { "الودي", "حسن عودة", "الصوارخ", "أبو عوض", "علاء شاهين", "الميزان" };
					break;
				case "العياط":
					ListOfElMnafez = new string[] { "الرقة", "الضبعي", "الملطة خارجي", "جرزا", "طهما", "السبيل" };
					break;
				case "ابو النمرس":
					ListOfElMnafez = new string[] { "شبرامنت", "نزلة الأشطر", "المزلقان" };
					break;
				case "الواحات البحرية":
					ListOfElMnafez = new string[] { "المناجم", "منديشه" };
					break;
				case "اطفيح":
					ListOfElMnafez = new string[] { "المرتبة", "صول", "الكريمات", "الحللف" };
					break;
				case "اكتوبر":
					ListOfElMnafez = new string[] { "النشية", "الحرانية", "السفارة", "المنصورية", "المريوطية", "السياحي", "القصبجي" };
					break;

				default:
					break;
			}
			txtElManfaz.AutoCompleteCustomSource.Clear();
			txtElManfaz.Items.Clear();

			txtElManfaz.AutoCompleteCustomSource.AddRange(ListOfElMnafez);
			txtElManfaz.Items.AddRange(ListOfElMnafez);

			txtElManfaz.Text = ListOfElMnafez.FirstOrDefault()??"";
		}

		private void btnUpdateExportPath_Click(object sender, EventArgs e)
		{
			string path = ExcelHelper.GetPath();
			if(path != "")
			{
				Properties.Settings.Default.ExportPath = path;
				Properties.Settings.Default.Save();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				// Get the path of the update.exe file in the same directory as the application
				string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
				string updateFilePath = Path.Combine(appDirectory, "updater.exe");

				// Check if the update.exe file exists
				if (File.Exists(updateFilePath))
				{
					// Start the update.exe process
					System.Diagnostics.Process.Start(updateFilePath);
				}
				else
				{
					MessageBox.Show("Update file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				// Handle any errors that may occur when trying to start the process
				MessageBox.Show($"An error occurred while trying to start the update: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
