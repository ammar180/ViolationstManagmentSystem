using System.Drawing;
using System.Windows.Forms;
namespace ViolationsSystem
{
	partial class MainView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
			this.sendTrafficTP = new System.Windows.Forms.TabPage();
			this.sendTrafficView1 = new ViolationsSystem.Views.SendTrafficView();
			this.homeTP = new System.Windows.Forms.TabPage();
			this.homeView1 = new ViolationsSystem.Views.HomeView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.AdminTP = new System.Windows.Forms.TabPage();
			this.adminLogin1 = new ViolationstSystem.Views.AdminLogin();
			this.SettingTP = new System.Windows.Forms.TabPage();
			this.labCurrentVersion = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.radioBtnLocal = new System.Windows.Forms.RadioButton();
			this.radioBtnTCP = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.sendTrafficTP.SuspendLayout();
			this.homeTP.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.AdminTP.SuspendLayout();
			this.SettingTP.SuspendLayout();
			this.SuspendLayout();
			// 
			// sendTrafficTP
			// 
			this.sendTrafficTP.Controls.Add(this.sendTrafficView1);
			resources.ApplyResources(this.sendTrafficTP, "sendTrafficTP");
			this.sendTrafficTP.Name = "sendTrafficTP";
			this.sendTrafficTP.UseVisualStyleBackColor = true;
			// 
			// sendTrafficView1
			// 
			resources.ApplyResources(this.sendTrafficView1, "sendTrafficView1");
			this.sendTrafficView1.Name = "sendTrafficView1";
			// 
			// homeTP
			// 
			this.homeTP.Controls.Add(this.homeView1);
			resources.ApplyResources(this.homeTP, "homeTP");
			this.homeTP.Name = "homeTP";
			this.homeTP.UseVisualStyleBackColor = true;
			// 
			// homeView1
			// 
			this.homeView1.DeletedViolations = ((System.Collections.Generic.List<ViolationSystem.Data.Entities.Violation>)(resources.GetObject("homeView1.DeletedViolations")));
			resources.ApplyResources(this.homeView1, "homeView1");
			this.homeView1.dublicatedDateCode = null;
			this.homeView1.ExploredCodesOfTrucks = null;
			this.homeView1.ModifiedViolations = ((System.Collections.Generic.List<ViolationSystem.Data.Entities.Violation>)(resources.GetObject("homeView1.ModifiedViolations")));
			this.homeView1.Name = "homeView1";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.homeTP);
			this.tabControl1.Controls.Add(this.sendTrafficTP);
			this.tabControl1.Controls.Add(this.AdminTP);
			this.tabControl1.Controls.Add(this.SettingTP);
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			// 
			// AdminTP
			// 
			this.AdminTP.Controls.Add(this.adminLogin1);
			resources.ApplyResources(this.AdminTP, "AdminTP");
			this.AdminTP.Name = "AdminTP";
			this.AdminTP.UseVisualStyleBackColor = true;
			// 
			// adminLogin1
			// 
			resources.ApplyResources(this.adminLogin1, "adminLogin1");
			this.adminLogin1.Name = "adminLogin1";
			this.adminLogin1.Password = null;
			this.adminLogin1.UserName = null;
			// 
			// SettingTP
			// 
			this.SettingTP.Controls.Add(this.label1);
			this.SettingTP.Controls.Add(this.labCurrentVersion);
			this.SettingTP.Controls.Add(this.btnUpdate);
			this.SettingTP.Controls.Add(this.btnOk);
			this.SettingTP.Controls.Add(this.radioBtnLocal);
			this.SettingTP.Controls.Add(this.radioBtnTCP);
			resources.ApplyResources(this.SettingTP, "SettingTP");
			this.SettingTP.Name = "SettingTP";
			this.SettingTP.UseVisualStyleBackColor = true;
			// 
			// labCurrentVersion
			// 
			resources.ApplyResources(this.labCurrentVersion, "labCurrentVersion");
			this.labCurrentVersion.Name = "labCurrentVersion";
			// 
			// btnUpdate
			// 
			resources.ApplyResources(this.btnUpdate, "btnUpdate");
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnOk
			// 
			resources.ApplyResources(this.btnOk, "btnOk");
			this.btnOk.Name = "btnOk";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// radioBtnLocal
			// 
			resources.ApplyResources(this.radioBtnLocal, "radioBtnLocal");
			this.radioBtnLocal.Name = "radioBtnLocal";
			this.radioBtnLocal.UseVisualStyleBackColor = true;
			// 
			// radioBtnTCP
			// 
			resources.ApplyResources(this.radioBtnTCP, "radioBtnTCP");
			this.radioBtnTCP.Name = "radioBtnTCP";
			this.radioBtnTCP.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// MainView
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.HelpButton = true;
			this.Name = "MainView";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.sendTrafficTP.ResumeLayout(false);
			this.homeTP.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.AdminTP.ResumeLayout(false);
			this.SettingTP.ResumeLayout(false);
			this.SettingTP.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private TabPage sendTrafficTP;
		private TabPage homeTP;
		private TabControl tabControl1;
		private TabPage SettingTP;
		private Views.SendTrafficView sendTrafficView1;
		private Views.HomeView homeView1;
		private RadioButton radioBtnLocal;
		private RadioButton radioBtnTCP;
		private Button btnOk;
		private TabPage AdminTP;
		private ViolationstSystem.Views.AdminLogin adminLogin1;
		private Button btnUpdate;
		private Label labCurrentVersion;
		private Label label1;
	}
}
