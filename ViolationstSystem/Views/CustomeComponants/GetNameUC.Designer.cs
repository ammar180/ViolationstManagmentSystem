namespace ViolationstSystem.Views.CustomeComponants
{
	partial class GetNameUC
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(12, 13);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(379, 45);
			this.txtName.TabIndex = 0;
			this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(156, 69);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 41);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// GetNameUC
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(403, 122);
			this.ControlBox = false;
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtName);
			this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "GetNameUC";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "إدخال الاسم";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.Button btnOk;
	}
}