using System;
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
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
			panelHeader = new Panel();
			labelHeader = new Label();
			groupBox6 = new GroupBox();
			NumMonthToExport = new NumericUpDown();
			btnExport = new Button();
			pictureBox1 = new PictureBox();
			EditTimer = new System.Windows.Forms.Timer(components);
			splitContainer = new SplitContainer();
			panel1 = new Panel();
			labelMessage = new Label();
			btnSave = new Button();
			panelWP = new Panel();
			panel3 = new Panel();
			groupBox4 = new GroupBox();
			txtPyload = new TextBox();
			groupBox5 = new GroupBox();
			txtWeight = new TextBox();
			DateGroupBox = new GroupBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			label1 = new Label();
			YearNum = new NumericUpDown();
			label2 = new Label();
			MonthNum = new NumericUpDown();
			label3 = new Label();
			DayNum = new NumericUpDown();
			panel2 = new Panel();
			panel4 = new Panel();
			MakerGroupBox = new GroupBox();
			txtElManfaz = new TextBox();
			UnitGroupBox = new GroupBox();
			comboUnit = new ComboBox();
			TruckCodeGroupBox = new GroupBox();
			truckCodeBodx1 = new TruckCodeBodx();
			groupBox3 = new GroupBox();
			dataGridView = new DataGridView();
			idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			truckCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			violationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			elManfazDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			registrationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			payloadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			violationBindingSource = new BindingSource(components);
			groupBox1 = new GroupBox();
			btnEditMode = new Button();
			btnAddMode = new Button();
			groupBox7 = new GroupBox();
			truckCodeBoxSearch = new TruckCodeBodx();
			panelHeader.SuspendLayout();
			groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)NumMonthToExport).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
			splitContainer.Panel1.SuspendLayout();
			splitContainer.Panel2.SuspendLayout();
			splitContainer.SuspendLayout();
			panel1.SuspendLayout();
			panelWP.SuspendLayout();
			panel3.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox5.SuspendLayout();
			DateGroupBox.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)YearNum).BeginInit();
			((System.ComponentModel.ISupportInitialize)MonthNum).BeginInit();
			((System.ComponentModel.ISupportInitialize)DayNum).BeginInit();
			panel2.SuspendLayout();
			panel4.SuspendLayout();
			MakerGroupBox.SuspendLayout();
			UnitGroupBox.SuspendLayout();
			TruckCodeGroupBox.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)violationBindingSource).BeginInit();
			groupBox1.SuspendLayout();
			groupBox7.SuspendLayout();
			SuspendLayout();
			// 
			// panelHeader
			// 
			panelHeader.BackColor = Color.White;
			panelHeader.Controls.Add(labelHeader);
			panelHeader.Controls.Add(groupBox6);
			panelHeader.Controls.Add(pictureBox1);
			panelHeader.Dock = DockStyle.Top;
			panelHeader.Location = new Point(0, 0);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(1062, 140);
			panelHeader.TabIndex = 1;
			// 
			// labelHeader
			// 
			labelHeader.Dock = DockStyle.Fill;
			labelHeader.Font = new Font("Cairo", 22F);
			labelHeader.Location = new Point(261, 0);
			labelHeader.Name = "labelHeader";
			labelHeader.Size = new Size(562, 140);
			labelHeader.TabIndex = 0;
			labelHeader.Text = "مخالفات السيارات الهاربة من منافذ التحصيل";
			labelHeader.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox6
			// 
			groupBox6.Controls.Add(NumMonthToExport);
			groupBox6.Controls.Add(btnExport);
			groupBox6.Dock = DockStyle.Left;
			groupBox6.Location = new Point(0, 0);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(261, 140);
			groupBox6.TabIndex = 12;
			groupBox6.TabStop = false;
			groupBox6.Text = "استخراج ابيانات لشهر محدد";
			// 
			// NumMonthToExport
			// 
			NumMonthToExport.Location = new Point(161, 44);
			NumMonthToExport.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
			NumMonthToExport.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			NumMonthToExport.Name = "NumMonthToExport";
			NumMonthToExport.RightToLeft = RightToLeft.No;
			NumMonthToExport.Size = new Size(94, 45);
			NumMonthToExport.TabIndex = 12;
			NumMonthToExport.TextAlign = HorizontalAlignment.Center;
			NumMonthToExport.Value = new decimal(new int[] { 7, 0, 0, 0 });
			// 
			// btnExport
			// 
			btnExport.CausesValidation = false;
			btnExport.Location = new Point(0, 44);
			btnExport.Name = "btnExport";
			btnExport.Size = new Size(127, 45);
			btnExport.TabIndex = 11;
			btnExport.Text = "استخراج";
			btnExport.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Right;
			pictureBox1.Image = Properties.Resources.الشعار;
			pictureBox1.Location = new Point(823, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(239, 140);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// EditTimer
			// 
			EditTimer.Interval = 1000;
			// 
			// splitContainer
			// 
			splitContainer.Dock = DockStyle.Fill;
			splitContainer.Location = new Point(0, 140);
			splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			splitContainer.Panel1.Controls.Add(panel1);
			splitContainer.Panel1.RightToLeft = RightToLeft.Yes;
			// 
			// splitContainer.Panel2
			// 
			splitContainer.Panel2.Controls.Add(groupBox3);
			splitContainer.Panel2.Controls.Add(groupBox7);
			splitContainer.Panel2.Controls.Add(groupBox1);
			splitContainer.Panel2.RightToLeft = RightToLeft.Yes;
			splitContainer.Size = new Size(1062, 592);
			splitContainer.SplitterDistance = 531;
			splitContainer.TabIndex = 8;
			// 
			// panel1
			// 
			panel1.Controls.Add(labelMessage);
			panel1.Controls.Add(btnSave);
			panel1.Controls.Add(panelWP);
			panel1.Controls.Add(DateGroupBox);
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(TruckCodeGroupBox);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(531, 592);
			panel1.TabIndex = 5;
			// 
			// labelMessage
			// 
			labelMessage.Dock = DockStyle.Fill;
			labelMessage.Font = new Font("Cairo", 12F);
			labelMessage.ForeColor = Color.Red;
			labelMessage.Location = new Point(0, 519);
			labelMessage.Name = "labelMessage";
			labelMessage.Size = new Size(531, 73);
			labelMessage.TabIndex = 0;
			labelMessage.TextAlign = ContentAlignment.TopCenter;
			// 
			// btnSave
			// 
			btnSave.Dock = DockStyle.Top;
			btnSave.Font = new Font("Cairo", 16F);
			btnSave.Image = Properties.Resources.diskette;
			btnSave.ImageAlign = ContentAlignment.MiddleLeft;
			btnSave.Location = new Point(0, 451);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(531, 68);
			btnSave.TabIndex = 5;
			btnSave.Text = "حفظ";
			btnSave.UseVisualStyleBackColor = true;
			// 
			// panelWP
			// 
			panelWP.Controls.Add(panel3);
			panelWP.Controls.Add(groupBox5);
			panelWP.Dock = DockStyle.Top;
			panelWP.Location = new Point(0, 356);
			panelWP.Name = "panelWP";
			panelWP.Size = new Size(531, 95);
			panelWP.TabIndex = 3;
			panelWP.Visible = false;
			// 
			// panel3
			// 
			panel3.Controls.Add(groupBox4);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Padding = new Padding(0, 0, 10, 0);
			panel3.Size = new Size(289, 95);
			panel3.TabIndex = 2;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(txtPyload);
			groupBox4.Dock = DockStyle.Fill;
			groupBox4.Location = new Point(0, 0);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(279, 95);
			groupBox4.TabIndex = 1;
			groupBox4.TabStop = false;
			groupBox4.Text = "الحمولة";
			// 
			// txtPyload
			// 
			txtPyload.Dock = DockStyle.Fill;
			txtPyload.Location = new Point(3, 41);
			txtPyload.Name = "txtPyload";
			txtPyload.Size = new Size(273, 45);
			txtPyload.TabIndex = 3;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(txtWeight);
			groupBox5.Dock = DockStyle.Right;
			groupBox5.Location = new Point(289, 0);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(242, 95);
			groupBox5.TabIndex = 0;
			groupBox5.TabStop = false;
			groupBox5.Text = "الوزن";
			// 
			// txtWeight
			// 
			txtWeight.Dock = DockStyle.Fill;
			txtWeight.Location = new Point(3, 41);
			txtWeight.Name = "txtWeight";
			txtWeight.Size = new Size(236, 45);
			txtWeight.TabIndex = 4;
			// 
			// DateGroupBox
			// 
			DateGroupBox.Controls.Add(flowLayoutPanel1);
			DateGroupBox.Dock = DockStyle.Top;
			DateGroupBox.Location = new Point(0, 248);
			DateGroupBox.Name = "DateGroupBox";
			DateGroupBox.Size = new Size(531, 108);
			DateGroupBox.TabIndex = 4;
			DateGroupBox.TabStop = false;
			DateGroupBox.Text = "التاريخ {يوم / شهر / سنه}";
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(label1);
			flowLayoutPanel1.Controls.Add(YearNum);
			flowLayoutPanel1.Controls.Add(label2);
			flowLayoutPanel1.Controls.Add(MonthNum);
			flowLayoutPanel1.Controls.Add(label3);
			flowLayoutPanel1.Controls.Add(DayNum);
			flowLayoutPanel1.Dock = DockStyle.Right;
			flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
			flowLayoutPanel1.Location = new Point(22, 41);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(506, 64);
			flowLayoutPanel1.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Cairo", 15F);
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(48, 47);
			label1.TabIndex = 0;
			label1.Text = "20";
			// 
			// YearNum
			// 
			YearNum.Location = new Point(57, 3);
			YearNum.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
			YearNum.Name = "YearNum";
			YearNum.RightToLeft = RightToLeft.No;
			YearNum.Size = new Size(74, 45);
			YearNum.TabIndex = 2;
			YearNum.TextAlign = HorizontalAlignment.Center;
			YearNum.Value = new decimal(new int[] { 24, 0, 0, 0 });
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Cairo", 16F);
			label2.Location = new Point(137, 0);
			label2.Name = "label2";
			label2.Size = new Size(33, 50);
			label2.TabIndex = 2;
			label2.Text = "/";
			// 
			// MonthNum
			// 
			MonthNum.Location = new Point(176, 3);
			MonthNum.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
			MonthNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			MonthNum.Name = "MonthNum";
			MonthNum.RightToLeft = RightToLeft.No;
			MonthNum.Size = new Size(74, 45);
			MonthNum.TabIndex = 1;
			MonthNum.TextAlign = HorizontalAlignment.Center;
			MonthNum.Value = new decimal(new int[] { 7, 0, 0, 0 });
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Cairo", 16F);
			label3.Location = new Point(256, 0);
			label3.Name = "label3";
			label3.Size = new Size(33, 50);
			label3.TabIndex = 3;
			label3.Text = "/";
			// 
			// DayNum
			// 
			DayNum.Location = new Point(295, 3);
			DayNum.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
			DayNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			DayNum.Name = "DayNum";
			DayNum.RightToLeft = RightToLeft.No;
			DayNum.Size = new Size(74, 45);
			DayNum.TabIndex = 0;
			DayNum.TextAlign = HorizontalAlignment.Center;
			DayNum.Value = new decimal(new int[] { 7, 0, 0, 0 });
			// 
			// panel2
			// 
			panel2.Controls.Add(panel4);
			panel2.Controls.Add(UnitGroupBox);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 153);
			panel2.Name = "panel2";
			panel2.Size = new Size(531, 95);
			panel2.TabIndex = 2;
			// 
			// panel4
			// 
			panel4.Controls.Add(MakerGroupBox);
			panel4.Dock = DockStyle.Fill;
			panel4.Location = new Point(0, 0);
			panel4.Name = "panel4";
			panel4.Padding = new Padding(0, 0, 10, 0);
			panel4.Size = new Size(286, 95);
			panel4.TabIndex = 2;
			// 
			// MakerGroupBox
			// 
			MakerGroupBox.Controls.Add(txtElManfaz);
			MakerGroupBox.Dock = DockStyle.Fill;
			MakerGroupBox.Location = new Point(0, 0);
			MakerGroupBox.Name = "MakerGroupBox";
			MakerGroupBox.Size = new Size(276, 95);
			MakerGroupBox.TabIndex = 1;
			MakerGroupBox.TabStop = false;
			MakerGroupBox.Text = "المنفذ";
			// 
			// txtElManfaz
			// 
			txtElManfaz.Dock = DockStyle.Fill;
			txtElManfaz.Location = new Point(3, 41);
			txtElManfaz.Name = "txtElManfaz";
			txtElManfaz.Size = new Size(270, 45);
			txtElManfaz.TabIndex = 3;
			// 
			// UnitGroupBox
			// 
			UnitGroupBox.Controls.Add(comboUnit);
			UnitGroupBox.Dock = DockStyle.Right;
			UnitGroupBox.Location = new Point(286, 0);
			UnitGroupBox.Name = "UnitGroupBox";
			UnitGroupBox.Size = new Size(245, 95);
			UnitGroupBox.TabIndex = 0;
			UnitGroupBox.TabStop = false;
			UnitGroupBox.Text = "الوحدة";
			// 
			// comboUnit
			// 
			comboUnit.AutoCompleteCustomSource.AddRange(new string[] { "كرداسة", "البدرشين", "الصف", "العياط" });
			comboUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			comboUnit.AutoCompleteSource = AutoCompleteSource.CustomSource;
			comboUnit.DisplayMember = "كرداسة";
			comboUnit.Dock = DockStyle.Fill;
			comboUnit.FormattingEnabled = true;
			comboUnit.Items.AddRange(new object[] { "كرداسة", "البدرشين", "الصف", "العياط" });
			comboUnit.Location = new Point(3, 41);
			comboUnit.Name = "comboUnit";
			comboUnit.Size = new Size(239, 45);
			comboUnit.TabIndex = 2;
			// 
			// TruckCodeGroupBox
			// 
			TruckCodeGroupBox.Controls.Add(truckCodeBodx1);
			TruckCodeGroupBox.Dock = DockStyle.Top;
			TruckCodeGroupBox.Location = new Point(0, 0);
			TruckCodeGroupBox.Name = "TruckCodeGroupBox";
			TruckCodeGroupBox.RightToLeft = RightToLeft.Yes;
			TruckCodeGroupBox.Size = new Size(531, 153);
			TruckCodeGroupBox.TabIndex = 0;
			TruckCodeGroupBox.TabStop = false;
			TruckCodeGroupBox.Text = "رقم السيارة";
			// 
			// truckCodeBodx1
			// 
			truckCodeBodx1.AutoSize = true;
			truckCodeBodx1.Dock = DockStyle.Fill;
			truckCodeBodx1.FirstNumberTextBox = null;
			truckCodeBodx1.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			truckCodeBodx1.Location = new Point(3, 41);
			truckCodeBodx1.Name = "truckCodeBodx1";
			truckCodeBodx1.RightToLeft = RightToLeft.Yes;
			truckCodeBodx1.Size = new Size(525, 109);
			truckCodeBodx1.TabIndex = 1;
			truckCodeBodx1.txtTruckCode = "";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(dataGridView);
			groupBox3.Dock = DockStyle.Fill;
			groupBox3.Location = new Point(0, 257);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(5);
			groupBox3.Size = new Size(527, 335);
			groupBox3.TabIndex = 6;
			groupBox3.TabStop = false;
			groupBox3.Text = "اختر الصف للتعديل";
			// 
			// dataGridView
			// 
			dataGridView.AllowUserToAddRows = false;
			dataGridView.AllowUserToDeleteRows = false;
			dataGridView.AllowUserToOrderColumns = true;
			dataGridView.AutoGenerateColumns = false;
			dataGridView.BackgroundColor = Color.White;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = SystemColors.ButtonShadow;
			dataGridViewCellStyle1.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, truckCodeDataGridViewTextBoxColumn, violationDateDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, elManfazDataGridViewTextBoxColumn, registrationDateDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn, payloadDataGridViewTextBoxColumn });
			dataGridView.DataSource = violationBindingSource;
			dataGridView.Dock = DockStyle.Fill;
			dataGridView.Location = new Point(5, 43);
			dataGridView.MultiSelect = false;
			dataGridView.Name = "dataGridView";
			dataGridView.ReadOnly = true;
			dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			dataGridView.RowTemplate.Height = 24;
			dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView.Size = new Size(517, 287);
			dataGridView.TabIndex = 0;
			// 
			// idDataGridViewTextBoxColumn
			// 
			idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			idDataGridViewTextBoxColumn.HeaderText = "Id";
			idDataGridViewTextBoxColumn.MinimumWidth = 6;
			idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			idDataGridViewTextBoxColumn.ReadOnly = true;
			idDataGridViewTextBoxColumn.Visible = false;
			idDataGridViewTextBoxColumn.Width = 125;
			// 
			// truckCodeDataGridViewTextBoxColumn
			// 
			truckCodeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			truckCodeDataGridViewTextBoxColumn.DataPropertyName = "TruckCode";
			truckCodeDataGridViewTextBoxColumn.HeaderText = "رقم الشاحنة";
			truckCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
			truckCodeDataGridViewTextBoxColumn.Name = "truckCodeDataGridViewTextBoxColumn";
			truckCodeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// violationDateDataGridViewTextBoxColumn
			// 
			violationDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			violationDateDataGridViewTextBoxColumn.DataPropertyName = "ViolationDate";
			dataGridViewCellStyle2.Format = "yy/MM/dd";
			dataGridViewCellStyle2.NullValue = null;
			violationDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			violationDateDataGridViewTextBoxColumn.HeaderText = "تاريخ المخالفة";
			violationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			violationDateDataGridViewTextBoxColumn.Name = "violationDateDataGridViewTextBoxColumn";
			violationDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// unitDataGridViewTextBoxColumn
			// 
			unitDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
			unitDataGridViewTextBoxColumn.HeaderText = "الوحدة";
			unitDataGridViewTextBoxColumn.MinimumWidth = 6;
			unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
			unitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// elManfazDataGridViewTextBoxColumn
			// 
			elManfazDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			elManfazDataGridViewTextBoxColumn.DataPropertyName = "ElManfaz";
			elManfazDataGridViewTextBoxColumn.HeaderText = "المنفذ";
			elManfazDataGridViewTextBoxColumn.MinimumWidth = 6;
			elManfazDataGridViewTextBoxColumn.Name = "elManfazDataGridViewTextBoxColumn";
			elManfazDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// registrationDateDataGridViewTextBoxColumn
			// 
			registrationDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
			registrationDateDataGridViewTextBoxColumn.HeaderText = "تاريخ التسجيل";
			registrationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
			registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// weightDataGridViewTextBoxColumn
			// 
			weightDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			weightDataGridViewTextBoxColumn.HeaderText = "الوزن";
			weightDataGridViewTextBoxColumn.MinimumWidth = 6;
			weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			weightDataGridViewTextBoxColumn.ReadOnly = true;
			weightDataGridViewTextBoxColumn.Visible = false;
			// 
			// payloadDataGridViewTextBoxColumn
			// 
			payloadDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			payloadDataGridViewTextBoxColumn.DataPropertyName = "Payload";
			payloadDataGridViewTextBoxColumn.HeaderText = "الحمولة";
			payloadDataGridViewTextBoxColumn.MinimumWidth = 6;
			payloadDataGridViewTextBoxColumn.Name = "payloadDataGridViewTextBoxColumn";
			payloadDataGridViewTextBoxColumn.ReadOnly = true;
			payloadDataGridViewTextBoxColumn.Visible = false;
			// 
			// violationBindingSource
			// 
			violationBindingSource.DataSource = typeof(Model.Entities.Violation);
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnEditMode);
			groupBox1.Controls.Add(btnAddMode);
			groupBox1.Dock = DockStyle.Top;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Margin = new Padding(3, 3, 3, 10);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(7);
			groupBox1.Size = new Size(527, 104);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "الوضع";
			// 
			// btnEditMode
			// 
			btnEditMode.Dock = DockStyle.Left;
			btnEditMode.Image = Properties.Resources.pencil;
			btnEditMode.ImageAlign = ContentAlignment.MiddleRight;
			btnEditMode.Location = new Point(7, 45);
			btnEditMode.Name = "btnEditMode";
			btnEditMode.Padding = new Padding(5);
			btnEditMode.Size = new Size(200, 52);
			btnEditMode.TabIndex = 10;
			btnEditMode.Text = "وضع التعديل";
			btnEditMode.UseVisualStyleBackColor = true;
			btnEditMode.Click += btnEditMode_Click;
			// 
			// btnAddMode
			// 
			btnAddMode.BackColor = Color.DeepSkyBlue;
			btnAddMode.Dock = DockStyle.Right;
			btnAddMode.Image = Properties.Resources.add_button;
			btnAddMode.ImageAlign = ContentAlignment.MiddleLeft;
			btnAddMode.Location = new Point(320, 45);
			btnAddMode.Name = "btnAddMode";
			btnAddMode.Padding = new Padding(5);
			btnAddMode.Size = new Size(200, 52);
			btnAddMode.TabIndex = 9;
			btnAddMode.Text = "وضع الإضافة";
			btnAddMode.UseVisualStyleBackColor = false;
			btnAddMode.Click += btnAddMode_Click;
			// 
			// groupBox7
			// 
			groupBox7.Controls.Add(truckCodeBoxSearch);
			groupBox7.Dock = DockStyle.Top;
			groupBox7.Location = new Point(0, 104);
			groupBox7.Name = "groupBox7";
			groupBox7.RightToLeft = RightToLeft.Yes;
			groupBox7.Size = new Size(527, 153);
			groupBox7.TabIndex = 7;
			groupBox7.TabStop = false;
			groupBox7.Text = "رقم السيارة";
			// 
			// truckCodeBoxSearch
			// 
			truckCodeBoxSearch.AutoSize = true;
			truckCodeBoxSearch.Dock = DockStyle.Fill;
			truckCodeBoxSearch.FirstNumberTextBox = null;
			truckCodeBoxSearch.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			truckCodeBoxSearch.Location = new Point(3, 41);
			truckCodeBoxSearch.Name = "truckCodeBoxSearch";
			truckCodeBoxSearch.RightToLeft = RightToLeft.Yes;
			truckCodeBoxSearch.Size = new Size(521, 109);
			truckCodeBoxSearch.TabIndex = 1;
			truckCodeBoxSearch.txtTruckCode = "";
			// 
			// MainView
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(1062, 732);
			Controls.Add(splitContainer);
			Controls.Add(panelHeader);
			Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MinimumSize = new Size(1080, 720);
			Name = "MainView";
			RightToLeft = RightToLeft.Yes;
			RightToLeftLayout = true;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "برنامج تسجيل المخالفات";
			WindowState = FormWindowState.Maximized;
			panelHeader.ResumeLayout(false);
			groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)NumMonthToExport).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			splitContainer.Panel1.ResumeLayout(false);
			splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
			splitContainer.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panelWP.ResumeLayout(false);
			panel3.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			DateGroupBox.ResumeLayout(false);
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)YearNum).EndInit();
			((System.ComponentModel.ISupportInitialize)MonthNum).EndInit();
			((System.ComponentModel.ISupportInitialize)DayNum).EndInit();
			panel2.ResumeLayout(false);
			panel4.ResumeLayout(false);
			MakerGroupBox.ResumeLayout(false);
			MakerGroupBox.PerformLayout();
			UnitGroupBox.ResumeLayout(false);
			TruckCodeGroupBox.ResumeLayout(false);
			TruckCodeGroupBox.PerformLayout();
			groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)violationBindingSource).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox7.ResumeLayout(false);
			groupBox7.PerformLayout();
			ResumeLayout(false);
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
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtElManfaz;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.NumericUpDown YearNum;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown DayNum;
		private System.Windows.Forms.NumericUpDown MonthNum;
		private System.Windows.Forms.Panel panelWP;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtPyload;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox txtWeight;
		private System.Windows.Forms.ComboBox comboUnit;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label labelMessage;
		private BindingSource violationBindingSource;
		private PictureBox pictureBox1;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn truckCodeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn violationDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn elManfazDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn payloadDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn truckDataGridViewTextBoxColumn;
		private Button btnExport;
		private GroupBox groupBox6;
		private NumericUpDown NumMonthToExport;
		private TruckCodeBodx truckCodeBodx1;
		private GroupBox groupBox7;
		private TruckCodeBodx truckCodeBoxSearch;
	}
}