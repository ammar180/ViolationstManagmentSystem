using System;
using System.Drawing;
using System.Windows.Forms;

namespace ViolationsSystem.Views
{
	partial class SendTrafficView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.countTrucks = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.comboUnits = new System.Windows.Forms.ComboBox();
			this.lable3 = new System.Windows.Forms.Label();
			this.btnGetResult = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.dateBox1 = new ViolationsCollecting.View.CustomeComponants.DateBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.countTrucks)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
			this.flowLayoutPanel1.Controls.Add(this.lable3);
			this.flowLayoutPanel1.Controls.Add(this.dateBox1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1011, 109);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.Controls.Add(this.label1);
			this.flowLayoutPanel2.Controls.Add(this.countTrucks);
			this.flowLayoutPanel2.Controls.Add(this.label2);
			this.flowLayoutPanel2.Controls.Add(this.comboUnits);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(568, 12);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(426, 51);
			this.flowLayoutPanel2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(299, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "عدد الشاحنات";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// countTrucks
			// 
			this.countTrucks.Location = new System.Drawing.Point(209, 0);
			this.countTrucks.Margin = new System.Windows.Forms.Padding(0);
			this.countTrucks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.countTrucks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.countTrucks.Name = "countTrucks";
			this.countTrucks.Size = new System.Drawing.Size(90, 45);
			this.countTrucks.TabIndex = 7;
			this.countTrucks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.countTrucks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(131, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 51);
			this.label2.TabIndex = 8;
			this.label2.Text = "الوحدة";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboUnits
			// 
			this.comboUnits.AutoCompleteCustomSource.AddRange(new string[] {
            "كرداسة",
            "البدرشين",
            "الصف",
            "العياط",
            "منشاة القناطر",
            "ابو نمرس",
            "الواحات البحرية",
            "اطفيح",
            "اكتوبر"});
			this.comboUnits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboUnits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.comboUnits.FormattingEnabled = true;
			this.comboUnits.Items.AddRange(new object[] {
            "كرداسة",
            "البدرشين",
            "الصف",
            "العياط",
            "منشاة القناطر",
            "ابو نمرس",
            "الواحات البحرية",
            "اطفيح",
            "اكتوبر"});
			this.comboUnits.Location = new System.Drawing.Point(3, 3);
			this.comboUnits.Name = "comboUnits";
			this.comboUnits.Size = new System.Drawing.Size(121, 45);
			this.comboUnits.TabIndex = 9;
			this.comboUnits.Text = "كرداسة";
			// 
			// lable3
			// 
			this.lable3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lable3.AutoSize = true;
			this.lable3.Location = new System.Drawing.Point(427, 9);
			this.lable3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lable3.Name = "lable3";
			this.lable3.Size = new System.Drawing.Size(134, 91);
			this.lable3.TabIndex = 3;
			this.lable3.Text = "التاريخ المبدأي";
			this.lable3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGetResult
			// 
			this.btnGetResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnGetResult.Image = global::ViolationstSystem.Properties.Resources.Search_1;
			this.btnGetResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGetResult.Location = new System.Drawing.Point(30, 10);
			this.btnGetResult.Margin = new System.Windows.Forms.Padding(0);
			this.btnGetResult.Name = "btnGetResult";
			this.btnGetResult.Size = new System.Drawing.Size(951, 54);
			this.btnGetResult.TabIndex = 6;
			this.btnGetResult.Text = "احصل على النتيجة";
			this.btnGetResult.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnGetResult);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 109);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
			this.panel3.Size = new System.Drawing.Size(1011, 74);
			this.panel3.TabIndex = 7;
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.flowLayoutPanel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1011, 183);
			this.panel2.TabIndex = 4;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.reportViewer);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 183);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1011, 497);
			this.panel4.TabIndex = 5;
			// 
			// reportViewer
			// 
			this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reportViewer.LocalReport.ReportEmbeddedResource = "ViolationstSystem.Reports.TrafficReport.rdlc";
			this.reportViewer.Location = new System.Drawing.Point(0, 0);
			this.reportViewer.Name = "reportViewer";
			this.reportViewer.ServerReport.BearerToken = null;
			this.reportViewer.Size = new System.Drawing.Size(1011, 497);
			this.reportViewer.TabIndex = 1;
			// 
			// dateBox1
			// 
			this.dateBox1.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateBox1.Location = new System.Drawing.Point(19, 14);
			this.dateBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.dateBox1.Name = "dateBox1";
			this.dateBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateBox1.Size = new System.Drawing.Size(401, 81);
			this.dateBox1.TabIndex = 4;
			// 
			// SendTrafficView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Name = "SendTrafficView";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(1011, 680);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.countTrucks)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private Label label1;
		private TextBox CountTrucks;
		private Label lable3;
		private Button btnGetResult;
		private NumericUpDown countTrucks;
		private FlowLayoutPanel flowLayoutPanel2;
		private Panel panel3;
		private Panel panel2;
		private Panel panel4;
		private ComboBox comboUnits;
		private Label label2;
		public Microsoft.Reporting.WinForms.ReportViewer reportViewer;
		private ViolationsCollecting.View.CustomeComponants.DateBox dateBox1;
	}
}
