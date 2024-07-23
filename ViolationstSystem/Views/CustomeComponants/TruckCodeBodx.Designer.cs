using System.Windows.Forms;
using System;
using System.Drawing;

namespace ViolationsCollecting.View.CustomeComponants
{
	partial class TruckCodeBodx
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
			this.AlphaGroupBox = new System.Windows.Forms.GroupBox();
			this.txtChars = new System.Windows.Forms.TextBox();
			this.NumsGroupBox = new System.Windows.Forms.GroupBox();
			this.txtDigits = new System.Windows.Forms.TextBox();
			this.AlphaGroupBox.SuspendLayout();
			this.NumsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// AlphaGroupBox
			// 
			this.AlphaGroupBox.Controls.Add(this.txtChars);
			this.AlphaGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.AlphaGroupBox.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AlphaGroupBox.Location = new System.Drawing.Point(140, 5);
			this.AlphaGroupBox.Name = "AlphaGroupBox";
			this.AlphaGroupBox.Size = new System.Drawing.Size(97, 78);
			this.AlphaGroupBox.TabIndex = 1;
			this.AlphaGroupBox.TabStop = false;
			this.AlphaGroupBox.Text = "الاحرف";
			// 
			// txtChars
			// 
			this.txtChars.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtChars.Location = new System.Drawing.Point(3, 35);
			this.txtChars.MaxLength = 3;
			this.txtChars.Name = "txtChars";
			this.txtChars.Size = new System.Drawing.Size(91, 39);
			this.txtChars.TabIndex = 0;
			// 
			// NumsGroupBox
			// 
			this.NumsGroupBox.Controls.Add(this.txtDigits);
			this.NumsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NumsGroupBox.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumsGroupBox.Location = new System.Drawing.Point(5, 5);
			this.NumsGroupBox.Name = "NumsGroupBox";
			this.NumsGroupBox.Size = new System.Drawing.Size(135, 78);
			this.NumsGroupBox.TabIndex = 2;
			this.NumsGroupBox.TabStop = false;
			this.NumsGroupBox.Text = "الأرقام";
			// 
			// txtDigits
			// 
			this.txtDigits.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDigits.Location = new System.Drawing.Point(3, 35);
			this.txtDigits.MaxLength = 4;
			this.txtDigits.Name = "txtDigits";
			this.txtDigits.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtDigits.Size = new System.Drawing.Size(129, 39);
			this.txtDigits.TabIndex = 0;
			// 
			// TruckCodeBodx
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.NumsGroupBox);
			this.Controls.Add(this.AlphaGroupBox);
			this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "TruckCodeBodx";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(242, 88);
			this.AlphaGroupBox.ResumeLayout(false);
			this.AlphaGroupBox.PerformLayout();
			this.NumsGroupBox.ResumeLayout(false);
			this.NumsGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TextBox[] textBoxes;
		private GroupBox AlphaGroupBox;
		private GroupBox NumsGroupBox;
		public TextBox txtDigits;
		public TextBox txtChars;

		public TextBox FirstNumberTextBox { get; set; }
	}
}
