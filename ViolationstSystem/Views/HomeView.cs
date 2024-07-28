using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ViolationsCollecting.View.CustomeComponants;
using ViolationsSystem.Views.Interfaces;
using ViolationSystem.Data.Entities;

namespace ViolationsSystem.Views
{
	public partial class HomeView : UserControl, IHomeView
	{
		#region Failds
		string IHomeView.TruckCode { get => truckCodeBodx.txtTruckCode; }
		string IHomeView.TruckCodeChars { get => truckCodeBodx.txtCodeChars; }
		string IHomeView.TruckCodeDigits { get => truckCodeBodx.txtCodeDigits; }
		public LoadingForm loading { get => LoadingForm.Instance(); }
		public BindingSource HomeViewBS { get => violationBindingSource; set => violationBindingSource = value; }
		public bool[] ExploredCodesOfTrucks { get; set; }
		public bool[] dublicatedDateCode { get; set; }
		public List<string> FillCodeFiltercheckedList { set => filterUserControle1.FilterList = value; }
		public List<Violation> ModifiedViolations { get; set; }
		public List<Violation> DeletedViolations { get; set; }
		#endregion

		#region Properties
		#endregion
		public HomeView()
        {
            InitializeComponent();

			// initializeValues
			ModifiedViolations = new List<Violation>();
			DeletedViolations = new List<Violation>();

			dataGridView.CellValueChanged += new DataGridViewCellEventHandler(HandleCellEdite);
			dataGridView.CellEndEdit += new DataGridViewCellEventHandler(HandleCellClose);
			dataGridView.UserDeletingRow += new DataGridViewRowCancelEventHandler(HandleDeleteRow);
			dataGridView.CellFormatting += dataGridView_CellFormatting;

			btnSearch.Click += delegate { HandleGetViolationsList?.Invoke(null, EventArgs.Empty); dataGridView.Refresh(); };
			truckCodeBodx.msChar.KeyDown += (s, e) => 
			{
				if (e.KeyCode == Keys.Enter)
					HandleGetViolationsList?.Invoke(null, EventArgs.Empty);
			};
			truckCodeBodx.msDigits.KeyDown += (s, e) => 
			{
				if (e.KeyCode == Keys.Enter)
					HandleGetViolationsList?.Invoke(null, EventArgs.Empty);
			};
			btnImportExcel.Click += delegate { HandleImport?.Invoke(null, EventArgs.Empty); };
			btnApplyChanges.Click += ApplyChanges;
			filterUserControle1.btnApplyFilter.Click += delegate { UpdateDG?.Invoke(filterUserControle1.FilterList, EventArgs.Empty); dataGridView.Refresh(); };
			this.Load += HomeView_Load;
		}

		#region Events

		public event EventHandler HandleImport;
		public event EventHandler HandleGetViolationsList;
		public event EventHandler UpdateDG;
		public event EventHandler SaveChangesEvent;
		public event EventHandler PrintEvent;
		#endregion
		#region ViewMethods

		private void btnPrint_Click(object sender, EventArgs e)
		{
			loading.Show();
			var list = new List<Violation>();
			var itme = new Violation();
			for (int i = 0; i < dataGridView.Rows.Count; i++)
			{
				itme = (Violation)dataGridView.Rows[i].DataBoundItem;
				itme.TruckCode = dataGridView.Rows[i].Cells[2].FormattedValue.ToString();
				list.Add(itme);
			}

			PrintEvent?.Invoke(list, EventArgs.Empty);
			loading.Hide();
		}
		private void HandleCellEdite(object sender, DataGridViewCellEventArgs e)
		=> dataGridView[e.ColumnIndex, e.RowIndex].Value = dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString().Replace(" ", "");

		private void HandleDeleteRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			var rowToDelete = (Violation)e.Row.DataBoundItem;
			DeletedViolations.Add(rowToDelete);
			ModifiedViolations.Remove(ModifiedViolations.FirstOrDefault(x => x.Id == rowToDelete.Id));
		}

		private void HandleCellClose(object sender, DataGridViewCellEventArgs e)
		{
			var rowToAdd = (Violation)dataGridView.Rows[e.RowIndex].DataBoundItem;
			var existRow = ModifiedViolations.FirstOrDefault(x => x.Id == rowToAdd.Id);
			if (existRow != null)
				ModifiedViolations.Remove(existRow);

			ModifiedViolations.Add(rowToAdd);
		}
			//SwitchToSaveMode(true);

		private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// Check if we are formatting the correct column
			if (e.ColumnIndex == 1)
				e.Value = e.RowIndex +1;
			if (e.ColumnIndex == 2 && e.Value != null)
			{
				string originalTruckCode = e.Value.ToString();

				if(originalTruckCode.Length > 5)
				{
					var digits = originalTruckCode.Substring(originalTruckCode.Length - 4);
					var chars = string.Join(" ", originalTruckCode.Substring(0, (originalTruckCode.Length - 4)).ToCharArray());
				
					string formattedValue = string.Join(" ", chars, digits);
					e.Value = formattedValue;
					e.FormattingApplied = true;
				}
				if (ExploredCodesOfTrucks[e.RowIndex])
					e.CellStyle.BackColor = Color.FromArgb(255, 255, 128);

			}
			if (e.ColumnIndex == 3)
			{
				if (dublicatedDateCode[e.RowIndex])
					e.CellStyle.BackColor = Color.FromArgb(255, 192, 128);

			}
		}
		private void ApplyChanges(object sender, EventArgs e)
		{
			try
			{
				if (dataGridView.SelectedRows != null)
				{

					// UpdateDG (UI)
					foreach (DataGridViewRow item in dataGridView.SelectedRows)
					{
						item.Cells[6].Value = txtReportNumber.Text;
						item.Cells[7].Value = txtPaymentDate.Date;
						item.Cells[8].Value = txtBlockDate.Date;

						var rowToAdd = (Violation)item.DataBoundItem;
						var existRow = ModifiedViolations.FirstOrDefault(x => x.Id == rowToAdd.Id);
						if(existRow != null)
							ModifiedViolations.Remove(existRow);
							
						ModifiedViolations.Add(rowToAdd);
					}
					
					//SwitchToSaveMode(true);
				}
			}
			catch { }
		}
		private List<Violation> GetRowsData()
		{
			var list = new List<Violation>();
			for (int i = 0; i < dataGridView.Rows.Count; i++)
			{
				var row = (Violation)dataGridView.Rows[i].DataBoundItem;
				row.Truck.TruckCode = row.TruckCode;
				list.Add(row);
			}
			return list;
		}
		private static HomeView instance;
		public static HomeView GetInstance()
		{
			if (instance == null || instance.IsDisposed)
				instance = new HomeView();
			return instance;
		}

		#endregion

		private void btnSaveChages_Click(object sender, EventArgs e)
		{
			loading.Show();
			var list = GetRowsData();
            
			SaveChangesEvent?.Invoke(list, EventArgs.Empty);
			ModifiedViolations.Clear();
			DeletedViolations.Clear();

			//SwitchToSaveMode(false);
			loading.Hide();
		}

		private void SwitchToSaveMode(bool v)
		{
			truckCodeBodx.SetBoxesEnable = !v;
			btnSearch.Enabled = !v;
			btnSaveChages.Enabled = v;
		}

		private void HomeView_Load(object sender, EventArgs e)
		{
			//HandleGetViolationsList?.Invoke(null, EventArgs.Empty);
		}

	}
}
