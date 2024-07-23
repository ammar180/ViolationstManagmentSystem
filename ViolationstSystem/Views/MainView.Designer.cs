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
			this.violationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sendTrafficTP = new System.Windows.Forms.TabPage();
			this.homeTP = new System.Windows.Forms.TabPage();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.SettingTP = new System.Windows.Forms.TabPage();
			this.AdminLoginTP = new System.Windows.Forms.TabPage();
			this.homeView1 = new ViolationsSystem.Views.HomeView();
			this.sendTrafficView1 = new ViolationsSystem.Views.SendTrafficView();
			this.adminLogin1 = new ViolationstSystem.Views.AdminLogin();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).BeginInit();
			this.sendTrafficTP.SuspendLayout();
			this.homeTP.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.AdminLoginTP.SuspendLayout();
			this.SuspendLayout();
			// 
			// sendTrafficTP
			// 
			this.sendTrafficTP.Controls.Add(this.sendTrafficView1);
			resources.ApplyResources(this.sendTrafficTP, "sendTrafficTP");
			this.sendTrafficTP.Name = "sendTrafficTP";
			this.sendTrafficTP.UseVisualStyleBackColor = true;
			// 
			// homeTP
			// 
			this.homeTP.Controls.Add(this.homeView1);
			resources.ApplyResources(this.homeTP, "homeTP");
			this.homeTP.Name = "homeTP";
			this.homeTP.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.homeTP);
			this.tabControl1.Controls.Add(this.sendTrafficTP);
			this.tabControl1.Controls.Add(this.SettingTP);
			this.tabControl1.Controls.Add(this.AdminLoginTP);
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			// 
			// SettingTP
			// 
			resources.ApplyResources(this.SettingTP, "SettingTP");
			this.SettingTP.Name = "SettingTP";
			this.SettingTP.UseVisualStyleBackColor = true;
			// 
			// AdminLoginTP
			// 
			this.AdminLoginTP.Controls.Add(this.adminLogin1);
			resources.ApplyResources(this.AdminLoginTP, "AdminLoginTP");
			this.AdminLoginTP.Name = "AdminLoginTP";
			this.AdminLoginTP.UseVisualStyleBackColor = true;
			// 
			// homeView1
			// 
			resources.ApplyResources(this.homeView1, "homeView1");
			this.homeView1.Name = "homeView1";
			// 
			// sendTrafficView1
			// 
			resources.ApplyResources(this.sendTrafficView1, "sendTrafficView1");
			this.sendTrafficView1.Name = "sendTrafficView1";
			// 
			// adminLogin1
			// 
			resources.ApplyResources(this.adminLogin1, "adminLogin1");
			this.adminLogin1.Name = "adminLogin1";
			this.adminLogin1.Password = null;
			this.adminLogin1.UserName = null;
			// 
			// MainView
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.HelpButton = true;
			this.Name = "MainView";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).EndInit();
			this.sendTrafficTP.ResumeLayout(false);
			this.homeTP.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.AdminLoginTP.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private BindingSource violationBindingSource;
		private TabPage sendTrafficTP;
		private TabPage homeTP;
		private TabControl tabControl1;
		private TabPage SettingTP;
		private Views.SendTrafficView sendTrafficView1;
		private Views.HomeView homeView1;
		private TabPage AdminLoginTP;
		private ViolationstSystem.Views.AdminLogin adminLogin1;
	}
}
