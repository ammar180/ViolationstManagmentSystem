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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportView));
			this.MainTabe = new System.Windows.Forms.TabControl();
			this.importExcelTP = new System.Windows.Forms.TabPage();
			this.labErrorMessage = new System.Windows.Forms.Label();
			this.radioNewForm = new System.Windows.Forms.RadioButton();
			this.radioOldForm = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.labRowsCount = new System.Windows.Forms.Label();
			this.labCurrentCar = new System.Windows.Forms.Label();
			this.labPresantage = new System.Windows.Forms.Label();
			this.labFileName = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnChooseFile = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.MainTabe.SuspendLayout();
			this.importExcelTP.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTabe
			// 
			this.MainTabe.Controls.Add(this.importExcelTP);
			resources.ApplyResources(this.MainTabe, "MainTabe");
			this.MainTabe.Name = "MainTabe";
			this.MainTabe.SelectedIndex = 0;
			// 
			// importExcelTP
			// 
			this.importExcelTP.Controls.Add(this.labErrorMessage);
			this.importExcelTP.Controls.Add(this.radioNewForm);
			this.importExcelTP.Controls.Add(this.radioOldForm);
			this.importExcelTP.Controls.Add(this.label3);
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
			this.labErrorMessage.Name = "labErrorMessage";
			// 
			// radioNewForm
			// 
			resources.ApplyResources(this.radioNewForm, "radioNewForm");
			this.radioNewForm.Checked = true;
			this.radioNewForm.Name = "radioNewForm";
			this.radioNewForm.TabStop = true;
			this.toolTip1.SetToolTip(this.radioNewForm, resources.GetString("radioNewForm.ToolTip"));
			this.radioNewForm.UseVisualStyleBackColor = true;
			// 
			// radioOldForm
			// 
			resources.ApplyResources(this.radioOldForm, "radioOldForm");
			this.radioOldForm.Name = "radioOldForm";
			this.toolTip1.SetToolTip(this.radioOldForm, resources.GetString("radioOldForm.ToolTip"));
			this.radioOldForm.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
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
		private Label label3;
		private RadioButton radioNewForm;
		private ToolTip toolTip1;
		private RadioButton radioOldForm;
		private Label labErrorMessage;
	}
}
