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
			this.flowLayoutPanelNavBar = new System.Windows.Forms.FlowLayoutPanel();
			this.btnMainScreen = new System.Windows.Forms.Button();
			this.btnSendTraffic = new System.Windows.Forms.Button();
			this.btnSearchRecord = new System.Windows.Forms.Button();
			this.btnManageData = new System.Windows.Forms.Button();
			this.btnTeamplets = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.panelContainer = new System.Windows.Forms.Panel();
			this.violationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.flowLayoutPanelNavBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanelNavBar
			// 
			this.flowLayoutPanelNavBar.Controls.Add(this.btnMainScreen);
			this.flowLayoutPanelNavBar.Controls.Add(this.btnSendTraffic);
			this.flowLayoutPanelNavBar.Controls.Add(this.btnSearchRecord);
			this.flowLayoutPanelNavBar.Controls.Add(this.btnManageData);
			this.flowLayoutPanelNavBar.Controls.Add(this.btnTeamplets);
			this.flowLayoutPanelNavBar.Controls.Add(this.btnSettings);
			resources.ApplyResources(this.flowLayoutPanelNavBar, "flowLayoutPanelNavBar");
			this.flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
			// 
			// btnMainScreen
			// 
			this.btnMainScreen.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.btnMainScreen, "btnMainScreen");
			this.btnMainScreen.Image = global::ViolationstSystem.Properties.Resources.Home_1;
			this.btnMainScreen.Name = "btnMainScreen";
			this.toolTip1.SetToolTip(this.btnMainScreen, resources.GetString("btnMainScreen.ToolTip"));
			this.btnMainScreen.UseVisualStyleBackColor = true;
			// 
			// btnSendTraffic
			// 
			this.btnSendTraffic.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.btnSendTraffic, "btnSendTraffic");
			this.btnSendTraffic.Image = global::ViolationstSystem.Properties.Resources.List_View_1;
			this.btnSendTraffic.Name = "btnSendTraffic";
			this.toolTip1.SetToolTip(this.btnSendTraffic, resources.GetString("btnSendTraffic.ToolTip"));
			this.btnSendTraffic.UseVisualStyleBackColor = true;
			// 
			// btnSearchRecord
			// 
			this.btnSearchRecord.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.btnSearchRecord, "btnSearchRecord");
			this.btnSearchRecord.Image = global::ViolationstSystem.Properties.Resources.Search_Property_3;
			this.btnSearchRecord.Name = "btnSearchRecord";
			this.btnSearchRecord.UseVisualStyleBackColor = true;
			// 
			// btnManageData
			// 
			this.btnManageData.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.btnManageData, "btnManageData");
			this.btnManageData.Image = global::ViolationstSystem.Properties.Resources.Create_3;
			this.btnManageData.Name = "btnManageData";
			this.btnManageData.UseVisualStyleBackColor = true;
			// 
			// btnTeamplets
			// 
			this.btnTeamplets.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.btnTeamplets, "btnTeamplets");
			this.btnTeamplets.Image = global::ViolationstSystem.Properties.Resources.Template_1;
			this.btnTeamplets.Name = "btnTeamplets";
			this.btnTeamplets.UseVisualStyleBackColor = true;
			// 
			// btnSettings
			// 
			this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.btnSettings, "btnSettings");
			this.btnSettings.Image = global::ViolationstSystem.Properties.Resources.Settings_1;
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.UseVisualStyleBackColor = true;
			// 
			// panelContainer
			// 
			this.panelContainer.BackColor = System.Drawing.Color.White;
			resources.ApplyResources(this.panelContainer, "panelContainer");
			this.panelContainer.Name = "panelContainer";
			// 
			// MainView
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelContainer);
			this.Controls.Add(this.flowLayoutPanelNavBar);
			this.HelpButton = true;
			this.Name = "MainView";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.flowLayoutPanelNavBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private FlowLayoutPanel flowLayoutPanelNavBar;
		private Button btnMainScreen;
		private BindingSource violationBindingSource;
		private Button btnSendTraffic;
		private Button btnSearchRecord;
		private Button btnManageData;
		private Button btnTeamplets;
		public Panel panelContainer;
		private ToolTip toolTip1;
		private Button btnSettings;
	}
}
