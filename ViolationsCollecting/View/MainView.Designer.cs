using ViolationsCollecting.View.CustomeComponants;

namespace ViolationsCollecting.View
{
	partial class MainView
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.labelHeader = new System.Windows.Forms.Label();
			this.EditTimer = new System.Windows.Forms.Timer(this.components);
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.DateGroupBox = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.yearNum = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.NumMonth = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.panel2 = new System.Windows.Forms.Panel();
			this.MakerGroupBox = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.UnitGroupBox = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.TruckCodeGroupBox = new System.Windows.Forms.GroupBox();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnEditMode = new System.Windows.Forms.Button();
			this.btnAddMode = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtPyload = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtWeight = new System.Windows.Forms.TextBox();
			this.ReportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.truckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.truckCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.violationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.responsibleUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.elManfathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.payloadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.truckIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.blockDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.violationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.panel1.SuspendLayout();
			this.DateGroupBox.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.yearNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumMonth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.panel2.SuspendLayout();
			this.MakerGroupBox.SuspendLayout();
			this.UnitGroupBox.SuspendLayout();
			this.TruckCodeGroupBox.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panelHeader
			// 
			this.panelHeader.Controls.Add(this.labelHeader);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1062, 64);
			this.panelHeader.TabIndex = 1;
			// 
			// labelHeader
			// 
			this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelHeader.Font = new System.Drawing.Font("Cairo", 22F);
			this.labelHeader.Location = new System.Drawing.Point(0, 0);
			this.labelHeader.Name = "labelHeader";
			this.labelHeader.Size = new System.Drawing.Size(1062, 64);
			this.labelHeader.TabIndex = 0;
			this.labelHeader.Text = "مخالفات السيارات الهاربة من منافذ التحصيل";
			this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 64);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.panel1);
			this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.groupBox3);
			this.splitContainer.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.splitContainer.Size = new System.Drawing.Size(1062, 609);
			this.splitContainer.SplitterDistance = 515;
			this.splitContainer.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.DateGroupBox);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.TruckCodeGroupBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(515, 609);
			this.panel1.TabIndex = 5;
			// 
			// btnSave
			// 
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSave.Font = new System.Drawing.Font("Cairo", 16F);
			this.btnSave.Image = global::ViolationsCollecting.Properties.Resources.diskette;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(0, 531);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(515, 68);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "حفظ";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// DateGroupBox
			// 
			this.DateGroupBox.Controls.Add(this.flowLayoutPanel1);
			this.DateGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.DateGroupBox.Location = new System.Drawing.Point(0, 423);
			this.DateGroupBox.Name = "DateGroupBox";
			this.DateGroupBox.Size = new System.Drawing.Size(515, 108);
			this.DateGroupBox.TabIndex = 4;
			this.DateGroupBox.TabStop = false;
			this.DateGroupBox.Text = "التاريخ";
			this.DateGroupBox.Enter += new System.EventHandler(this.DateGroupBox_Enter);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.yearNum);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.NumMonth);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown3);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(58, 41);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(454, 64);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cairo", 15F);
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "20";
			// 
			// yearNum
			// 
			this.yearNum.Location = new System.Drawing.Point(57, 3);
			this.yearNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.yearNum.Name = "yearNum";
			this.yearNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.yearNum.Size = new System.Drawing.Size(74, 45);
			this.yearNum.TabIndex = 2;
			this.yearNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.yearNum.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cairo", 16F);
			this.label2.Location = new System.Drawing.Point(137, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 50);
			this.label2.TabIndex = 2;
			this.label2.Text = "/";
			// 
			// NumMonth
			// 
			this.NumMonth.Location = new System.Drawing.Point(176, 3);
			this.NumMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.NumMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumMonth.Name = "NumMonth";
			this.NumMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NumMonth.Size = new System.Drawing.Size(74, 45);
			this.NumMonth.TabIndex = 1;
			this.NumMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.NumMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cairo", 16F);
			this.label3.Location = new System.Drawing.Point(256, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 50);
			this.label3.TabIndex = 3;
			this.label3.Text = "/";
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(295, 3);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
			this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.numericUpDown3.Size = new System.Drawing.Size(74, 45);
			this.numericUpDown3.TabIndex = 0;
			this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.MakerGroupBox);
			this.panel2.Controls.Add(this.UnitGroupBox);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 159);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(515, 132);
			this.panel2.TabIndex = 2;
			// 
			// MakerGroupBox
			// 
			this.MakerGroupBox.Controls.Add(this.textBox1);
			this.MakerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MakerGroupBox.Location = new System.Drawing.Point(0, 0);
			this.MakerGroupBox.Name = "MakerGroupBox";
			this.MakerGroupBox.Size = new System.Drawing.Size(270, 132);
			this.MakerGroupBox.TabIndex = 1;
			this.MakerGroupBox.TabStop = false;
			this.MakerGroupBox.Text = "المنفذ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(102, 51);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 45);
			this.textBox1.TabIndex = 3;
			// 
			// UnitGroupBox
			// 
			this.UnitGroupBox.Controls.Add(this.comboBox1);
			this.UnitGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.UnitGroupBox.Location = new System.Drawing.Point(270, 0);
			this.UnitGroupBox.Name = "UnitGroupBox";
			this.UnitGroupBox.Size = new System.Drawing.Size(245, 132);
			this.UnitGroupBox.TabIndex = 0;
			this.UnitGroupBox.TabStop = false;
			this.UnitGroupBox.Text = "الوحدة";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
			"كرداسة",
			"البدرشين",
			"الصف",
			"العياط"});
			this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "كرداسة",
            "البدرشين",
            "الصف",
            "العياط"});
			this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.comboBox1.Location = new System.Drawing.Point(54, 44);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 45);
			this.comboBox1.TabIndex = 2;
			// 
			// TruckCodeGroupBox
			// 
			this.TruckCodeGroupBox.Controls.Add(this.txtCode);
			this.TruckCodeGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.TruckCodeGroupBox.Location = new System.Drawing.Point(0, 0);
			this.TruckCodeGroupBox.Name = "TruckCodeGroupBox";
			this.TruckCodeGroupBox.Size = new System.Drawing.Size(515, 159);
			this.TruckCodeGroupBox.TabIndex = 0;
			this.TruckCodeGroupBox.TabStop = false;
			this.TruckCodeGroupBox.Text = "رقم السيارة";
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(117, 56);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(334, 45);
			this.txtCode.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 210);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox3.Size = new System.Drawing.Size(543, 399);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "اختر الصف للتعديل";
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.truckDataGridViewTextBoxColumn,
            this.truckCodeDataGridViewTextBoxColumn,
            this.violationDateDataGridViewTextBoxColumn,
            this.responsibleUnitDataGridViewTextBoxColumn,
            this.elManfathDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.payloadDataGridViewTextBoxColumn,
            this.truckIdDataGridViewTextBoxColumn,
            this.ReportNumber,
            this.paymentDateDataGridViewTextBoxColumn,
            this.blockDateDataGridViewTextBoxColumn});
			this.dataGridView.DataSource = this.violationBindingSource;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(5, 43);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(533, 351);
			this.dataGridView.TabIndex = 12;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtSearch);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 116);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox2.Size = new System.Drawing.Size(543, 94);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "بحث برقم السيارة";
			// 
			// txtSearch
			// 
			this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSearch.Location = new System.Drawing.Point(5, 43);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(533, 45);
			this.txtSearch.TabIndex = 11;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnEditMode);
			this.groupBox1.Controls.Add(this.btnAddMode);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(7);
			this.groupBox1.Size = new System.Drawing.Size(543, 116);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "الوضع";
			// 
			// btnEditMode
			// 
			this.btnEditMode.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnEditMode.Image = global::ViolationsCollecting.Properties.Resources.pencil;
			this.btnEditMode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditMode.Location = new System.Drawing.Point(7, 45);
			this.btnEditMode.Name = "btnEditMode";
			this.btnEditMode.Padding = new System.Windows.Forms.Padding(5);
			this.btnEditMode.Size = new System.Drawing.Size(200, 64);
			this.btnEditMode.TabIndex = 10;
			this.btnEditMode.Text = "وضع التعديل";
			this.btnEditMode.UseVisualStyleBackColor = true;
			// 
			// btnAddMode
			// 
			this.btnAddMode.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnAddMode.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAddMode.Image = global::ViolationsCollecting.Properties.Resources.add_button;
			this.btnAddMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddMode.Location = new System.Drawing.Point(336, 45);
			this.btnAddMode.Name = "btnAddMode";
			this.btnAddMode.Padding = new System.Windows.Forms.Padding(5);
			this.btnAddMode.Size = new System.Drawing.Size(200, 64);
			this.btnAddMode.TabIndex = 9;
			this.btnAddMode.Text = "وضع الإضافة";
			this.btnAddMode.UseVisualStyleBackColor = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.groupBox4);
			this.panel3.Controls.Add(this.groupBox5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 291);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(515, 132);
			this.panel3.TabIndex = 3;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtPyload);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(270, 132);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "الحمولة";
			// 
			// txtPyload
			// 
			this.txtPyload.Location = new System.Drawing.Point(102, 51);
			this.txtPyload.Name = "txtPyload";
			this.txtPyload.Size = new System.Drawing.Size(100, 45);
			this.txtPyload.TabIndex = 3;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txtWeight);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox5.Location = new System.Drawing.Point(270, 0);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(245, 132);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "الوزن";
			// 
			// txtWeight
			// 
			this.txtWeight.Location = new System.Drawing.Point(42, 44);
			this.txtWeight.Name = "txtWeight";
			this.txtWeight.Size = new System.Drawing.Size(100, 45);
			this.txtWeight.TabIndex = 4;
			// 
			// ReportNumber
			// 
			this.ReportNumber.DataPropertyName = "ReportNumber";
			this.ReportNumber.HeaderText = "ReportNumber";
			this.ReportNumber.MinimumWidth = 6;
			this.ReportNumber.Name = "ReportNumber";
			this.ReportNumber.ReadOnly = true;
			this.ReportNumber.Visible = false;
			this.ReportNumber.Width = 125;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			this.idDataGridViewTextBoxColumn.Width = 125;
			// 
			// truckDataGridViewTextBoxColumn
			// 
			this.truckDataGridViewTextBoxColumn.DataPropertyName = "Truck";
			this.truckDataGridViewTextBoxColumn.HeaderText = "Truck";
			this.truckDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.truckDataGridViewTextBoxColumn.Name = "truckDataGridViewTextBoxColumn";
			this.truckDataGridViewTextBoxColumn.ReadOnly = true;
			this.truckDataGridViewTextBoxColumn.Visible = false;
			this.truckDataGridViewTextBoxColumn.Width = 125;
			// 
			// truckCodeDataGridViewTextBoxColumn
			// 
			this.truckCodeDataGridViewTextBoxColumn.DataPropertyName = "TruckCode";
			this.truckCodeDataGridViewTextBoxColumn.HeaderText = "رقم الشاحنة";
			this.truckCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.truckCodeDataGridViewTextBoxColumn.Name = "truckCodeDataGridViewTextBoxColumn";
			this.truckCodeDataGridViewTextBoxColumn.ReadOnly = true;
			this.truckCodeDataGridViewTextBoxColumn.Width = 125;
			// 
			// violationDateDataGridViewTextBoxColumn
			// 
			this.violationDateDataGridViewTextBoxColumn.DataPropertyName = "ViolationDate";
			this.violationDateDataGridViewTextBoxColumn.HeaderText = "تاريخ المخالفة";
			this.violationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.violationDateDataGridViewTextBoxColumn.Name = "violationDateDataGridViewTextBoxColumn";
			this.violationDateDataGridViewTextBoxColumn.ReadOnly = true;
			this.violationDateDataGridViewTextBoxColumn.Width = 125;
			// 
			// responsibleUnitDataGridViewTextBoxColumn
			// 
			this.responsibleUnitDataGridViewTextBoxColumn.DataPropertyName = "ResponsibleUnit";
			this.responsibleUnitDataGridViewTextBoxColumn.HeaderText = "الوحدة";
			this.responsibleUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.responsibleUnitDataGridViewTextBoxColumn.Name = "responsibleUnitDataGridViewTextBoxColumn";
			this.responsibleUnitDataGridViewTextBoxColumn.ReadOnly = true;
			this.responsibleUnitDataGridViewTextBoxColumn.Width = 125;
			// 
			// elManfathDataGridViewTextBoxColumn
			// 
			this.elManfathDataGridViewTextBoxColumn.DataPropertyName = "elManfath";
			this.elManfathDataGridViewTextBoxColumn.HeaderText = "المنفذ";
			this.elManfathDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.elManfathDataGridViewTextBoxColumn.Name = "elManfathDataGridViewTextBoxColumn";
			this.elManfathDataGridViewTextBoxColumn.ReadOnly = true;
			this.elManfathDataGridViewTextBoxColumn.Width = 125;
			// 
			// weightDataGridViewTextBoxColumn
			// 
			this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			this.weightDataGridViewTextBoxColumn.HeaderText = "الوزن";
			this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			this.weightDataGridViewTextBoxColumn.ReadOnly = true;
			this.weightDataGridViewTextBoxColumn.Width = 125;
			// 
			// payloadDataGridViewTextBoxColumn
			// 
			this.payloadDataGridViewTextBoxColumn.DataPropertyName = "Payload";
			this.payloadDataGridViewTextBoxColumn.HeaderText = "الحمولة";
			this.payloadDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.payloadDataGridViewTextBoxColumn.Name = "payloadDataGridViewTextBoxColumn";
			this.payloadDataGridViewTextBoxColumn.ReadOnly = true;
			this.payloadDataGridViewTextBoxColumn.Width = 125;
			// 
			// truckIdDataGridViewTextBoxColumn
			// 
			this.truckIdDataGridViewTextBoxColumn.DataPropertyName = "TruckId";
			this.truckIdDataGridViewTextBoxColumn.HeaderText = "TruckId";
			this.truckIdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.truckIdDataGridViewTextBoxColumn.Name = "truckIdDataGridViewTextBoxColumn";
			this.truckIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.truckIdDataGridViewTextBoxColumn.Visible = false;
			this.truckIdDataGridViewTextBoxColumn.Width = 125;
			// 
			// paymentDateDataGridViewTextBoxColumn
			// 
			this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
			this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
			this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
			this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
			this.paymentDateDataGridViewTextBoxColumn.Visible = false;
			this.paymentDateDataGridViewTextBoxColumn.Width = 125;
			// 
			// blockDateDataGridViewTextBoxColumn
			// 
			this.blockDateDataGridViewTextBoxColumn.DataPropertyName = "BlockDate";
			this.blockDateDataGridViewTextBoxColumn.HeaderText = "BlockDate";
			this.blockDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.blockDateDataGridViewTextBoxColumn.Name = "blockDateDataGridViewTextBoxColumn";
			this.blockDateDataGridViewTextBoxColumn.ReadOnly = true;
			this.blockDateDataGridViewTextBoxColumn.Visible = false;
			this.blockDateDataGridViewTextBoxColumn.Width = 125;
			// 
			// violationBindingSource
			// 
			this.violationBindingSource.DataSource = typeof(ViolationsCollecting.Model.Entities.Violation);
			// 
			// MainView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1062, 673);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.panelHeader);
			this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(1080, 720);
			this.Name = "MainView";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "برنامج تسجيل المخالفات";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panelHeader.ResumeLayout(false);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.DateGroupBox.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.yearNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumMonth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.panel2.ResumeLayout(false);
			this.MakerGroupBox.ResumeLayout(false);
			this.MakerGroupBox.PerformLayout();
			this.UnitGroupBox.ResumeLayout(false);
			this.TruckCodeGroupBox.ResumeLayout(false);
			this.TruckCodeGroupBox.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label labelHeader;
		private System.Windows.Forms.Timer EditTimer;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.GroupBox TruckCodeGroupBox;
		private System.Windows.Forms.GroupBox UnitGroupBox;
		private System.Windows.Forms.GroupBox MakerGroupBox;
		private System.Windows.Forms.GroupBox DateGroupBox;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnEditMode;
		private System.Windows.Forms.Button btnAddMode;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.NumericUpDown yearNum;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.NumericUpDown NumMonth;
		private System.Windows.Forms.BindingSource violationBindingSource;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtPyload;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox txtWeight;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn truckDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn truckCodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn violationDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn responsibleUnitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn elManfathDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn payloadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn truckIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ReportNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn blockDateDataGridViewTextBoxColumn;
	}
}