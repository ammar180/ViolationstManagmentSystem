using System;
using System.Drawing;
using System.Windows.Forms;
using ViolationsCollector.View.CustomeComponants;

namespace ViolationsCollector.View
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
			this.panelHeader = new System.Windows.Forms.Panel();
			this.labelHeader = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.EditTimer = new System.Windows.Forms.Timer(this.components);
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.btnUpdateExportPath = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panelWP = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtPyload = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtWeight = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.MakerGroupBox = new System.Windows.Forms.GroupBox();
			this.txtElManfaz = new System.Windows.Forms.ComboBox();
			this.labElManfazMessage = new System.Windows.Forms.Label();
			this.UnitGroupBox = new System.Windows.Forms.GroupBox();
			this.comboUnit = new System.Windows.Forms.ComboBox();
			this.labUnitMessage = new System.Windows.Forms.Label();
			this.TruckCodeGroupBox = new System.Windows.Forms.GroupBox();
			this.labCodeMessage = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnEditMode = new System.Windows.Forms.RadioButton();
			this.btnAddMode = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.dateBox1 = new ViolationsCollector.View.CustomeComponants.DateBox();
			this.truckCodeBodx1 = new ViolationsCollector.View.CustomeComponants.TruckCodeBodx();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.truckCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.violationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.elManfazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.payloadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.violationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.panelWP.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.MakerGroupBox.SuspendLayout();
			this.UnitGroupBox.SuspendLayout();
			this.TruckCodeGroupBox.SuspendLayout();
			this.panel5.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.White;
			this.panelHeader.Controls.Add(this.labelHeader);
			this.panelHeader.Controls.Add(this.pictureBox1);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1062, 140);
			this.panelHeader.TabIndex = 1;
			// 
			// labelHeader
			// 
			this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelHeader.Font = new System.Drawing.Font("Cairo", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHeader.Location = new System.Drawing.Point(0, 0);
			this.labelHeader.Name = "labelHeader";
			this.labelHeader.Size = new System.Drawing.Size(823, 140);
			this.labelHeader.TabIndex = 0;
			this.labelHeader.Text = "مخالفات السيارات الهاربة من منافذ التحصيل";
			this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = global::ViolationsCollector.Properties.Resources.الشعار;
			this.pictureBox1.Location = new System.Drawing.Point(823, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(239, 140);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// EditTimer
			// 
			this.EditTimer.Interval = 1000;
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 140);
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
			this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.splitContainer.Size = new System.Drawing.Size(1062, 776);
			this.splitContainer.SplitterDistance = 393;
			this.splitContainer.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox6);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.panelWP);
			this.panel1.Controls.Add(this.dateBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.TruckCodeGroupBox);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(393, 776);
			this.panel1.TabIndex = 5;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.button1);
			this.groupBox6.Controls.Add(this.btnUpdateExportPath);
			this.groupBox6.Controls.Add(this.btnExport);
			this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox6.Location = new System.Drawing.Point(0, 542);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(393, 138);
			this.groupBox6.TabIndex = 13;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "استخراج ابيانات لشهر محدد";
			// 
			// btnUpdateExportPath
			// 
			this.btnUpdateExportPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnUpdateExportPath.CausesValidation = false;
			this.btnUpdateExportPath.Font = new System.Drawing.Font("Cairo", 10F);
			this.btnUpdateExportPath.Location = new System.Drawing.Point(146, 34);
			this.btnUpdateExportPath.Name = "btnUpdateExportPath";
			this.btnUpdateExportPath.Size = new System.Drawing.Size(227, 45);
			this.btnUpdateExportPath.TabIndex = 13;
			this.btnUpdateExportPath.Text = "تعديل مسار الاستخراج";
			this.btnUpdateExportPath.UseVisualStyleBackColor = true;
			this.btnUpdateExportPath.Click += new System.EventHandler(this.btnUpdateExportPath_Click);
			// 
			// btnExport
			// 
			this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnExport.BackColor = System.Drawing.Color.PaleGreen;
			this.btnExport.CausesValidation = false;
			this.btnExport.Font = new System.Drawing.Font("Cairo", 12F);
			this.btnExport.Location = new System.Drawing.Point(13, 34);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(127, 45);
			this.btnExport.TabIndex = 11;
			this.btnExport.Text = "استخراج";
			this.btnExport.UseVisualStyleBackColor = false;
			// 
			// btnSave
			// 
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSave.Font = new System.Drawing.Font("Cairo", 16F);
			this.btnSave.Image = global::ViolationsCollector.Properties.Resources.diskette;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(0, 474);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(393, 68);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "حفظ";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// panelWP
			// 
			this.panelWP.Controls.Add(this.panel3);
			this.panelWP.Controls.Add(this.groupBox5);
			this.panelWP.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelWP.Location = new System.Drawing.Point(0, 385);
			this.panelWP.Name = "panelWP";
			this.panelWP.Size = new System.Drawing.Size(393, 89);
			this.panelWP.TabIndex = 3;
			this.panelWP.Visible = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.groupBox4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.panel3.Size = new System.Drawing.Size(151, 89);
			this.panel3.TabIndex = 2;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtPyload);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox4.Size = new System.Drawing.Size(141, 89);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "الحمولة";
			// 
			// txtPyload
			// 
			this.txtPyload.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtPyload.Location = new System.Drawing.Point(0, 38);
			this.txtPyload.Name = "txtPyload";
			this.txtPyload.Size = new System.Drawing.Size(141, 45);
			this.txtPyload.TabIndex = 3;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txtWeight);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox5.Location = new System.Drawing.Point(151, 0);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox5.Size = new System.Drawing.Size(242, 89);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "الوزن";
			// 
			// txtWeight
			// 
			this.txtWeight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtWeight.Location = new System.Drawing.Point(0, 38);
			this.txtWeight.Name = "txtWeight";
			this.txtWeight.Size = new System.Drawing.Size(242, 45);
			this.txtWeight.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.UnitGroupBox);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 186);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(393, 108);
			this.panel2.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.MakerGroupBox);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.panel4.Size = new System.Drawing.Size(148, 108);
			this.panel4.TabIndex = 2;
			// 
			// MakerGroupBox
			// 
			this.MakerGroupBox.Controls.Add(this.txtElManfaz);
			this.MakerGroupBox.Controls.Add(this.labElManfazMessage);
			this.MakerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MakerGroupBox.Location = new System.Drawing.Point(0, 0);
			this.MakerGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.MakerGroupBox.Name = "MakerGroupBox";
			this.MakerGroupBox.Padding = new System.Windows.Forms.Padding(0);
			this.MakerGroupBox.Size = new System.Drawing.Size(138, 108);
			this.MakerGroupBox.TabIndex = 1;
			this.MakerGroupBox.TabStop = false;
			this.MakerGroupBox.Text = "المنفذ";
			// 
			// txtElManfaz
			// 
			this.txtElManfaz.AutoCompleteCustomSource.AddRange(new string[] {
            "المحطة",
            "القطا",
            "الدرية",
            "نكلا الرهاوي",
            "كوبري القناطر",
            "نكلا المرور"});
			this.txtElManfaz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtElManfaz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtElManfaz.DisplayMember = "كرداسة";
			this.txtElManfaz.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtElManfaz.FormattingEnabled = true;
			this.txtElManfaz.Items.AddRange(new object[] {
            "الصليبة",
            "كرداسة",
            "أبورواش",
            "المعتمدية",
            "صفط"});
			this.txtElManfaz.Location = new System.Drawing.Point(0, 38);
			this.txtElManfaz.Name = "txtElManfaz";
			this.txtElManfaz.Size = new System.Drawing.Size(138, 45);
			this.txtElManfaz.TabIndex = 5;
			this.txtElManfaz.Text = "كرداسة";
			// 
			// labElManfazMessage
			// 
			this.labElManfazMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labElManfazMessage.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labElManfazMessage.ForeColor = System.Drawing.Color.Red;
			this.labElManfazMessage.Location = new System.Drawing.Point(0, 83);
			this.labElManfazMessage.Name = "labElManfazMessage";
			this.labElManfazMessage.Size = new System.Drawing.Size(138, 25);
			this.labElManfazMessage.TabIndex = 4;
			this.labElManfazMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// UnitGroupBox
			// 
			this.UnitGroupBox.Controls.Add(this.comboUnit);
			this.UnitGroupBox.Controls.Add(this.labUnitMessage);
			this.UnitGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.UnitGroupBox.Location = new System.Drawing.Point(148, 0);
			this.UnitGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.UnitGroupBox.Name = "UnitGroupBox";
			this.UnitGroupBox.Padding = new System.Windows.Forms.Padding(0);
			this.UnitGroupBox.Size = new System.Drawing.Size(245, 108);
			this.UnitGroupBox.TabIndex = 0;
			this.UnitGroupBox.TabStop = false;
			this.UnitGroupBox.Text = "الوحدة";
			// 
			// comboUnit
			// 
			this.comboUnit.AutoCompleteCustomSource.AddRange(new string[] {
            "كرداسة",
            "البدرشين",
            "الصف",
            "العياط",
            "منشاة القناطر",
            "ابو النمرس",
            "الواحات البحرية",
            "اطفيح",
            "اكتوبر"});
			this.comboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.comboUnit.DisplayMember = "كرداسة";
			this.comboUnit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboUnit.FormattingEnabled = true;
			this.comboUnit.Items.AddRange(new object[] {
            "كرداسة",
            "البدرشين",
            "الصف",
            "العياط",
            "منشاة القناطر",
            "ابو النمرس",
            "الواحات البحرية",
            "اطفيح",
            "اكتوبر"});
			this.comboUnit.Location = new System.Drawing.Point(0, 38);
			this.comboUnit.Name = "comboUnit";
			this.comboUnit.Size = new System.Drawing.Size(245, 45);
			this.comboUnit.TabIndex = 2;
			this.comboUnit.Text = "كرداسة";
			this.comboUnit.SelectedIndexChanged += new System.EventHandler(this.comboUnit_SelectedIndexChanged);
			// 
			// labUnitMessage
			// 
			this.labUnitMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labUnitMessage.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labUnitMessage.ForeColor = System.Drawing.Color.Red;
			this.labUnitMessage.Location = new System.Drawing.Point(0, 83);
			this.labUnitMessage.Name = "labUnitMessage";
			this.labUnitMessage.Size = new System.Drawing.Size(245, 25);
			this.labUnitMessage.TabIndex = 3;
			this.labUnitMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// TruckCodeGroupBox
			// 
			this.TruckCodeGroupBox.Controls.Add(this.labCodeMessage);
			this.TruckCodeGroupBox.Controls.Add(this.truckCodeBodx1);
			this.TruckCodeGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.TruckCodeGroupBox.Location = new System.Drawing.Point(0, 41);
			this.TruckCodeGroupBox.Name = "TruckCodeGroupBox";
			this.TruckCodeGroupBox.Padding = new System.Windows.Forms.Padding(0);
			this.TruckCodeGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.TruckCodeGroupBox.Size = new System.Drawing.Size(393, 145);
			this.TruckCodeGroupBox.TabIndex = 0;
			this.TruckCodeGroupBox.TabStop = false;
			this.TruckCodeGroupBox.Text = "رقم السيارة";
			// 
			// labCodeMessage
			// 
			this.labCodeMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labCodeMessage.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCodeMessage.ForeColor = System.Drawing.Color.Red;
			this.labCodeMessage.Location = new System.Drawing.Point(0, 122);
			this.labCodeMessage.Name = "labCodeMessage";
			this.labCodeMessage.Size = new System.Drawing.Size(393, 23);
			this.labCodeMessage.TabIndex = 0;
			this.labCodeMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.btnEditMode);
			this.panel5.Controls.Add(this.btnAddMode);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(393, 41);
			this.panel5.TabIndex = 14;
			// 
			// btnEditMode
			// 
			this.btnEditMode.AutoSize = true;
			this.btnEditMode.BackColor = System.Drawing.Color.Transparent;
			this.btnEditMode.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnEditMode.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnEditMode.Image = global::ViolationsCollector.Properties.Resources.pencil;
			this.btnEditMode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditMode.Location = new System.Drawing.Point(0, 0);
			this.btnEditMode.Name = "btnEditMode";
			this.btnEditMode.Size = new System.Drawing.Size(135, 41);
			this.btnEditMode.TabIndex = 12;
			this.btnEditMode.Text = "تعديل        ";
			this.btnEditMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnEditMode.UseVisualStyleBackColor = false;
			// 
			// btnAddMode
			// 
			this.btnAddMode.AutoSize = true;
			this.btnAddMode.BackColor = System.Drawing.Color.LightGreen;
			this.btnAddMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddMode.Checked = true;
			this.btnAddMode.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAddMode.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnAddMode.Image = global::ViolationsCollector.Properties.Resources.add_button;
			this.btnAddMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddMode.Location = new System.Drawing.Point(264, 0);
			this.btnAddMode.Name = "btnAddMode";
			this.btnAddMode.Size = new System.Drawing.Size(129, 41);
			this.btnAddMode.TabIndex = 11;
			this.btnAddMode.TabStop = true;
			this.btnAddMode.Text = "      إضافة";
			this.btnAddMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnAddMode.UseVisualStyleBackColor = false;
			this.btnAddMode.CheckedChanged += new System.EventHandler(this.btnAddMode_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox3.Size = new System.Drawing.Size(665, 776);
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
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.truckCodeDataGridViewTextBoxColumn,
            this.violationDateDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.elManfazDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.payloadDataGridViewTextBoxColumn});
			this.dataGridView.DataSource = this.violationBindingSource;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(5, 43);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F);
			this.dataGridView.RowTemplate.Height = 35;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(655, 728);
			this.dataGridView.TabIndex = 0;
			// 
			// dateBox1
			// 
			this.dateBox1.Date = new System.DateTime(2024, 8, 21, 0, 0, 0, 0);
			this.dateBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.dateBox1.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateBox1.Location = new System.Drawing.Point(0, 294);
			this.dateBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.dateBox1.Name = "dateBox1";
			this.dateBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateBox1.Size = new System.Drawing.Size(393, 91);
			this.dateBox1.TabIndex = 6;
			// 
			// truckCodeBodx1
			// 
			this.truckCodeBodx1.AutoSize = true;
			this.truckCodeBodx1.Dock = System.Windows.Forms.DockStyle.Top;
			this.truckCodeBodx1.FirstNumberTextBox = null;
			this.truckCodeBodx1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.truckCodeBodx1.Location = new System.Drawing.Point(0, 38);
			this.truckCodeBodx1.Name = "truckCodeBodx1";
			this.truckCodeBodx1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.truckCodeBodx1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.truckCodeBodx1.Size = new System.Drawing.Size(393, 106);
			this.truckCodeBodx1.TabIndex = 1;
			this.truckCodeBodx1.txtTruckCode = "";
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
			// truckCodeDataGridViewTextBoxColumn
			// 
			this.truckCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.truckCodeDataGridViewTextBoxColumn.DataPropertyName = "TruckCode";
			this.truckCodeDataGridViewTextBoxColumn.HeaderText = "رقم الشاحنة";
			this.truckCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.truckCodeDataGridViewTextBoxColumn.Name = "truckCodeDataGridViewTextBoxColumn";
			this.truckCodeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// violationDateDataGridViewTextBoxColumn
			// 
			this.violationDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.violationDateDataGridViewTextBoxColumn.DataPropertyName = "ViolationDate";
			dataGridViewCellStyle2.Format = "dd/MM/yyyy";
			dataGridViewCellStyle2.NullValue = null;
			this.violationDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.violationDateDataGridViewTextBoxColumn.HeaderText = "تاريخ المخالفة";
			this.violationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.violationDateDataGridViewTextBoxColumn.Name = "violationDateDataGridViewTextBoxColumn";
			this.violationDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// unitDataGridViewTextBoxColumn
			// 
			this.unitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
			this.unitDataGridViewTextBoxColumn.HeaderText = "الوحدة";
			this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
			this.unitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// elManfazDataGridViewTextBoxColumn
			// 
			this.elManfazDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.elManfazDataGridViewTextBoxColumn.DataPropertyName = "ElManfaz";
			this.elManfazDataGridViewTextBoxColumn.HeaderText = "المنفذ";
			this.elManfazDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.elManfazDataGridViewTextBoxColumn.Name = "elManfazDataGridViewTextBoxColumn";
			this.elManfazDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// registrationDateDataGridViewTextBoxColumn
			// 
			this.registrationDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
			this.registrationDateDataGridViewTextBoxColumn.HeaderText = "تاريخ التسجيل";
			this.registrationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
			this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// weightDataGridViewTextBoxColumn
			// 
			this.weightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			this.weightDataGridViewTextBoxColumn.HeaderText = "الوزن";
			this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			this.weightDataGridViewTextBoxColumn.ReadOnly = true;
			this.weightDataGridViewTextBoxColumn.Visible = false;
			// 
			// payloadDataGridViewTextBoxColumn
			// 
			this.payloadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.payloadDataGridViewTextBoxColumn.DataPropertyName = "Payload";
			this.payloadDataGridViewTextBoxColumn.HeaderText = "الحمولة";
			this.payloadDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.payloadDataGridViewTextBoxColumn.Name = "payloadDataGridViewTextBoxColumn";
			this.payloadDataGridViewTextBoxColumn.ReadOnly = true;
			this.payloadDataGridViewTextBoxColumn.Visible = false;
			// 
			// violationBindingSource
			// 
			this.violationBindingSource.DataSource = typeof(ViolationsCollector.Model.Entities.Violation);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button1.CausesValidation = false;
			this.button1.Font = new System.Drawing.Font("Cairo", 10F);
			this.button1.Location = new System.Drawing.Point(13, 85);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(357, 45);
			this.button1.TabIndex = 14;
			this.button1.Text = "تحديث عبر الانترنت";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// MainView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1062, 916);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.panelHeader);
			this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 700);
			this.Name = "MainView";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "برنامج تسجيل المخالفات";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panelHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.panelWP.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.MakerGroupBox.ResumeLayout(false);
			this.UnitGroupBox.ResumeLayout(false);
			this.TruckCodeGroupBox.ResumeLayout(false);
			this.TruckCodeGroupBox.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panelWP;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtPyload;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox txtWeight;
		private System.Windows.Forms.ComboBox comboUnit;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label labCodeMessage;
		private BindingSource violationBindingSource;
		private PictureBox pictureBox1;
		private DataGridViewTextBoxColumn truckDataGridViewTextBoxColumn;
		private TruckCodeBodx truckCodeBodx1;
		private Label labElManfazMessage;
		private Label labUnitMessage;
		private ComboBox txtElManfaz;
		private DateBox dateBox1;
		private GroupBox groupBox6;
		private Button btnExport;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn truckCodeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn violationDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn elManfazDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn payloadDataGridViewTextBoxColumn;
		private RadioButton btnEditMode;
		private RadioButton btnAddMode;
		private Panel panel5;
		private Button btnUpdateExportPath;
		private Button button1;
	}
}