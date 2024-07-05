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
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			flowLayoutPanel1 = new FlowLayoutPanel();
			label1 = new Label();
			countTrucks = new NumericUpDown();
			flowLayoutPanel2 = new FlowLayoutPanel();
			lable3 = new Label();
			dateStart = new DateTimePicker();
			flowLayoutPanel3 = new FlowLayoutPanel();
			label3 = new Label();
			dateEnd = new DateTimePicker();
			btnGetResult = new Button();
			dataGridView = new DataGridView();
			N = new DataGridViewTextBoxColumn();
			TruckCode = new DataGridViewTextBoxColumn();
			Notes = new DataGridViewTextBoxColumn();
			panel1 = new Panel();
			btnPrint = new Button();
			panel3 = new Panel();
			panel2 = new Panel();
			panel4 = new Panel();
			flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)countTrucks).BeginInit();
			flowLayoutPanel2.SuspendLayout();
			flowLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
			panel1.SuspendLayout();
			panel3.SuspendLayout();
			panel2.SuspendLayout();
			panel4.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoScroll = true;
			flowLayoutPanel1.AutoSize = true;
			flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
			flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
			flowLayoutPanel1.Dock = DockStyle.Top;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Margin = new Padding(4, 6, 4, 6);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Padding = new Padding(7, 9, 7, 9);
			flowLayoutPanel1.Size = new Size(852, 144);
			flowLayoutPanel1.TabIndex = 1;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(582, 0);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(127, 57);
			label1.TabIndex = 0;
			label1.Text = "عدد الشاحنات";
			label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// countTrucks
			// 
			countTrucks.Location = new Point(492, 0);
			countTrucks.Margin = new Padding(0);
			countTrucks.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			countTrucks.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			countTrucks.Name = "countTrucks";
			countTrucks.Size = new Size(90, 45);
			countTrucks.TabIndex = 7;
			countTrucks.TextAlign = HorizontalAlignment.Center;
			countTrucks.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			flowLayoutPanel2.AutoSize = true;
			flowLayoutPanel2.Controls.Add(label1);
			flowLayoutPanel2.Controls.Add(countTrucks);
			flowLayoutPanel2.Controls.Add(lable3);
			flowLayoutPanel2.Controls.Add(dateStart);
			flowLayoutPanel2.Location = new Point(126, 12);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new Size(709, 57);
			flowLayoutPanel2.TabIndex = 3;
			// 
			// lable3
			// 
			lable3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			lable3.AutoSize = true;
			lable3.Location = new Point(354, 0);
			lable3.Margin = new Padding(4, 0, 4, 0);
			lable3.Name = "lable3";
			lable3.Size = new Size(134, 57);
			lable3.TabIndex = 3;
			lable3.Text = "التاريخ المبدأي";
			lable3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// dateStart
			// 
			dateStart.Location = new Point(4, 6);
			dateStart.Margin = new Padding(4, 6, 4, 6);
			dateStart.Name = "dateStart";
			dateStart.RightToLeft = RightToLeft.Yes;
			dateStart.Size = new Size(342, 45);
			dateStart.TabIndex = 2;
			// 
			// flowLayoutPanel3
			// 
			flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			flowLayoutPanel3.AutoSize = true;
			flowLayoutPanel3.Controls.Add(label3);
			flowLayoutPanel3.Controls.Add(dateEnd);
			flowLayoutPanel3.Location = new Point(354, 75);
			flowLayoutPanel3.Name = "flowLayoutPanel3";
			flowLayoutPanel3.Size = new Size(481, 57);
			flowLayoutPanel3.TabIndex = 4;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			label3.AutoSize = true;
			label3.Location = new Point(353, 0);
			label3.Margin = new Padding(0);
			label3.Name = "label3";
			label3.Size = new Size(128, 57);
			label3.TabIndex = 5;
			label3.Text = "التاريخ النهائي";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// dateEnd
			// 
			dateEnd.CustomFormat = "dd/MM/yyyy";
			dateEnd.Location = new Point(4, 6);
			dateEnd.Margin = new Padding(4, 6, 4, 6);
			dateEnd.Name = "dateEnd";
			dateEnd.RightToLeft = RightToLeft.Yes;
			dateEnd.Size = new Size(345, 45);
			dateEnd.TabIndex = 4;
			dateEnd.Value = new DateTime(2024, 6, 24, 23, 59, 59, 0);
			// 
			// btnGetResult
			// 
			btnGetResult.Dock = DockStyle.Fill;
			btnGetResult.Image = ViolationstSystem.Properties.Resources.Search_1;
			btnGetResult.ImageAlign = ContentAlignment.MiddleLeft;
			btnGetResult.Location = new Point(30, 10);
			btnGetResult.Margin = new Padding(0);
			btnGetResult.Name = "btnGetResult";
			btnGetResult.Size = new Size(792, 54);
			btnGetResult.TabIndex = 6;
			btnGetResult.Text = "احصل على النتيجة";
			btnGetResult.UseVisualStyleBackColor = true;
			// 
			// dataGridView
			// 
			dataGridView.AllowUserToAddRows = false;
			dataGridView.AllowUserToDeleteRows = false;
			dataGridView.BackgroundColor = Color.White;
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = SystemColors.ScrollBar;
			dataGridViewCellStyle9.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView.Columns.AddRange(new DataGridViewColumn[] { N, TruckCode, Notes });
			dataGridView.Dock = DockStyle.Fill;
			dataGridView.GridColor = SystemColors.ActiveCaptionText;
			dataGridView.Location = new Point(0, 0);
			dataGridView.Name = "dataGridView";
			dataGridView.ReadOnly = true;
			dataGridView.RowHeadersWidth = 51;
			dataGridView.Size = new Size(852, 387);
			dataGridView.TabIndex = 2;
			// 
			// N
			// 
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
			N.DefaultCellStyle = dataGridViewCellStyle10;
			N.HeaderText = "م";
			N.MinimumWidth = 20;
			N.Name = "N";
			N.ReadOnly = true;
			N.Resizable = DataGridViewTriState.False;
			N.SortMode = DataGridViewColumnSortMode.NotSortable;
			N.ToolTipText = "مسلسل";
			N.Width = 125;
			// 
			// TruckCode
			// 
			TruckCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
			TruckCode.DefaultCellStyle = dataGridViewCellStyle11;
			TruckCode.HeaderText = "رقم السيارة";
			TruckCode.MinimumWidth = 100;
			TruckCode.Name = "TruckCode";
			TruckCode.ReadOnly = true;
			TruckCode.Width = 137;
			// 
			// Notes
			// 
			Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Notes.DefaultCellStyle = dataGridViewCellStyle12;
			Notes.HeaderText = "ملاحظات";
			Notes.MinimumWidth = 6;
			Notes.Name = "Notes";
			Notes.ReadOnly = true;
			// 
			// panel1
			// 
			panel1.Controls.Add(btnPrint);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 605);
			panel1.Name = "panel1";
			panel1.Padding = new Padding(30, 10, 30, 10);
			panel1.Size = new Size(852, 75);
			panel1.TabIndex = 3;
			// 
			// btnPrint
			// 
			btnPrint.Dock = DockStyle.Fill;
			btnPrint.Font = new Font("Cairo", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnPrint.Location = new Point(30, 10);
			btnPrint.Name = "btnPrint";
			btnPrint.Size = new Size(792, 55);
			btnPrint.TabIndex = 0;
			btnPrint.Text = "طباعة";
			btnPrint.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			panel3.Controls.Add(btnGetResult);
			panel3.Dock = DockStyle.Bottom;
			panel3.Location = new Point(0, 144);
			panel3.Name = "panel3";
			panel3.Padding = new Padding(30, 10, 30, 10);
			panel3.Size = new Size(852, 74);
			panel3.TabIndex = 7;
			// 
			// panel2
			// 
			panel2.AutoSize = true;
			panel2.Controls.Add(panel3);
			panel2.Controls.Add(flowLayoutPanel1);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(852, 218);
			panel2.TabIndex = 4;
			// 
			// panel4
			// 
			panel4.Controls.Add(dataGridView);
			panel4.Dock = DockStyle.Fill;
			panel4.Location = new Point(0, 218);
			panel4.Name = "panel4";
			panel4.Size = new Size(852, 387);
			panel4.TabIndex = 5;
			// 
			// SendTrafficView
			// 
			AutoScaleDimensions = new SizeF(11F, 37F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel4);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(4, 6, 4, 6);
			Name = "SendTrafficView";
			RightToLeft = RightToLeft.Yes;
			Size = new Size(852, 680);
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)countTrucks).EndInit();
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			flowLayoutPanel3.ResumeLayout(false);
			flowLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
			panel1.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel4.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private Label label1;
		private TextBox CountTrucks;
		private Label lable3;
		private DateTimePicker dateStart;
		private DateTimePicker dateEnd;
		private Label label3;
		private Button btnGetResult;
		private NumericUpDown countTrucks;
		private FlowLayoutPanel flowLayoutPanel2;
		private FlowLayoutPanel flowLayoutPanel3;
		private DataGridView dataGridView;
		private Panel panel1;
		private Button btnPrint;
		private Panel panel3;
		private Panel panel2;
		private Panel panel4;
		private DataGridViewTextBoxColumn N;
		private DataGridViewTextBoxColumn TruckCode;
		private DataGridViewTextBoxColumn Notes;
	}
}
