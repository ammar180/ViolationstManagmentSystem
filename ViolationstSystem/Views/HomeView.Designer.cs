using System;
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.flowLayoutPanelOptions = new System.Windows.Forms.FlowLayoutPanel();
			this.truckCodeBodx = new ViolationsCollecting.View.CustomeComponants.TruckCodeBodx();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnSaveChages = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnImportExcel = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.violationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnApplyChanges = new System.Windows.Forms.Button();
			this.txtBlockDate = new ViolationsCollecting.View.CustomeComponants.DateBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPaymentDate = new ViolationsCollecting.View.CustomeComponants.DateBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtReportNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.filterUserControle1 = new ViolationstSystem.Views.CustomeComponants.FilterUserControle();
			this.btnShowFilter = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.truckCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.violationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.elManfazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.blockDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanelOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanelOptions
			// 
			this.flowLayoutPanelOptions.AutoSize = true;
			this.flowLayoutPanelOptions.Controls.Add(this.truckCodeBodx);
			this.flowLayoutPanelOptions.Controls.Add(this.btnSearch);
			this.flowLayoutPanelOptions.Controls.Add(this.btnSaveChages);
			this.flowLayoutPanelOptions.Controls.Add(this.btnPrint);
			this.flowLayoutPanelOptions.Controls.Add(this.btnImportExcel);
			this.flowLayoutPanelOptions.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanelOptions.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanelOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.flowLayoutPanelOptions.Name = "flowLayoutPanelOptions";
			this.flowLayoutPanelOptions.Size = new System.Drawing.Size(1060, 80);
			this.flowLayoutPanelOptions.TabIndex = 0;
			// 
			// truckCodeBodx
			// 
			this.truckCodeBodx.FirstNumberTextBox = null;
			this.truckCodeBodx.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.truckCodeBodx.Location = new System.Drawing.Point(834, 0);
			this.truckCodeBodx.Margin = new System.Windows.Forms.Padding(0);
			this.truckCodeBodx.Name = "truckCodeBodx";
			this.truckCodeBodx.Padding = new System.Windows.Forms.Padding(5);
			this.truckCodeBodx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.truckCodeBodx.Size = new System.Drawing.Size(226, 80);
			this.truckCodeBodx.TabIndex = 0;
			this.truckCodeBodx.txtCodeChars = "";
			this.truckCodeBodx.txtCodeDigits = "";
			// 
			// btnSearch
			// 
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.Image = global::ViolationstSystem.Properties.Resources.Search_1;
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearch.Location = new System.Drawing.Point(660, 20);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 20, 4, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnSearch.Size = new System.Drawing.Size(170, 50);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "استعلام";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnSaveChages
			// 
			this.btnSaveChages.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveChages.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveChages.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSaveChages.Location = new System.Drawing.Point(458, 20);
			this.btnSaveChages.Margin = new System.Windows.Forms.Padding(4, 20, 4, 5);
			this.btnSaveChages.Name = "btnSaveChages";
			this.btnSaveChages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnSaveChages.Size = new System.Drawing.Size(194, 50);
			this.btnSaveChages.TabIndex = 2;
			this.btnSaveChages.Text = "حفظ التغيرات";
			this.btnSaveChages.UseVisualStyleBackColor = true;
			this.btnSaveChages.Click += new System.EventHandler(this.btnSaveChages_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrint.Enabled = false;
			this.btnPrint.Location = new System.Drawing.Point(280, 20);
			this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 20, 4, 5);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(170, 50);
			this.btnPrint.TabIndex = 3;
			this.btnPrint.Text = "طباعة الاستعلام";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnImportExcel
			// 
			this.btnImportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnImportExcel.Location = new System.Drawing.Point(102, 20);
			this.btnImportExcel.Margin = new System.Windows.Forms.Padding(4, 20, 4, 5);
			this.btnImportExcel.Name = "btnImportExcel";
			this.btnImportExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnImportExcel.Size = new System.Drawing.Size(170, 50);
			this.btnImportExcel.TabIndex = 4;
			this.btnImportExcel.Text = "ادراج بيانات";
			this.btnImportExcel.UseVisualStyleBackColor = true;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
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
            this.NumSeq,
            this.truckCodeDataGridViewTextBoxColumn,
            this.violationDateDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.elManfazDataGridViewTextBoxColumn,
            this.VCount,
            this.reportNumberDataGridViewTextBoxColumn,
            this.blockDateDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.Comments});
			this.dataGridView.DataSource = this.violationBindingSource;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
			this.dataGridView.GridColor = System.Drawing.SystemColors.Desktop;
			this.dataGridView.Location = new System.Drawing.Point(3, 41);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView.Name = "dataGridView";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView.RowHeadersWidth = 51;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(693, 679);
			this.dataGridView.TabIndex = 0;
			// 
			// violationBindingSource
			// 
			this.violationBindingSource.DataSource = typeof(ViolationSystem.Data.Entities.Violation);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 80);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Panel2.Controls.Add(this.filterUserControle1);
			this.splitContainer1.Panel2.Controls.Add(this.btnShowFilter);
			this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.splitContainer1.Size = new System.Drawing.Size(1060, 723);
			this.splitContainer1.SplitterDistance = 699;
			this.splitContainer1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(699, 723);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "قائمة المخالفات";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnApplyChanges);
			this.groupBox2.Controls.Add(this.txtBlockDate);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtPaymentDate);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtReportNumber);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 251);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(357, 402);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "الإجراءات";
			// 
			// btnApplyChanges
			// 
			this.btnApplyChanges.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnApplyChanges.Location = new System.Drawing.Point(3, 358);
			this.btnApplyChanges.Name = "btnApplyChanges";
			this.btnApplyChanges.Size = new System.Drawing.Size(351, 50);
			this.btnApplyChanges.TabIndex = 5;
			this.btnApplyChanges.Text = "تطبيق الاجراء";
			this.btnApplyChanges.UseVisualStyleBackColor = true;
			// 
			// txtBlockDate
			// 
			this.txtBlockDate.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtBlockDate.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBlockDate.Location = new System.Drawing.Point(3, 278);
			this.txtBlockDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtBlockDate.Name = "txtBlockDate";
			this.txtBlockDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtBlockDate.Size = new System.Drawing.Size(351, 80);
			this.txtBlockDate.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(3, 241);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(351, 37);
			this.label3.TabIndex = 10;
			this.label3.Text = "تاريخ الحجز الإداري";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtPaymentDate
			// 
			this.txtPaymentDate.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtPaymentDate.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPaymentDate.Location = new System.Drawing.Point(3, 160);
			this.txtPaymentDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtPaymentDate.Name = "txtPaymentDate";
			this.txtPaymentDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtPaymentDate.Size = new System.Drawing.Size(351, 81);
			this.txtPaymentDate.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(3, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(351, 37);
			this.label2.TabIndex = 8;
			this.label2.Text = "تاريخ السداد";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtReportNumber
			// 
			this.txtReportNumber.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtReportNumber.Location = new System.Drawing.Point(3, 78);
			this.txtReportNumber.Name = "txtReportNumber";
			this.txtReportNumber.Size = new System.Drawing.Size(351, 45);
			this.txtReportNumber.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(3, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(351, 37);
			this.label1.TabIndex = 7;
			this.label1.Text = "رقم البلاغ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// filterUserControle1
			// 
			this.filterUserControle1.Dock = System.Windows.Forms.DockStyle.Top;
			this.filterUserControle1.FilterList = ((System.Collections.Generic.List<string>)(resources.GetObject("filterUserControle1.FilterList")));
			this.filterUserControle1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filterUserControle1.Location = new System.Drawing.Point(0, 42);
			this.filterUserControle1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.filterUserControle1.Name = "filterUserControle1";
			this.filterUserControle1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.filterUserControle1.Size = new System.Drawing.Size(357, 209);
			this.filterUserControle1.TabIndex = 12;
			this.filterUserControle1.Visible = false;
			// 
			// btnShowFilter
			// 
			this.btnShowFilter.BackColor = System.Drawing.Color.Transparent;
			this.btnShowFilter.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnShowFilter.Location = new System.Drawing.Point(0, 0);
			this.btnShowFilter.Name = "btnShowFilter";
			this.btnShowFilter.Size = new System.Drawing.Size(357, 42);
			this.btnShowFilter.TabIndex = 1;
			this.btnShowFilter.Text = "الفلاتر 🔽";
			this.btnShowFilter.UseVisualStyleBackColor = false;
			this.btnShowFilter.Click += new System.EventHandler(this.btnShowFilter_Click);
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
			// NumSeq
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.NumSeq.DefaultCellStyle = dataGridViewCellStyle2;
			this.NumSeq.FillWeight = 42.78075F;
			this.NumSeq.HeaderText = "م";
			this.NumSeq.MinimumWidth = 6;
			this.NumSeq.Name = "NumSeq";
			this.NumSeq.ReadOnly = true;
			// 
			// truckCodeDataGridViewTextBoxColumn
			// 
			this.truckCodeDataGridViewTextBoxColumn.DataPropertyName = "TruckCode";
			this.truckCodeDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.truckCodeDataGridViewTextBoxColumn.HeaderText = "رقم الشاحنة";
			this.truckCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.truckCodeDataGridViewTextBoxColumn.Name = "truckCodeDataGridViewTextBoxColumn";
			// 
			// violationDateDataGridViewTextBoxColumn
			// 
			this.violationDateDataGridViewTextBoxColumn.DataPropertyName = "ViolationDate";
			dataGridViewCellStyle3.Format = "d/M/yyyy";
			dataGridViewCellStyle3.NullValue = null;
			this.violationDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.violationDateDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.violationDateDataGridViewTextBoxColumn.HeaderText = "تاريخ المخالفة";
			this.violationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.violationDateDataGridViewTextBoxColumn.Name = "violationDateDataGridViewTextBoxColumn";
			this.violationDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// unitDataGridViewTextBoxColumn
			// 
			this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
			this.unitDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.unitDataGridViewTextBoxColumn.HeaderText = "الوحدة";
			this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
			this.unitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// elManfazDataGridViewTextBoxColumn
			// 
			this.elManfazDataGridViewTextBoxColumn.DataPropertyName = "ElManfaz";
			this.elManfazDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.elManfazDataGridViewTextBoxColumn.HeaderText = "المنفذ";
			this.elManfazDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.elManfazDataGridViewTextBoxColumn.Name = "elManfazDataGridViewTextBoxColumn";
			this.elManfazDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// VCount
			// 
			this.VCount.DataPropertyName = "VCount";
			this.VCount.HeaderText = "عدد النقلات";
			this.VCount.MinimumWidth = 6;
			this.VCount.Name = "VCount";
			this.VCount.ReadOnly = true;
			// 
			// reportNumberDataGridViewTextBoxColumn
			// 
			this.reportNumberDataGridViewTextBoxColumn.DataPropertyName = "ReportNumber";
			this.reportNumberDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.reportNumberDataGridViewTextBoxColumn.HeaderText = "رقم البلاغ";
			this.reportNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.reportNumberDataGridViewTextBoxColumn.Name = "reportNumberDataGridViewTextBoxColumn";
			this.reportNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// blockDateDataGridViewTextBoxColumn
			// 
			this.blockDateDataGridViewTextBoxColumn.DataPropertyName = "BlockDate";
			dataGridViewCellStyle4.Format = "dd/MM/yyyy";
			this.blockDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
			this.blockDateDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.blockDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الحجز";
			this.blockDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.blockDateDataGridViewTextBoxColumn.Name = "blockDateDataGridViewTextBoxColumn";
			this.blockDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// paymentDateDataGridViewTextBoxColumn
			// 
			this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
			dataGridViewCellStyle5.Format = "dd/MM/yyyy";
			this.paymentDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
			this.paymentDateDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.paymentDateDataGridViewTextBoxColumn.HeaderText = "تاريخ السداد";
			this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
			this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Comments
			// 
			this.Comments.DataPropertyName = "Comments";
			this.Comments.HeaderText = "الملاحظات";
			this.Comments.MinimumWidth = 6;
			this.Comments.Name = "Comments";
			// 
			// HomeView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.flowLayoutPanelOptions);
			this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "HomeView";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(1060, 803);
			this.flowLayoutPanelOptions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FlowLayoutPanel flowLayoutPanelOptions;
		private Button btnSearch;
		private Button btnPrint;
		private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn payloadDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn truckIdDataGridViewTextBoxColumn;
		private ViolationsCollecting.View.CustomeComponants.TruckCodeBodx truckCodeBodx;
		private SplitContainer splitContainer1;
		private GroupBox groupBox1;
		private BindingSource violationBindingSource;
		private GroupBox groupBox2;
		private Button btnImportExcel;
		private DataGridViewTextBoxColumn truckDataGridViewTextBoxColumn;
		private Label label3;
		private Label label2;
		private TextBox txtReportNumber;
		private Label label1;
		private Button btnApplyChanges;
		private Button btnSaveChages;
		private ViolationstSystem.Views.CustomeComponants.FilterUserControle filterUserControle1;
		private ViolationsCollecting.View.CustomeComponants.DateBox txtPaymentDate;
		private ViolationsCollecting.View.CustomeComponants.DateBox txtBlockDate;
		private Button btnShowFilter;
		public DataGridView dataGridView;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn NumSeq;
		private DataGridViewTextBoxColumn truckCodeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn violationDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn elManfazDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn VCount;
		private DataGridViewTextBoxColumn reportNumberDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn blockDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn Comments;
	}
}
