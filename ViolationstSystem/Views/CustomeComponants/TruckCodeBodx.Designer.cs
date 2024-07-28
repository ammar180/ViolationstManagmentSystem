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
			this.msChar = new System.Windows.Forms.MaskedTextBox();
			this.NumsGroupBox = new System.Windows.Forms.GroupBox();
			this.msDigits = new System.Windows.Forms.MaskedTextBox();
			this.AlphaGroupBox.SuspendLayout();
			this.NumsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// AlphaGroupBox
			// 
			this.AlphaGroupBox.Controls.Add(this.msChar);
			this.AlphaGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.AlphaGroupBox.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AlphaGroupBox.Location = new System.Drawing.Point(140, 5);
			this.AlphaGroupBox.Name = "AlphaGroupBox";
			this.AlphaGroupBox.Size = new System.Drawing.Size(97, 69);
			this.AlphaGroupBox.TabIndex = 1;
			this.AlphaGroupBox.TabStop = false;
			this.AlphaGroupBox.Text = "الاحرف";
			// 
			// msChar
			// 
			this.msChar.BackColor = System.Drawing.Color.White;
			this.msChar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.msChar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.msChar.Font = new System.Drawing.Font("Calibri", 15F);
			this.msChar.Location = new System.Drawing.Point(3, 35);
			this.msChar.Mask = "a a a";
			this.msChar.Name = "msChar";
			this.msChar.Size = new System.Drawing.Size(91, 31);
			this.msChar.TabIndex = 3;
			this.msChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// NumsGroupBox
			// 
			this.NumsGroupBox.Controls.Add(this.msDigits);
			this.NumsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NumsGroupBox.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumsGroupBox.Location = new System.Drawing.Point(5, 5);
			this.NumsGroupBox.Name = "NumsGroupBox";
			this.NumsGroupBox.Size = new System.Drawing.Size(135, 69);
			this.NumsGroupBox.TabIndex = 2;
			this.NumsGroupBox.TabStop = false;
			this.NumsGroupBox.Text = "الأرقام";
			// 
			// msDigits
			// 
			this.msDigits.BackColor = System.Drawing.Color.White;
			this.msDigits.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.msDigits.Dock = System.Windows.Forms.DockStyle.Fill;
			this.msDigits.Font = new System.Drawing.Font("Calibri", 15F);
			this.msDigits.Location = new System.Drawing.Point(3, 35);
			this.msDigits.Mask = "0 0 0 0";
			this.msDigits.Name = "msDigits";
			this.msDigits.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.msDigits.Size = new System.Drawing.Size(129, 31);
			this.msDigits.TabIndex = 4;
			this.msDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.Size = new System.Drawing.Size(242, 79);
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
		public MaskedTextBox msChar;
		public MaskedTextBox msDigits;

		public TextBox FirstNumberTextBox { get; set; }
	}
}
