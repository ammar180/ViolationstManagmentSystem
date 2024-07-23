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
		string IHomeView.TruckCode { get => truckCodeBodx.txtTruckCode; }
		string IHomeView.TruckCodeChars { get => truckCodeBodx.txtCodeChars; }
		string IHomeView.TruckCodeDigits { get => truckCodeBodx.txtCodeDigits; }
		public LoadingForm loading { get => LoadingForm.Instance(); }

		public HomeView()
        {
            InitializeComponent();

            // Subscribe to events
            //dataGridView.UserAddedRow += new DataGridViewRowEventHandler(HandleGridAdd);
            //dataGridView.UserDeletedRow += new DataGridViewRowEventHandler(HandleGridDelete);

            //dataGridView.CellBeginEdit += new DataGridViewCellCancelEventHandler(); //
            //dataGridView.CellEndEdit += new DataGridViewCellEventHandler(); //==> SaveChages
            //dataGridView.CellValueChanged += new DataGridViewCellEventHandler(HandleGridEdit);
            btnSearch.Click += delegate { HandleGetViolationsList?.Invoke(null, EventArgs.Empty); };
			truckCodeBodx.txtChars.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					HandleGetViolationsList?.Invoke(null, EventArgs.Empty);
			};
			truckCodeBodx.txtDigits.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					HandleGetViolationsList?.Invoke(null, EventArgs.Empty);
			};
			btnImportExcel.Click += delegate { HandleImport?.Invoke(null, EventArgs.Empty); };
			dataGridView.CellFormatting += dataGridView_CellFormatting;
		}
		public BindingSource HomeViewBS { get => violationBindingSource; set => violationBindingSource = value; }
		public HashSet<string> ExploredCodesOfTrucks { get; set; }

		public event EventHandler HandleGridEdit;
        public event EventHandler HandleGridAdd;
        public event EventHandler HandleGridDelete;

		public event EventHandler HandleImport;
		public event EventHandler HandleGetViolationsList;
		public event EventHandler UpdateDG;

		private static HomeView instance;
        public static HomeView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new HomeView();
            return instance;
        }

		private void btnPrint_Click(object sender, EventArgs e)
		{
		}

		public void FillCodeFiltercheckedList(List<string> list)
		{
			CodeFiltercheckedList.Items.Clear();
		    list.ForEach(x => CodeFiltercheckedList.Items.Add(x, true) );
		}


		private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < CodeFiltercheckedList.Items.Count; i++)
				CodeFiltercheckedList.SetItemChecked(i, checkBoxSelectAll.Checked);
		}

		private void btnApplyFilter_Click(object sender, EventArgs e)
		{
			List<string> CodeList = CodeFiltercheckedList.CheckedItems.Cast<string>().ToList();

			UpdateDG?.Invoke(CodeList, EventArgs.Empty);
		}
		private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// Check if we are formatting the correct column
			if (e.ColumnIndex == 1)
				e.Value = e.RowIndex +1;
			if (e.ColumnIndex == 2 && e.Value != null)
			{
				string originalTruckCode = e.Value.ToString();
				var digits = originalTruckCode.Substring(3);
				var chars = string.Join(" ", originalTruckCode.Substring(0, 3).ToCharArray());
				
				string formattedValue = string.Join(" ", chars, digits);
				e.Value = formattedValue;
				e.FormattingApplied = true;

				// ------ if is explored 0-0-0
				if (ExploredCodesOfTrucks?.Contains(originalTruckCode)??false)
					e.CellStyle.BackColor = Color.FromArgb(255, 255, 128);

			}
		}

	}
}
