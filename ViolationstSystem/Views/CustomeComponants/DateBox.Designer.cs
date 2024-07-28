using System.Drawing;
using System.Windows.Forms;

namespace ViolationsCollecting.View.CustomeComponants
{
	partial class DateBox
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
			this.DateGroupBox = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.YearNum = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.MonthNum = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.DayNum = new System.Windows.Forms.NumericUpDown();
			this.DateGroupBox.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.YearNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MonthNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DayNum)).BeginInit();
			this.SuspendLayout();
			// 
			// DateGroupBox
			// 
			this.DateGroupBox.Controls.Add(this.flowLayoutPanel1);
			this.DateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DateGroupBox.Location = new System.Drawing.Point(0, 0);
			this.DateGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.DateGroupBox.Name = "DateGroupBox";
			this.DateGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.DateGroupBox.Size = new System.Drawing.Size(337, 87);
			this.DateGroupBox.TabIndex = 5;
			this.DateGroupBox.TabStop = false;
			this.DateGroupBox.Text = "التاريخ {يوم / شهر / سنه}";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.YearNum);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.MonthNum);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.DayNum);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 35);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(322, 49);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cairo", 12.2F);
			this.label1.Location = new System.Drawing.Point(2, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "20";
			// 
			// YearNum
			// 
			this.YearNum.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.YearNum.Location = new System.Drawing.Point(47, 3);
			this.YearNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.YearNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.YearNum.Name = "YearNum";
			this.YearNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.YearNum.Size = new System.Drawing.Size(61, 39);
			this.YearNum.TabIndex = 2;
			this.YearNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.YearNum.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(112, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "/";
			// 
			// MonthNum
			// 
			this.MonthNum.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MonthNum.Location = new System.Drawing.Point(137, 3);
			this.MonthNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MonthNum.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.MonthNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.MonthNum.Name = "MonthNum";
			this.MonthNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.MonthNum.Size = new System.Drawing.Size(61, 39);
			this.MonthNum.TabIndex = 1;
			this.MonthNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MonthNum.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(202, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 32);
			this.label3.TabIndex = 3;
			this.label3.Text = "/";
			// 
			// DayNum
			// 
			this.DayNum.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DayNum.Location = new System.Drawing.Point(227, 3);
			this.DayNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.DayNum.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
			this.DayNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.DayNum.Name = "DayNum";
			this.DayNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.DayNum.Size = new System.Drawing.Size(61, 39);
			this.DayNum.TabIndex = 0;
			this.DayNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.DayNum.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
			// 
			// DateBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.DateGroupBox);
			this.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.Name = "DateBox";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(337, 87);
			this.DateGroupBox.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.YearNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MonthNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DayNum)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox DateGroupBox;
		private FlowLayoutPanel flowLayoutPanel1;
		private Label label1;
		private NumericUpDown YearNum;
		private Label label2;
		private NumericUpDown MonthNum;
		private Label label3;
		private NumericUpDown DayNum;
	}
}
