using System.Drawing;
using System.Windows.Forms;
namespace ViolationsSystem
{
	partial class ImportView
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportView));
			this.MainTabe = new System.Windows.Forms.TabControl();
			this.importExcelTP = new System.Windows.Forms.TabPage();
			this.labRowsCount = new System.Windows.Forms.Label();
			this.labCurrentCar = new System.Windows.Forms.Label();
			this.labPresantage = new System.Windows.Forms.Label();
			this.labFileName = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnChooseFile = new System.Windows.Forms.Button();
			this.importMultTP = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateBox1 = new ViolationsCollecting.View.CustomeComponants.DateBox();
			this.dateBox2 = new ViolationsCollecting.View.CustomeComponants.DateBox();
			this.btnRegist = new System.Windows.Forms.Button();
			this.NumTrucksCount = new System.Windows.Forms.NumericUpDown();
			this.comboElManfaz = new System.Windows.Forms.ComboBox();
			this.comboUnit = new System.Windows.Forms.ComboBox();
			this.truckCodeBodx1 = new ViolationsCollecting.View.CustomeComponants.TruckCodeBodx();
			this.labErrorMessage = new System.Windows.Forms.Label();
			this.MainTabe.SuspendLayout();
			this.importExcelTP.SuspendLayout();
			this.importMultTP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumTrucksCount)).BeginInit();
			this.SuspendLayout();
			// 
			// MainTabe
			// 
			this.MainTabe.Controls.Add(this.importExcelTP);
			this.MainTabe.Controls.Add(this.importMultTP);
			resources.ApplyResources(this.MainTabe, "MainTabe");
			this.MainTabe.Name = "MainTabe";
			this.MainTabe.SelectedIndex = 0;
			// 
			// importExcelTP
			// 
			this.importExcelTP.Controls.Add(this.labRowsCount);
			this.importExcelTP.Controls.Add(this.labCurrentCar);
			this.importExcelTP.Controls.Add(this.labPresantage);
			this.importExcelTP.Controls.Add(this.labFileName);
			this.importExcelTP.Controls.Add(this.progressBar1);
			this.importExcelTP.Controls.Add(this.btnChooseFile);
			resources.ApplyResources(this.importExcelTP, "importExcelTP");
			this.importExcelTP.Name = "importExcelTP";
			this.importExcelTP.UseVisualStyleBackColor = true;
			// 
			// labRowsCount
			// 
			resources.ApplyResources(this.labRowsCount, "labRowsCount");
			this.labRowsCount.Name = "labRowsCount";
			// 
			// labCurrentCar
			// 
			resources.ApplyResources(this.labCurrentCar, "labCurrentCar");
			this.labCurrentCar.Name = "labCurrentCar";
			// 
			// labPresantage
			// 
			resources.ApplyResources(this.labPresantage, "labPresantage");
			this.labPresantage.Name = "labPresantage";
			// 
			// labFileName
			// 
			resources.ApplyResources(this.labFileName, "labFileName");
			this.labFileName.Name = "labFileName";
			// 
			// progressBar1
			// 
			resources.ApplyResources(this.progressBar1, "progressBar1");
			this.progressBar1.Name = "progressBar1";
			// 
			// btnChooseFile
			// 
			resources.ApplyResources(this.btnChooseFile, "btnChooseFile");
			this.btnChooseFile.Name = "btnChooseFile";
			this.btnChooseFile.UseVisualStyleBackColor = true;
			this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
			// 
			// importMultTP
			// 
			this.importMultTP.Controls.Add(this.labErrorMessage);
			this.importMultTP.Controls.Add(this.label2);
			this.importMultTP.Controls.Add(this.label1);
			this.importMultTP.Controls.Add(this.dateBox1);
			this.importMultTP.Controls.Add(this.dateBox2);
			this.importMultTP.Controls.Add(this.btnRegist);
			this.importMultTP.Controls.Add(this.NumTrucksCount);
			this.importMultTP.Controls.Add(this.comboElManfaz);
			this.importMultTP.Controls.Add(this.comboUnit);
			this.importMultTP.Controls.Add(this.truckCodeBodx1);
			resources.ApplyResources(this.importMultTP, "importMultTP");
			this.importMultTP.Name = "importMultTP";
			this.importMultTP.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// dateBox1
			// 
			this.dateBox1.Date = new System.DateTime(2024, 7, 29, 0, 0, 0, 0);
			resources.ApplyResources(this.dateBox1, "dateBox1");
			this.dateBox1.Name = "dateBox1";
			// 
			// dateBox2
			// 
			this.dateBox2.Date = new System.DateTime(2024, 7, 29, 0, 0, 0, 0);
			resources.ApplyResources(this.dateBox2, "dateBox2");
			this.dateBox2.Name = "dateBox2";
			// 
			// btnRegist
			// 
			resources.ApplyResources(this.btnRegist, "btnRegist");
			this.btnRegist.Name = "btnRegist";
			this.btnRegist.UseVisualStyleBackColor = true;
			this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
			// 
			// NumTrucksCount
			// 
			resources.ApplyResources(this.NumTrucksCount, "NumTrucksCount");
			this.NumTrucksCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.NumTrucksCount.Name = "NumTrucksCount";
			// 
			// comboElManfaz
			// 
			this.comboElManfaz.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("comboElManfaz.AutoCompleteCustomSource"),
            resources.GetString("comboElManfaz.AutoCompleteCustomSource1"),
            resources.GetString("comboElManfaz.AutoCompleteCustomSource2"),
            resources.GetString("comboElManfaz.AutoCompleteCustomSource3"),
            resources.GetString("comboElManfaz.AutoCompleteCustomSource4")});
			this.comboElManfaz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboElManfaz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.comboElManfaz.FormattingEnabled = true;
			this.comboElManfaz.Items.AddRange(new object[] {
            resources.GetString("comboElManfaz.Items"),
            resources.GetString("comboElManfaz.Items1"),
            resources.GetString("comboElManfaz.Items2"),
            resources.GetString("comboElManfaz.Items3"),
            resources.GetString("comboElManfaz.Items4")});
			resources.ApplyResources(this.comboElManfaz, "comboElManfaz");
			this.comboElManfaz.Name = "comboElManfaz";
			// 
			// comboUnit
			// 
			this.comboUnit.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("comboUnit.AutoCompleteCustomSource"),
            resources.GetString("comboUnit.AutoCompleteCustomSource1"),
            resources.GetString("comboUnit.AutoCompleteCustomSource2"),
            resources.GetString("comboUnit.AutoCompleteCustomSource3"),
            resources.GetString("comboUnit.AutoCompleteCustomSource4"),
            resources.GetString("comboUnit.AutoCompleteCustomSource5"),
            resources.GetString("comboUnit.AutoCompleteCustomSource6"),
            resources.GetString("comboUnit.AutoCompleteCustomSource7"),
            resources.GetString("comboUnit.AutoCompleteCustomSource8")});
			this.comboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.comboUnit.FormattingEnabled = true;
			this.comboUnit.Items.AddRange(new object[] {
            resources.GetString("comboUnit.Items"),
            resources.GetString("comboUnit.Items1"),
            resources.GetString("comboUnit.Items2"),
            resources.GetString("comboUnit.Items3"),
            resources.GetString("comboUnit.Items4"),
            resources.GetString("comboUnit.Items5"),
            resources.GetString("comboUnit.Items6"),
            resources.GetString("comboUnit.Items7"),
            resources.GetString("comboUnit.Items8")});
			resources.ApplyResources(this.comboUnit, "comboUnit");
			this.comboUnit.Name = "comboUnit";
			this.comboUnit.SelectedIndexChanged += new System.EventHandler(this.ComboUnit_SelectedIndexChanged);
			// 
			// truckCodeBodx1
			// 
			this.truckCodeBodx1.FirstNumberTextBox = null;
			resources.ApplyResources(this.truckCodeBodx1, "truckCodeBodx1");
			this.truckCodeBodx1.Name = "truckCodeBodx1";
			this.truckCodeBodx1.txtCodeChars = "";
			this.truckCodeBodx1.txtCodeDigits = "";
			// 
			// labErrorMessage
			// 
			resources.ApplyResources(this.labErrorMessage, "labErrorMessage");
			this.labErrorMessage.ForeColor = System.Drawing.Color.OrangeRed;
			this.labErrorMessage.Name = "labErrorMessage";
			// 
			// ImportView
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.MainTabe);
			this.MaximizeBox = false;
			this.Name = "ImportView";
			this.MainTabe.ResumeLayout(false);
			this.importExcelTP.ResumeLayout(false);
			this.importExcelTP.PerformLayout();
			this.importMultTP.ResumeLayout(false);
			this.importMultTP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumTrucksCount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private TabControl MainTabe;
		private TabPage importExcelTP;
		private TabPage importMultTP;
		private Button btnChooseFile;
		private Label labFileName;
		private ProgressBar progressBar1;
		private Label labPresantage;
		private Label labCurrentCar;
		private Label labRowsCount;
		private ViolationsCollecting.View.CustomeComponants.TruckCodeBodx truckCodeBodx1;
		private ComboBox comboUnit;
		private ComboBox comboElManfaz;
		private Button btnRegist;
		private NumericUpDown NumTrucksCount;
		private ViolationsCollecting.View.CustomeComponants.DateBox dateBox1;
		private Label label1;
		private ViolationsCollecting.View.CustomeComponants.DateBox dateBox2;
		private Label label2;
		private Label labErrorMessage;
	}
}
