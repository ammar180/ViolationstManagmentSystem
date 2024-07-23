using System.Drawing;
using System.Windows.Forms;

namespace ViolationsSystem.Views
{
	partial class ManageDataView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.flowLayoutPanelOptions = new System.Windows.Forms.FlowLayoutPanel();
			this.truckCodeBodx1 = new ViolationsCollecting.View.CustomeComponants.TruckCodeBodx();
			this.truckCodeBodx2 = new ViolationsCollecting.View.CustomeComponants.TruckCodeBodx();
			this.btnImportExcel = new System.Windows.Forms.Button();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.violationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.truckCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.violationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.elManfazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.blockDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.truckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanelOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanelOptions
			// 
			this.flowLayoutPanelOptions.AutoSize = true;
			this.flowLayoutPanelOptions.Controls.Add(this.truckCodeBodx1);
			this.flowLayoutPanelOptions.Controls.Add(this.truckCodeBodx2);
			this.flowLayoutPanelOptions.Controls.Add(this.btnImportExcel);
			this.flowLayoutPanelOptions.Controls.Add(this.btnExportExcel);
			this.flowLayoutPanelOptions.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanelOptions.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanelOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.flowLayoutPanelOptions.Name = "flowLayoutPanelOptions";
			this.flowLayoutPanelOptions.Size = new System.Drawing.Size(1062, 106);
			this.flowLayoutPanelOptions.TabIndex = 0;
			// 
			// truckCodeBodx1
			// 
			this.truckCodeBodx1.FirstNumberTextBox = null;
			this.truckCodeBodx1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.truckCodeBodx1.Location = new System.Drawing.Point(559, 3);
			this.truckCodeBodx1.Name = "truckCodeBodx1";
			this.truckCodeBodx1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.truckCodeBodx1.Size = new System.Drawing.Size(500, 100);
			this.truckCodeBodx1.TabIndex = 5;
			// 
			// truckCodeBodx2
			// 
			this.truckCodeBodx2.AutoSize = true;
			this.truckCodeBodx2.FirstNumberTextBox = null;
			this.truckCodeBodx2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.truckCodeBodx2.Location = new System.Drawing.Point(553, 3);
			this.truckCodeBodx2.Name = "truckCodeBodx2";
			this.truckCodeBodx2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.truckCodeBodx2.Size = new System.Drawing.Size(0, 100);
			this.truckCodeBodx2.TabIndex = 6;
			// 
			// btnImportExcel
			// 
			this.btnImportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnImportExcel.Location = new System.Drawing.Point(376, 20);
			this.btnImportExcel.Margin = new System.Windows.Forms.Padding(4, 20, 4, 5);
			this.btnImportExcel.Name = "btnImportExcel";
			this.btnImportExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnImportExcel.Size = new System.Drawing.Size(170, 50);
			this.btnImportExcel.TabIndex = 0;
			this.btnImportExcel.Text = "ادراج اكسل";
			this.btnImportExcel.UseVisualStyleBackColor = true;
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExportExcel.Location = new System.Drawing.Point(198, 20);
			this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 20, 4, 5);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(170, 50);
			this.btnExportExcel.TabIndex = 1;
			this.btnExportExcel.Text = "استخراج اكسل";
			this.btnExportExcel.UseVisualStyleBackColor = true;
			// 
			// violationBindingSource
			// 
			this.violationBindingSource.DataSource = typeof(ViolationSystem.Data.Entities.Violation);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 106);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1062, 490);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "قائمة المخالفات";
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.truckCodeDataGridViewTextBoxColumn,
            this.violationDateDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.elManfazDataGridViewTextBoxColumn,
            this.reportNumberDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.blockDateDataGridViewTextBoxColumn,
            this.truckDataGridViewTextBoxColumn});
			this.dataGridView.DataSource = this.violationBindingSource;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.GridColor = System.Drawing.SystemColors.Desktop;
			this.dataGridView.Location = new System.Drawing.Point(3, 41);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView.RowHeadersWidth = 51;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(1056, 446);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// truckCodeDataGridViewTextBoxColumn
			// 
			this.truckCodeDataGridViewTextBoxColumn.DataPropertyName = "TruckCode";
			this.truckCodeDataGridViewTextBoxColumn.HeaderText = "رقم السيارة";
			this.truckCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.truckCodeDataGridViewTextBoxColumn.Name = "truckCodeDataGridViewTextBoxColumn";
			this.truckCodeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// violationDateDataGridViewTextBoxColumn
			// 
			this.violationDateDataGridViewTextBoxColumn.DataPropertyName = "ViolationDate";
			this.violationDateDataGridViewTextBoxColumn.HeaderText = "تاريخ المخالفة";
			this.violationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.violationDateDataGridViewTextBoxColumn.Name = "violationDateDataGridViewTextBoxColumn";
			this.violationDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// unitDataGridViewTextBoxColumn
			// 
			this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
			this.unitDataGridViewTextBoxColumn.HeaderText = "الوحدة";
			this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
			this.unitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// elManfazDataGridViewTextBoxColumn
			// 
			this.elManfazDataGridViewTextBoxColumn.DataPropertyName = "ElManfaz";
			this.elManfazDataGridViewTextBoxColumn.HeaderText = "المنفذ";
			this.elManfazDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.elManfazDataGridViewTextBoxColumn.Name = "elManfazDataGridViewTextBoxColumn";
			this.elManfazDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// reportNumberDataGridViewTextBoxColumn
			// 
			this.reportNumberDataGridViewTextBoxColumn.DataPropertyName = "ReportNumber";
			this.reportNumberDataGridViewTextBoxColumn.HeaderText = "رقم البلاغ";
			this.reportNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.reportNumberDataGridViewTextBoxColumn.Name = "reportNumberDataGridViewTextBoxColumn";
			this.reportNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// paymentDateDataGridViewTextBoxColumn
			// 
			this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
			this.paymentDateDataGridViewTextBoxColumn.HeaderText = "تاريخ السداد";
			this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
			this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
			this.paymentDateDataGridViewTextBoxColumn.Visible = false;
			// 
			// blockDateDataGridViewTextBoxColumn
			// 
			this.blockDateDataGridViewTextBoxColumn.DataPropertyName = "BlockDate";
			this.blockDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الاحجز الاداري";
			this.blockDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.blockDateDataGridViewTextBoxColumn.Name = "blockDateDataGridViewTextBoxColumn";
			this.blockDateDataGridViewTextBoxColumn.ReadOnly = true;
			this.blockDateDataGridViewTextBoxColumn.Visible = false;
			// 
			// truckDataGridViewTextBoxColumn
			// 
			this.truckDataGridViewTextBoxColumn.DataPropertyName = "Truck";
			this.truckDataGridViewTextBoxColumn.HeaderText = "Truck";
			this.truckDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.truckDataGridViewTextBoxColumn.Name = "truckDataGridViewTextBoxColumn";
			this.truckDataGridViewTextBoxColumn.ReadOnly = true;
			this.truckDataGridViewTextBoxColumn.Visible = false;
			// 
			// ManageDataView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.flowLayoutPanelOptions);
			this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ManageDataView";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(1062, 596);
			this.flowLayoutPanelOptions.ResumeLayout(false);
			this.flowLayoutPanelOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FlowLayoutPanel flowLayoutPanelOptions;
		private Button btnImportExcel;
		private Button btnExportExcel;
		private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn payloadDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn truckIdDataGridViewTextBoxColumn;
		private ViolationsCollecting.View.CustomeComponants.TruckCodeBodx truckCodeBodx1;
		private BindingSource violationBindingSource;
		private GroupBox groupBox1;
		private DataGridView dataGridView;
		private ViolationsCollecting.View.CustomeComponants.TruckCodeBodx truckCodeBodx2;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn truckCodeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn violationDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn elManfazDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn reportNumberDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn blockDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn truckDataGridViewTextBoxColumn;
	}
}
