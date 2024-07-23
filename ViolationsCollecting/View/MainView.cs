using ViolationsCollecting.Model.Entities;
using ViolationsCollecting.View.CustomeComponants;
using static ViolationsCollecting.View.IMainView;

namespace ViolationsCollecting.View
{
	public partial class MainView : Form, IMainView
	{
		#region Failds
		public bool IsInAddingMode { get; set; }
		string IMainView.TruckCode { get => truckCodeBodx1.txtTruckCode; }
		public string ResponableUnit { get => comboUnit.Text; }
		public string ElManfaz { get => txtElManfaz.Text; }
		public DateTime TheDate { get => dateBox1.Date; }
		public BindingSource MainViewBS { get => violationBindingSource; set => violationBindingSource = value; }
		public int UpdatedViolationId { get; set; }
		public int MonthToExport { get => (int)NumMonthToExport.Value; }
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
			EditTimer.Tick += delegate { OnTimerTick?.Invoke(null, EventArgs.Empty); };
			btnExport.Click += async delegate { await ExportEvent?.Invoke(); };
			truckCodeBodx1.n4.KeyDown += async (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					await Save?.Invoke();
			};
		}

		private void InitializeValues()
		{
			IsInAddingMode = true;
			NumMonthToExport.Value = DateTime.Now.Month;

			panelWP.Visible = Properties.Settings.Default.ShowWeightAndPyload;
			payloadDataGridViewTextBoxColumn.Visible = Properties.Settings.Default.ShowWeightAndPyload;
			weightDataGridViewTextBoxColumn.Visible = Properties.Settings.Default.ShowWeightAndPyload;
			comboUnit.Text = Properties.Settings.Default.AppUnit;


			EditTimer.Interval = (1000 * 60) * 10;
			EditTimer.Start();

			truckCodeBodx1.a1.Focus();
		}

		public event EventHandler SearchItems;
		public event AsyncEventHandler Save;
		public event EventHandler OnTimerTick;
		public event AsyncEventHandler ExportEvent;

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
			try
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

						dateBox1.Date = violation.ViolationDate;

						txtWeight.Text = violation.Weight;
						txtPyload.Text = violation.Payload;
					}
				}
			}
			catch { }
		}
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
					ListOfElMnafez = ["صفط", "المعتمدية", "ابورواش", "كرداسة", "الصليبة"];
					break;
			    case "البدرشين":
					ListOfElMnafez = ["مزغونة", "أبوربع"];
					break;
				case "منشاة القناطر":
					ListOfElMnafez = ["المحطة", "القطا", "الدرية", "نكلا الرهاوي", "كوبري القناطر", "نكلا المرور"];
					break;
			    case "الصف":
					ListOfElMnafez = ["الودي", "حسن عودة", "الصوارخ", "أبو عوض", "علاء شاهين", "الميزان"];
					break;
			    case "العياط":
					ListOfElMnafez = ["الرقة", "الضبعي", "الملطة خارجي", "جرزا", "طهما", "السبيل"];
					break;
			    case "ابو نمرس":
					ListOfElMnafez = ["شبرامنت", "نزلة الأشطر", "المزلقان"];
					break;
			    case "الواحات البحرية":
					ListOfElMnafez = ["المناجم", "منديشه"];
					break;
			    case "اطفيح":
					ListOfElMnafez = ["المرتبة", "صول", "الكريمات", "الحللف"];
					break;
			    case "اكتوبر":
					ListOfElMnafez = ["النشية", "الحرانية", "السفارة", "المنصورية", "المريوطية", "السياحي", "الفصبجي"];
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
	}
}
