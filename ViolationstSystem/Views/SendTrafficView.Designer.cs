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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.countTrucks = new System.Windows.Forms.NumericUpDown();
			this.lable3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGetResult = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TruckCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnPrint = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.countTrucks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.panel1.SuspendLayout();
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
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1011, 75);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.Controls.Add(this.label1);
			this.flowLayoutPanel2.Controls.Add(this.countTrucks);
			this.flowLayoutPanel2.Controls.Add(this.lable3);
			this.flowLayoutPanel2.Controls.Add(this.label2);
			this.flowLayoutPanel2.Controls.Add(this.comboBox1);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(426, 12);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(568, 51);
			this.flowLayoutPanel2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(441, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "عدد الشاحنات";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// countTrucks
			// 
			this.countTrucks.Location = new System.Drawing.Point(351, 0);
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
			// lable3
			// 
			this.lable3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lable3.AutoSize = true;
			this.lable3.Location = new System.Drawing.Point(213, 0);
			this.lable3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lable3.Name = "lable3";
			this.lable3.Size = new System.Drawing.Size(134, 51);
			this.lable3.TabIndex = 3;
			this.lable3.Text = "التاريخ المبدأي";
			this.lable3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(3, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 45);
			this.comboBox1.TabIndex = 9;
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
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.TruckCode,
            this.Notes});
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.Size = new System.Drawing.Size(1011, 456);
			this.dataGridView.TabIndex = 2;
			// 
			// N
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.N.DefaultCellStyle = dataGridViewCellStyle2;
			this.N.HeaderText = "م";
			this.N.MinimumWidth = 20;
			this.N.Name = "N";
			this.N.ReadOnly = true;
			this.N.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.N.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.N.ToolTipText = "مسلسل";
			this.N.Width = 125;
			// 
			// TruckCode
			// 
			this.TruckCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.TruckCode.DefaultCellStyle = dataGridViewCellStyle3;
			this.TruckCode.HeaderText = "رقم السيارة";
			this.TruckCode.MinimumWidth = 100;
			this.TruckCode.Name = "TruckCode";
			this.TruckCode.ReadOnly = true;
			this.TruckCode.Width = 137;
			// 
			// Notes
			// 
			this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Notes.DefaultCellStyle = dataGridViewCellStyle4;
			this.Notes.HeaderText = "ملاحظات";
			this.Notes.MinimumWidth = 6;
			this.Notes.Name = "Notes";
			this.Notes.ReadOnly = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnPrint);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 605);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
			this.panel1.Size = new System.Drawing.Size(1011, 75);
			this.panel1.TabIndex = 3;
			// 
			// btnPrint
			// 
			this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPrint.Font = new System.Drawing.Font("Cairo", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrint.Location = new System.Drawing.Point(30, 10);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(951, 55);
			this.btnPrint.TabIndex = 0;
			this.btnPrint.Text = "طباعة";
			this.btnPrint.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnGetResult);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 75);
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
			this.panel2.Size = new System.Drawing.Size(1011, 149);
			this.panel2.TabIndex = 4;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dataGridView);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 149);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1011, 456);
			this.panel4.TabIndex = 5;
			// 
			// SendTrafficView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
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
		private DataGridView dataGridView;
		private Panel panel1;
		private Button btnPrint;
		private Panel panel3;
		private Panel panel2;
		private Panel panel4;
		private DataGridViewTextBoxColumn N;
		private DataGridViewTextBoxColumn TruckCode;
		private DataGridViewTextBoxColumn Notes;
		private ComboBox comboBox1;
		private Label label2;
	}
}
