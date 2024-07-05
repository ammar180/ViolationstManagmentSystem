using System.Drawing;
using System.Windows.Forms;

namespace ViolationsSystem.Views
{
	partial class HomeView
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.flowLayoutPanelOptions = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnImportExcel = new System.Windows.Forms.Button();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.panelGrid = new System.Windows.Forms.Panel();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.violationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.truckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.payloadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.truckIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BlockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ResponsibleUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.violationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.flowLayoutPanelOptions.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanelOptions
			// 
			this.flowLayoutPanelOptions.AutoScroll = true;
			this.flowLayoutPanelOptions.AutoSize = true;
			this.flowLayoutPanelOptions.Controls.Add(this.panel1);
			this.flowLayoutPanelOptions.Controls.Add(this.btnImportExcel);
			this.flowLayoutPanelOptions.Controls.Add(this.btnExportExcel);
			this.flowLayoutPanelOptions.Controls.Add(this.btnPrint);
			this.flowLayoutPanelOptions.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanelOptions.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanelOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.flowLayoutPanelOptions.Name = "flowLayoutPanelOptions";
			this.flowLayoutPanelOptions.Padding = new System.Windows.Forms.Padding(10);
			this.flowLayoutPanelOptions.Size = new System.Drawing.Size(988, 68);
			this.flowLayoutPanelOptions.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.txtSearch);
			this.panel1.Location = new System.Drawing.Point(693, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(272, 42);
			this.panel1.TabIndex = 5;
			// 
			// btnSearch
			// 
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnSearch.Image = global::ViolationstSystem.Properties.Resources.Search_1;
			this.btnSearch.Location = new System.Drawing.Point(0, 0);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(49, 42);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// txtSearch
			// 
			this.txtSearch.Dock = System.Windows.Forms.DockStyle.Right;
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(56, 0);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(216, 38);
			this.txtSearch.TabIndex = 3;
			this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnImportExcel
			// 
			this.btnImportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnImportExcel.Location = new System.Drawing.Point(516, 15);
			this.btnImportExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnImportExcel.Name = "btnImportExcel";
			this.btnImportExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnImportExcel.Size = new System.Drawing.Size(170, 38);
			this.btnImportExcel.TabIndex = 0;
			this.btnImportExcel.Text = "ادراج اكسل";
			this.btnImportExcel.UseVisualStyleBackColor = true;
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExportExcel.Location = new System.Drawing.Point(338, 15);
			this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(170, 38);
			this.btnExportExcel.TabIndex = 1;
			this.btnExportExcel.Text = "استخراج اكسل";
			this.btnExportExcel.UseVisualStyleBackColor = true;
			// 
			// btnPrint
			// 
			this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrint.Location = new System.Drawing.Point(160, 15);
			this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(170, 38);
			this.btnPrint.TabIndex = 2;
			this.btnPrint.Text = "طباعة";
			this.btnPrint.UseVisualStyleBackColor = true;
			// 
			// panelGrid
			// 
			this.panelGrid.Controls.Add(this.dataGridView);
			this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelGrid.Location = new System.Drawing.Point(0, 68);
			this.panelGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panelGrid.Name = "panelGrid";
			this.panelGrid.Size = new System.Drawing.Size(988, 345);
			this.panelGrid.TabIndex = 1;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.violationDateDataGridViewTextBoxColumn,
            this.truckDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.payloadDataGridViewTextBoxColumn,
            this.reportNumberDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.truckIdDataGridViewTextBoxColumn,
            this.BlockDate,
            this.ResponsibleUnit});
			this.dataGridView.DataSource = this.violationBindingSource;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.GridColor = System.Drawing.SystemColors.Desktop;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.Size = new System.Drawing.Size(988, 345);
			this.dataGridView.TabIndex = 0;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// violationDateDataGridViewTextBoxColumn
			// 
			this.violationDateDataGridViewTextBoxColumn.DataPropertyName = "ViolationDate";
			this.violationDateDataGridViewTextBoxColumn.HeaderText = "تاريخ المخالفة";
			this.violationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.violationDateDataGridViewTextBoxColumn.Name = "violationDateDataGridViewTextBoxColumn";
			// 
			// truckDataGridViewTextBoxColumn
			// 
			this.truckDataGridViewTextBoxColumn.DataPropertyName = "TruckCode";
			this.truckDataGridViewTextBoxColumn.HeaderText = "رقم السيارة";
			this.truckDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.truckDataGridViewTextBoxColumn.Name = "truckDataGridViewTextBoxColumn";
			// 
			// weightDataGridViewTextBoxColumn
			// 
			this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			this.weightDataGridViewTextBoxColumn.HeaderText = "الوزن";
			this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			// 
			// payloadDataGridViewTextBoxColumn
			// 
			this.payloadDataGridViewTextBoxColumn.DataPropertyName = "Payload";
			this.payloadDataGridViewTextBoxColumn.HeaderText = "الحمولة";
			this.payloadDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.payloadDataGridViewTextBoxColumn.Name = "payloadDataGridViewTextBoxColumn";
			// 
			// reportNumberDataGridViewTextBoxColumn
			// 
			this.reportNumberDataGridViewTextBoxColumn.DataPropertyName = "ReportNumber";
			this.reportNumberDataGridViewTextBoxColumn.HeaderText = "رقم البلاغ";
			this.reportNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.reportNumberDataGridViewTextBoxColumn.Name = "reportNumberDataGridViewTextBoxColumn";
			// 
			// paymentDateDataGridViewTextBoxColumn
			// 
			this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
			this.paymentDateDataGridViewTextBoxColumn.HeaderText = "تاريخ السداد";
			this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
			// 
			// truckIdDataGridViewTextBoxColumn
			// 
			this.truckIdDataGridViewTextBoxColumn.DataPropertyName = "TruckId";
			this.truckIdDataGridViewTextBoxColumn.HeaderText = "TruckId";
			this.truckIdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.truckIdDataGridViewTextBoxColumn.Name = "truckIdDataGridViewTextBoxColumn";
			this.truckIdDataGridViewTextBoxColumn.Visible = false;
			// 
			// BlockDate
			// 
			this.BlockDate.DataPropertyName = "BlockDate";
			this.BlockDate.HeaderText = "تاريخ الحجز";
			this.BlockDate.MinimumWidth = 6;
			this.BlockDate.Name = "BlockDate";
			// 
			// ResponsibleUnit
			// 
			this.ResponsibleUnit.HeaderText = "الوحدة المسؤولة";
			this.ResponsibleUnit.MinimumWidth = 6;
			this.ResponsibleUnit.Name = "ResponsibleUnit";
			// 
			// violationBindingSource
			// 
			this.violationBindingSource.DataSource = typeof(ViolationSystem.Data.Entities.Violation);
			// 
			// HomeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelGrid);
			this.Controls.Add(this.flowLayoutPanelOptions);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "HomeView";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(988, 413);
			this.flowLayoutPanelOptions.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FlowLayoutPanel flowLayoutPanelOptions;
		private Button btnImportExcel;
		private Panel panelGrid;
		private TextBox txtSearch;
		private Button btnExportExcel;
		private Button btnPrint;
		private Button btnSearch;
        private BindingSource violationBindingSource;
        private DataGridView dataGridView;
        private Panel panel1;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn violationDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn truckDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn payloadDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn reportNumberDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn truckIdDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn BlockDate;
		private DataGridViewTextBoxColumn ResponsibleUnit;
	}
}
