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
			this.panel3 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.PyD_M = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.BDateD_M = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.VDateD_M = new System.Windows.Forms.RadioButton();
			this.VDateM_D = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.MainTabe.SuspendLayout();
			this.importExcelTP.SuspendLayout();
			this.AdvancedSettingTP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StartIngRow)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.AdvancedSettingTP.Controls.Add(this.panel3);
			this.AdvancedSettingTP.Controls.Add(this.panel2);
			this.AdvancedSettingTP.Controls.Add(this.panel1);
			this.AdvancedSettingTP.Controls.Add(this.label1);
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
			// panel3
			// 
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.PyD_M);
			this.panel3.Controls.Add(this.radioButton4);
			resources.ApplyResources(this.panel3, "panel3");
			this.panel3.Name = "panel3";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// PyD_M
			// 
			resources.ApplyResources(this.PyD_M, "PyD_M");
			this.PyD_M.Checked = true;
			this.PyD_M.Name = "PyD_M";
			this.PyD_M.TabStop = true;
			this.PyD_M.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			resources.ApplyResources(this.radioButton4, "radioButton4");
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.BDateD_M);
			this.panel2.Controls.Add(this.radioButton2);
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Name = "panel2";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// BDateD_M
			// 
			resources.ApplyResources(this.BDateD_M, "BDateD_M");
			this.BDateD_M.Checked = true;
			this.BDateD_M.Name = "BDateD_M";
			this.BDateD_M.TabStop = true;
			this.BDateD_M.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			resources.ApplyResources(this.radioButton2, "radioButton2");
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.VDateD_M);
			this.panel1.Controls.Add(this.VDateM_D);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// VDateD_M
			// 
			resources.ApplyResources(this.VDateD_M, "VDateD_M");
			this.VDateD_M.Name = "VDateD_M";
			this.VDateD_M.UseVisualStyleBackColor = true;
			// 
			// VDateM_D
			// 
			resources.ApplyResources(this.VDateM_D, "VDateM_D");
			this.VDateM_D.Checked = true;
			this.VDateM_D.Name = "VDateM_D";
			this.VDateM_D.TabStop = true;
			this.VDateM_D.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
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
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
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
		private Label label1;
		private RadioButton VDateM_D;
		private RadioButton VDateD_M;
		private Label label3;
		private Panel panel3;
		private Label label4;
		private RadioButton PyD_M;
		private RadioButton radioButton4;
		private Panel panel2;
		private Label label2;
		private RadioButton BDateD_M;
		private RadioButton radioButton2;
		private Panel panel1;
		private NumericUpDown StartIngRow;
		private Label label5;
		private CheckBox checkOriginalFile;
	}
}
