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
		public string TruckCodeChars { get => truckCodeBodx.txtCodeChars; }
		public string TruckCodeDigits { get => truckCodeBodx.txtCodeDigits; }
		public string PrintName { get => txtName.Text; }
		public LoadingForm loading { get => LoadingForm.Instance(); }
		public BindingSource HomeViewBS { get => violationBindingSource; set => violationBindingSource = value; }
		#endregion

		#region Properties
		public bool[] ExploredCodesOfTrucks { get; set; }
		public bool[] dublicatedDateCode { get; set; }
		public List<string> FillCodeFiltercheckedList { set => filterUserControle1.FilterList = value; }
		public List<Violation> ModifiedViolations { get; set; }
		public List<Violation> DeletedViolations { get; set; }

		private string originalCellValue;
		#endregion
		public HomeView()
        {
            InitializeComponent();

			// initializeValues
			ModifiedViolations = new List<Violation>();
			DeletedViolations = new List<Violation>();

			dataGridView.CellBeginEdit += DataGridView_CellBeginEdit;
			dataGridView.CellEndEdit += new DataGridViewCellEventHandler(HandleCellEdite);
			dataGridView.UserDeletingRow += new DataGridViewRowCancelEventHandler(HandleDeleteRow);
			dataGridView.CellFormatting += dataGridView_CellFormatting;

			btnSearch.Click += delegate {
				HandleGetViolationsList?.Invoke(null, EventArgs.Empty); 
				dataGridView.Refresh();
			};
			truckCodeBodx.msChar.KeyDown += (s, e) => 
			{
				if (truckCodeBodx.txtTruckCode.Length >= 3)
					if (e.KeyCode == Keys.Enter)
						HandleGetViolationsList?.Invoke(null, EventArgs.Empty);
				
			};
			truckCodeBodx.msChar.TextChanged += change_enable;
			truckCodeBodx.msDigits.KeyDown += (s, e) => 
			{
				if (truckCodeBodx.txtTruckCode.Length >= 3)
					if (e.KeyCode == Keys.Enter)
						HandleGetViolationsList?.Invoke(null, EventArgs.Empty);
			};
			truckCodeBodx.msDigits.TextChanged += change_enable;
			txtName.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					loading.Show();
					var list = new List<Violation>();
					var item = new Violation();
					for (int i = 0; i < dataGridView.Rows.Count; i++)
					{
						item = (Violation)dataGridView.Rows[i].DataBoundItem;
						item.TruckCode = dataGridView.Rows[i].Cells[2].Value.ToString();
						list.Add(item);
					}

					PrintEvent?.Invoke(list, EventArgs.Empty);
					loading.Hide();
				}
			};


			btnImportExcel.Click += delegate { HandleImport?.Invoke(null, EventArgs.Empty); };
			btnApplyChanges.Click += ApplyChanges;
			filterUserControle1.btnApplyFilter.Click += delegate { UpdateDG?.Invoke(filterUserControle1.FilterList, EventArgs.Empty); dataGridView.Refresh(); };

			dataGridView.SelectionChanged += DataGridView_SelectionChanged;

			this.loading.FormShown += Loading_Shown;
			this.loading.FormHiding += Loading_FormHiding;
		}
		#region Events

		public event EventHandler HandleImport;
		public event EventHandler HandleGetViolationsList;
		public event EventHandler UpdateDG;
		public event EventHandler SaveChangesEvent;
		public event EventHandler PrintEvent;
		#endregion

		#region ViewMethods

		private void change_enable(object sender, EventArgs e)
		{
			btnSearch.Enabled = truckCodeBodx.txtTruckCode.Length >= 3;
			btnPrint.Enabled = truckCodeBodx.txtTruckCode.Length >= 3;
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				if (dataGridView.CurrentRow != null)
				{
					var violation = (Violation)dataGridView.CurrentRow.DataBoundItem;
					if (violation != null)
					{
						txtReportNumber.Text = violation.ReportNumber;
						if (violation.BlockDate != null)
							txtBlockDate.Date = violation.BlockDate;
						if (violation.PaymentDate != null)
							txtPaymentDate.Date = violation.PaymentDate;
					}
				}
			}
			catch { }
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			txtName.Visible = !txtName.Visible;
		}
		private void HandleCellEdite(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var c = dataGridView[e.ColumnIndex, e.RowIndex].Value?.ToString().Replace(" ", "");
				var rowToEdit = (Violation)dataGridView.Rows[e.RowIndex].DataBoundItem;

				if (e.ColumnIndex == 2)
				{
					if (c != null && c.Length >= 5 && c != originalCellValue)
						rowToEdit.TruckCode = c;
					else
					{
						dataGridView[e.ColumnIndex, e.RowIndex].Value = originalCellValue;
						throw new Exception("Invalid Truck Code");
					}
				}

				ModifiedViolations.Remove(ModifiedViolations.FirstOrDefault(x => x.Id == rowToEdit.Id));
				ModifiedViolations.Add(rowToEdit);
				btnSaveChages.BackColor = Color.DeepSkyBlue;
			}
			catch { }
		}

		private void HandleDeleteRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			var rowToDelete = (Violation)e.Row.DataBoundItem;
			DeletedViolations.Add(rowToDelete);
			ModifiedViolations.Remove(ModifiedViolations.FirstOrDefault(x => x.Id == rowToDelete.Id));
			dublicatedDateCode[e.Row.Index] = false;
			btnSaveChages.BackColor = Color.DeepSkyBlue;
		}

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
						if(txtReportNumber.Enabled)
							item.Cells[7].Value = txtReportNumber.Text;
						if (txtBlockDate.Enabled)
						{
							if (txtBlockDate.Date.HasValue)
								item.Cells[8].Value = txtBlockDate.Date.ToString();
							else
								item.Cells[8].Value = "";
						}
						if (txtPaymentDate.Enabled)
						{
							if(txtPaymentDate.Date.HasValue)
								item.Cells[9].Value = txtPaymentDate.Date.ToString();
							else
								item.Cells[9].Value = "";
						}

						var rowToUpdate = (Violation)item.DataBoundItem;
						ModifiedViolations.Remove(ModifiedViolations.FirstOrDefault(x => x.Id == rowToUpdate.Id));
						
						ModifiedViolations.Add(rowToUpdate);
					}
					btnSaveChages.BackColor = Color.DeepSkyBlue;

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
				//row.Truck.TruckCode = row.TruckCode;
				list.Add(row);
			}
			return list;
		}
		
		private void btnSaveChages_Click(object sender, EventArgs e)
		{
			loading.Show();
			var list = GetRowsData();
            
			SaveChangesEvent?.Invoke(list, EventArgs.Empty);
			ModifiedViolations.Clear();
			DeletedViolations.Clear();
			btnSaveChages.BackColor = DefaultBackColor;

			//SwitchToSaveMode(false);
			loading.Hide();
		}

		private void Loading_FormHiding(object sender, EventArgs e)
			=> SetBtnsEnabled(true);
		private void Loading_Shown(object sender, EventArgs e)
			=> SetBtnsEnabled(false);
		private void SetBtnsEnabled(bool v) 
			=> btnShowFilter.Enabled =
			btnSaveChages.Enabled =
			btnImportExcel.Enabled =
			btnApplyChanges.Enabled = v;
		private void btnShowFilter_Click(object sender, EventArgs e)
		{
			btnShowFilter.Text = filterUserControle1.Visible ? "الفلاتر 🔼" : "الفلاتر 🔽";
			filterUserControle1.Visible = !filterUserControle1.Visible;
		}

		private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
			=> originalCellValue = dataGridView[e.ColumnIndex, e.RowIndex].Value?.ToString() ?? "";
		private void checkState_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			switch (checkBox.Text)
			{
				case "رقم البلاغ":
					txtReportNumber.Enabled = checkBox.Checked;
					break;
				case "تاريخ السداد":
					txtPaymentDate.Enabled = checkBox.Checked;
					break;
				case "تاريخ الحجز":
					txtBlockDate.Enabled = checkBox.Checked;
					break;

				default:
					break;
			}
		}

		#endregion
	}
}
