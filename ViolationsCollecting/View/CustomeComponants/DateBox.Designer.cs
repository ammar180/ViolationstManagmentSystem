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
			DateGroupBox = new GroupBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			label1 = new Label();
			YearNum = new NumericUpDown();
			label2 = new Label();
			MonthNum = new NumericUpDown();
			label3 = new Label();
			DayNum = new NumericUpDown();
			DateGroupBox.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)YearNum).BeginInit();
			((System.ComponentModel.ISupportInitialize)MonthNum).BeginInit();
			((System.ComponentModel.ISupportInitialize)DayNum).BeginInit();
			SuspendLayout();
			// 
			// DateGroupBox
			// 
			DateGroupBox.Controls.Add(flowLayoutPanel1);
			DateGroupBox.Dock = DockStyle.Top;
			DateGroupBox.Location = new Point(0, 0);
			DateGroupBox.Margin = new Padding(2, 3, 2, 3);
			DateGroupBox.Name = "DateGroupBox";
			DateGroupBox.Padding = new Padding(2, 3, 2, 3);
			DateGroupBox.Size = new Size(516, 93);
			DateGroupBox.TabIndex = 5;
			DateGroupBox.TabStop = false;
			DateGroupBox.Text = "التاريخ {يوم / شهر / سنه}";
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(label1);
			flowLayoutPanel1.Controls.Add(YearNum);
			flowLayoutPanel1.Controls.Add(label2);
			flowLayoutPanel1.Controls.Add(MonthNum);
			flowLayoutPanel1.Controls.Add(label3);
			flowLayoutPanel1.Controls.Add(DayNum);
			flowLayoutPanel1.Dock = DockStyle.Right;
			flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
			flowLayoutPanel1.Location = new Point(179, 35);
			flowLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(335, 55);
			flowLayoutPanel1.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Cairo", 15F);
			label1.Location = new Point(2, 0);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(48, 47);
			label1.TabIndex = 0;
			label1.Text = "20";
			// 
			// YearNum
			// 
			YearNum.Location = new Point(54, 3);
			YearNum.Margin = new Padding(2, 3, 2, 3);
			YearNum.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
			YearNum.Name = "YearNum";
			YearNum.RightToLeft = RightToLeft.No;
			YearNum.Size = new Size(61, 39);
			YearNum.TabIndex = 2;
			YearNum.TextAlign = HorizontalAlignment.Center;
			YearNum.Value = new decimal(new int[] { 24, 0, 0, 0 });
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Cairo", 16F);
			label2.Location = new Point(119, 0);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(33, 50);
			label2.TabIndex = 2;
			label2.Text = "/";
			// 
			// MonthNum
			// 
			MonthNum.Location = new Point(156, 3);
			MonthNum.Margin = new Padding(2, 3, 2, 3);
			MonthNum.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
			MonthNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			MonthNum.Name = "MonthNum";
			MonthNum.RightToLeft = RightToLeft.No;
			MonthNum.Size = new Size(61, 39);
			MonthNum.TabIndex = 1;
			MonthNum.TextAlign = HorizontalAlignment.Center;
			MonthNum.Value = new decimal(new int[] { 7, 0, 0, 0 });
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Cairo", 16F);
			label3.Location = new Point(221, 0);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(33, 50);
			label3.TabIndex = 3;
			label3.Text = "/";
			// 
			// DayNum
			// 
			DayNum.Location = new Point(258, 3);
			DayNum.Margin = new Padding(2, 3, 2, 3);
			DayNum.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
			DayNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			DayNum.Name = "DayNum";
			DayNum.RightToLeft = RightToLeft.No;
			DayNum.Size = new Size(61, 39);
			DayNum.TabIndex = 0;
			DayNum.TextAlign = HorizontalAlignment.Center;
			DayNum.Value = new decimal(new int[] { 7, 0, 0, 0 });
			// 
			// DateBox
			// 
			AutoScaleDimensions = new SizeF(9F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(DateGroupBox);
			Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(3, 5, 3, 5);
			Name = "DateBox";
			RightToLeft = RightToLeft.Yes;
			Size = new Size(516, 100);
			DateGroupBox.ResumeLayout(false);
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)YearNum).EndInit();
			((System.ComponentModel.ISupportInitialize)MonthNum).EndInit();
			((System.ComponentModel.ISupportInitialize)DayNum).EndInit();
			ResumeLayout(false);
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
