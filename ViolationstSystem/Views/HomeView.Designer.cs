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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.flowLayoutPanelOptions = new System.Windows.Forms.FlowLayoutPanel();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnImportExcel = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtBlockDate = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPaymentDate = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtReportNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.CodeFiltercheckedList = new System.Windows.Forms.CheckedListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnApplyFilter = new System.Windows.Forms.Button();
			this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
			this.violationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.truckCodeBodx = new ViolationsCollecting.View.CustomeComponants.TruckCodeBodx();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.truckCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.violationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.elManfazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.blockDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanelOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanelOptions
			// 
			this.flowLayoutPanelOptions.AutoSize = true;
			this.flowLayoutPanelOptions.Controls.Add(this.truckCodeBodx);
			this.flowLayoutPanelOptions.Controls.Add(this.btnSearch);
			this.flowLayoutPanelOptions.Controls.Add(this.btnPrint);
			this.flowLayoutPanelOptions.Controls.Add(this.btnImportExcel);
			this.flowLayoutPanelOptions.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanelOptions.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanelOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.flowLayoutPanelOptions.Name = "flowLayoutPanelOptions";
			this.flowLayoutPanelOptions.Size = new System.Drawing.Size(1060, 80);
			this.flowLayoutPanelOptions.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.Image = global::ViolationstSystem.Properties.Resources.Search_1;
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.Location = new System.Drawing.Point(660, 20);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 20, 4, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnSearch.Size = new System.Drawing.Size(170, 50);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Text = "استعلام";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnPrint
			// 
			this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrint.Location = new System.Drawing.Point(482, 20);
			this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 20, 4, 5);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(170, 50);
			this.btnPrint.TabIndex = 2;
			this.btnPrint.Text = "طباعة الاستعلام";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnImportExcel
			// 
			this.btnImportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnImportExcel.Location = new System.Drawing.Point(304, 20);
			this.btnImportExcel.Margin = new System.Windows.Forms.Padding(4, 20, 4, 5);
			this.btnImportExcel.Name = "btnImportExcel";
			this.btnImportExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnImportExcel.Size = new System.Drawing.Size(170, 50);
			this.btnImportExcel.TabIndex = 6;
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
            this.reportNumberDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.blockDateDataGridViewTextBoxColumn});
			this.dataGridView.DataSource = this.violationBindingSource;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridView.GridColor = System.Drawing.SystemColors.Desktop;
			this.dataGridView.Location = new System.Drawing.Point(3, 41);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView.Name = "dataGridView";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView.RowHeadersWidth = 51;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(702, 679);
			this.dataGridView.TabIndex = 0;
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
			this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
			this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.splitContainer1.Size = new System.Drawing.Size(1060, 723);
			this.splitContainer1.SplitterDistance = 708;
			this.splitContainer1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(708, 723);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "قائمة المخالفات";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox4.Location = new System.Drawing.Point(0, 585);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox4.Size = new System.Drawing.Size(348, 138);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "دلالات الألوان والملاحظات";
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label5.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(342, 37);
			this.label5.TabIndex = 14;
			this.label5.Text = "حدد صف واحد أو صفوف متعددة لتطبيق عليها نفس الاجراءات(رقم بلاغ، تاريخ سداد، تاريخ" +
    " الحجز الاداري)";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label4.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(342, 32);
			this.label4.TabIndex = 13;
			this.label4.Text = "هذا اللون يدل على تكرار المخالفة بنفس التاريخ";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label6.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 103);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(342, 32);
			this.label6.TabIndex = 15;
			this.label6.Text = "هذا اللون يدل على أنه تم ارسال السياره للمرور";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnSave);
			this.groupBox2.Controls.Add(this.txtBlockDate);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtPaymentDate);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtReportNumber);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 197);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(348, 361);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "الإجراءات";
			// 
			// btnSave
			// 
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSave.Location = new System.Drawing.Point(3, 287);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(342, 53);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "تطبيق الاجراء";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// txtBlockDate
			// 
			this.txtBlockDate.Culture = new System.Globalization.CultureInfo("ar-EG");
			this.txtBlockDate.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtBlockDate.Location = new System.Drawing.Point(3, 242);
			this.txtBlockDate.Mask = "00 /00 /0000";
			this.txtBlockDate.Name = "txtBlockDate";
			this.txtBlockDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBlockDate.Size = new System.Drawing.Size(342, 45);
			this.txtBlockDate.TabIndex = 12;
			this.txtBlockDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBlockDate.ValidatingType = typeof(System.DateTime);
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(3, 205);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(342, 37);
			this.label3.TabIndex = 10;
			this.label3.Text = "تاريخ الحجز الإداري";
			// 
			// txtPaymentDate
			// 
			this.txtPaymentDate.Culture = new System.Globalization.CultureInfo("ar-EG");
			this.txtPaymentDate.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtPaymentDate.Location = new System.Drawing.Point(3, 160);
			this.txtPaymentDate.Mask = "00 /00 /0000";
			this.txtPaymentDate.Name = "txtPaymentDate";
			this.txtPaymentDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPaymentDate.Size = new System.Drawing.Size(342, 45);
			this.txtPaymentDate.TabIndex = 11;
			this.txtPaymentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPaymentDate.ValidatingType = typeof(System.DateTime);
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(3, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(342, 37);
			this.label2.TabIndex = 8;
			this.label2.Text = "تاريخ السداد";
			// 
			// txtReportNumber
			// 
			this.txtReportNumber.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtReportNumber.Location = new System.Drawing.Point(3, 78);
			this.txtReportNumber.Name = "txtReportNumber";
			this.txtReportNumber.Size = new System.Drawing.Size(342, 45);
			this.txtReportNumber.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(3, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(342, 37);
			this.label1.TabIndex = 7;
			this.label1.Text = "رقم البلاغ";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.CodeFiltercheckedList);
			this.groupBox3.Controls.Add(this.panel2);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox3.Size = new System.Drawing.Size(348, 197);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "filter";
			// 
			// CodeFiltercheckedList
			// 
			this.CodeFiltercheckedList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CodeFiltercheckedList.FormattingEnabled = true;
			this.CodeFiltercheckedList.Location = new System.Drawing.Point(3, 82);
			this.CodeFiltercheckedList.Name = "CodeFiltercheckedList";
			this.CodeFiltercheckedList.Size = new System.Drawing.Size(342, 112);
			this.CodeFiltercheckedList.TabIndex = 8;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnApplyFilter);
			this.panel2.Controls.Add(this.checkBoxSelectAll);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 41);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(342, 41);
			this.panel2.TabIndex = 10;
			// 
			// btnApplyFilter
			// 
			this.btnApplyFilter.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnApplyFilter.Location = new System.Drawing.Point(0, 0);
			this.btnApplyFilter.Name = "btnApplyFilter";
			this.btnApplyFilter.Size = new System.Drawing.Size(122, 41);
			this.btnApplyFilter.TabIndex = 10;
			this.btnApplyFilter.Text = "تطبيق";
			this.btnApplyFilter.UseVisualStyleBackColor = true;
			this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
			// 
			// checkBoxSelectAll
			// 
			this.checkBoxSelectAll.AutoSize = true;
			this.checkBoxSelectAll.Checked = true;
			this.checkBoxSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSelectAll.Dock = System.Windows.Forms.DockStyle.Right;
			this.checkBoxSelectAll.Location = new System.Drawing.Point(217, 0);
			this.checkBoxSelectAll.Name = "checkBoxSelectAll";
			this.checkBoxSelectAll.Size = new System.Drawing.Size(125, 41);
			this.checkBoxSelectAll.TabIndex = 9;
			this.checkBoxSelectAll.Text = "تحديد الكل";
			this.checkBoxSelectAll.UseVisualStyleBackColor = true;
			this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
			// 
			// violationBindingSource
			// 
			this.violationBindingSource.DataSource = typeof(ViolationSystem.Data.Entities.Violation);
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
			this.truckCodeBodx.TabIndex = 5;
			this.truckCodeBodx.txtCodeChars = "";
			this.truckCodeBodx.txtCodeDigits = "";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
			dataGridViewCellStyle3.Format = "yyyy/MM/dd";
			this.violationDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.violationDateDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.violationDateDataGridViewTextBoxColumn.HeaderText = "تاريخ المخالفة";
			this.violationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.violationDateDataGridViewTextBoxColumn.Name = "violationDateDataGridViewTextBoxColumn";
			// 
			// unitDataGridViewTextBoxColumn
			// 
			this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
			this.unitDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.unitDataGridViewTextBoxColumn.HeaderText = "الوحدة";
			this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
			// 
			// elManfazDataGridViewTextBoxColumn
			// 
			this.elManfazDataGridViewTextBoxColumn.DataPropertyName = "ElManfaz";
			this.elManfazDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.elManfazDataGridViewTextBoxColumn.HeaderText = "المنفذ";
			this.elManfazDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.elManfazDataGridViewTextBoxColumn.Name = "elManfazDataGridViewTextBoxColumn";
			// 
			// reportNumberDataGridViewTextBoxColumn
			// 
			this.reportNumberDataGridViewTextBoxColumn.DataPropertyName = "ReportNumber";
			this.reportNumberDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.reportNumberDataGridViewTextBoxColumn.HeaderText = "رقم البلاغ";
			this.reportNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.reportNumberDataGridViewTextBoxColumn.Name = "reportNumberDataGridViewTextBoxColumn";
			// 
			// paymentDateDataGridViewTextBoxColumn
			// 
			this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
			this.paymentDateDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.paymentDateDataGridViewTextBoxColumn.HeaderText = "تاريخ السداد";
			this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
			// 
			// blockDateDataGridViewTextBoxColumn
			// 
			this.blockDateDataGridViewTextBoxColumn.DataPropertyName = "BlockDate";
			this.blockDateDataGridViewTextBoxColumn.FillWeight = 108.1742F;
			this.blockDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الحجز";
			this.blockDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.blockDateDataGridViewTextBoxColumn.Name = "blockDateDataGridViewTextBoxColumn";
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
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FlowLayoutPanel flowLayoutPanelOptions;
		private Button btnSearch;
		private Button btnPrint;
        private DataGridView dataGridView;
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
		private GroupBox groupBox3;
		private CheckBox checkBoxSelectAll;
		private CheckedListBox CodeFiltercheckedList;
		private Panel panel2;
		private Button btnApplyFilter;
		private MaskedTextBox txtBlockDate;
		private Label label3;
		private MaskedTextBox txtPaymentDate;
		private Label label2;
		private TextBox txtReportNumber;
		private Label label1;
		private Button btnSave;
		private GroupBox groupBox4;
		private Label label5;
		private Label label4;
		private Label label6;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn NumSeq;
		private DataGridViewTextBoxColumn truckCodeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn violationDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn elManfazDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn reportNumberDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn blockDateDataGridViewTextBoxColumn;
	}
}
