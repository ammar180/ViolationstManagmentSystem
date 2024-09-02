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
			this.labErrorMessage = new System.Windows.Forms.Label();
			this.labRowsCount = new System.Windows.Forms.Label();
			this.labCurrentCar = new System.Windows.Forms.Label();
			this.labPresantage = new System.Windows.Forms.Label();
			this.labFileName = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnChooseFile = new System.Windows.Forms.Button();
			this.AdvancedSettingTP = new System.Windows.Forms.TabPage();
			this.checkOriginalFile = new System.Windows.Forms.CheckBox();
			this.StartIngRow = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.MainTabe.SuspendLayout();
			this.importExcelTP.SuspendLayout();
			this.AdvancedSettingTP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StartIngRow)).BeginInit();
			this.SuspendLayout();
			// 
			// MainTabe
			// 
			this.MainTabe.Controls.Add(this.importExcelTP);
			this.MainTabe.Controls.Add(this.AdvancedSettingTP);
			resources.ApplyResources(this.MainTabe, "MainTabe");
			this.MainTabe.Name = "MainTabe";
			this.MainTabe.SelectedIndex = 0;
			// 
			// importExcelTP
			// 
			this.importExcelTP.Controls.Add(this.labErrorMessage);
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
			// labErrorMessage
			// 
			resources.ApplyResources(this.labErrorMessage, "labErrorMessage");
			this.labErrorMessage.ForeColor = System.Drawing.Color.OrangeRed;
			this.labErrorMessage.Name = "labErrorMessage";
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
			// AdvancedSettingTP
			// 
			this.AdvancedSettingTP.Controls.Add(this.checkOriginalFile);
			this.AdvancedSettingTP.Controls.Add(this.StartIngRow);
			this.AdvancedSettingTP.Controls.Add(this.label5);
			resources.ApplyResources(this.AdvancedSettingTP, "AdvancedSettingTP");
			this.AdvancedSettingTP.Name = "AdvancedSettingTP";
			this.AdvancedSettingTP.UseVisualStyleBackColor = true;
			// 
			// checkOriginalFile
			// 
			resources.ApplyResources(this.checkOriginalFile, "checkOriginalFile");
			this.checkOriginalFile.Name = "checkOriginalFile";
			this.checkOriginalFile.UseVisualStyleBackColor = true;
			this.checkOriginalFile.CheckedChanged += new System.EventHandler(this.checkOriginalFile_CheckedChanged);
			// 
			// StartIngRow
			// 
			resources.ApplyResources(this.StartIngRow, "StartIngRow");
			this.StartIngRow.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
			this.StartIngRow.Name = "StartIngRow";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
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
			this.AdvancedSettingTP.ResumeLayout(false);
			this.AdvancedSettingTP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.StartIngRow)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private TabControl MainTabe;
		private TabPage importExcelTP;
		private Button btnChooseFile;
		private Label labFileName;
		private ProgressBar progressBar1;
		private Label labPresantage;
		private Label labCurrentCar;
		private Label labRowsCount;
		private Label labErrorMessage;
		private TabPage AdvancedSettingTP;
		private NumericUpDown StartIngRow;
		private Label label5;
		private CheckBox checkOriginalFile;
	}
}
