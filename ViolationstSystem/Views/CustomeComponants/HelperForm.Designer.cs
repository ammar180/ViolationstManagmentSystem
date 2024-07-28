namespace ViolationstSystem.Views
{
	partial class HelperForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// reportViewer
			// 
			this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reportViewer.LocalReport.ReportEmbeddedResource = "ViolationstSystem.Reports.TruckViolationReport.rdlc";
			this.reportViewer.Location = new System.Drawing.Point(0, 0);
			this.reportViewer.Name = "reportViewer";
			this.reportViewer.ServerReport.BearerToken = null;
			this.reportViewer.Size = new System.Drawing.Size(801, 526);
			this.reportViewer.TabIndex = 0;
			// 
			// HelperForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 526);
			this.Controls.Add(this.reportViewer);
			this.Name = "HelperForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Print Form";
			this.Load += new System.EventHandler(this.HelperForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		public Microsoft.Reporting.WinForms.ReportViewer reportViewer;
	}
}