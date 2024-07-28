namespace ViolationstSystem.Views.CustomeComponants
{
	partial class FilterUserControle
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.CodeCheckedList = new System.Windows.Forms.CheckedListBox();
			this.checkBoxSelectAllCars = new System.Windows.Forms.CheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.UnitsCheckedList = new System.Windows.Forms.CheckedListBox();
			this.checkBoxSelectAllUnits = new System.Windows.Forms.CheckBox();
			this.btnApplyFilter = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.panel1);
			this.groupBox3.Controls.Add(this.panel2);
			this.groupBox3.Controls.Add(this.btnApplyFilter);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox3.Size = new System.Drawing.Size(420, 229);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "filter";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.CodeCheckedList);
			this.panel1.Controls.Add(this.checkBoxSelectAllCars);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(206, 81);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(214, 148);
			this.panel1.TabIndex = 6;
			// 
			// CodeCheckedList
			// 
			this.CodeCheckedList.CheckOnClick = true;
			this.CodeCheckedList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CodeCheckedList.FormattingEnabled = true;
			this.CodeCheckedList.Location = new System.Drawing.Point(0, 41);
			this.CodeCheckedList.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.CodeCheckedList.Name = "CodeCheckedList";
			this.CodeCheckedList.Size = new System.Drawing.Size(214, 107);
			this.CodeCheckedList.TabIndex = 1;
			// 
			// checkBoxSelectAllCars
			// 
			this.checkBoxSelectAllCars.AutoSize = true;
			this.checkBoxSelectAllCars.Checked = true;
			this.checkBoxSelectAllCars.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSelectAllCars.Dock = System.Windows.Forms.DockStyle.Top;
			this.checkBoxSelectAllCars.Location = new System.Drawing.Point(0, 0);
			this.checkBoxSelectAllCars.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.checkBoxSelectAllCars.Name = "checkBoxSelectAllCars";
			this.checkBoxSelectAllCars.Size = new System.Drawing.Size(214, 41);
			this.checkBoxSelectAllCars.TabIndex = 3;
			this.checkBoxSelectAllCars.Text = "تحديد الكل";
			this.checkBoxSelectAllCars.UseVisualStyleBackColor = true;
			this.checkBoxSelectAllCars.CheckedChanged += new System.EventHandler(this.checkBoxSelectAllCars_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.UnitsCheckedList);
			this.panel2.Controls.Add(this.checkBoxSelectAllUnits);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 81);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(206, 148);
			this.panel2.TabIndex = 5;
			// 
			// UnitsCheckedList
			// 
			this.UnitsCheckedList.CheckOnClick = true;
			this.UnitsCheckedList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UnitsCheckedList.FormattingEnabled = true;
			this.UnitsCheckedList.Items.AddRange(new object[] {
            "كرداسة",
            "البدرشين",
            "الصف",
            "العياط",
            "منشاة القناطر",
            "ابو نمرس",
            "الواحات البحرية",
            "اطفيح",
            "اكتوبر"});
			this.UnitsCheckedList.Location = new System.Drawing.Point(0, 41);
			this.UnitsCheckedList.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.UnitsCheckedList.Name = "UnitsCheckedList";
			this.UnitsCheckedList.Size = new System.Drawing.Size(206, 107);
			this.UnitsCheckedList.TabIndex = 3;
			this.UnitsCheckedList.ThreeDCheckBoxes = true;
			// 
			// checkBoxSelectAllUnits
			// 
			this.checkBoxSelectAllUnits.AutoSize = true;
			this.checkBoxSelectAllUnits.Dock = System.Windows.Forms.DockStyle.Top;
			this.checkBoxSelectAllUnits.Location = new System.Drawing.Point(0, 0);
			this.checkBoxSelectAllUnits.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.checkBoxSelectAllUnits.Name = "checkBoxSelectAllUnits";
			this.checkBoxSelectAllUnits.Size = new System.Drawing.Size(206, 41);
			this.checkBoxSelectAllUnits.TabIndex = 4;
			this.checkBoxSelectAllUnits.Text = "تحديد الكل";
			this.checkBoxSelectAllUnits.UseVisualStyleBackColor = true;
			this.checkBoxSelectAllUnits.CheckedChanged += new System.EventHandler(this.checkBoxSelectAllUnits_CheckedChanged);
			// 
			// btnApplyFilter
			// 
			this.btnApplyFilter.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnApplyFilter.Location = new System.Drawing.Point(0, 38);
			this.btnApplyFilter.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.btnApplyFilter.Name = "btnApplyFilter";
			this.btnApplyFilter.Size = new System.Drawing.Size(420, 43);
			this.btnApplyFilter.TabIndex = 0;
			this.btnApplyFilter.Text = "تطبيق";
			this.btnApplyFilter.UseVisualStyleBackColor = true;
			// 
			// FilterUserControle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox3);
			this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.Name = "FilterUserControle";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(420, 229);
			this.groupBox3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBoxSelectAllCars;
		private System.Windows.Forms.CheckedListBox CodeCheckedList;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckedListBox UnitsCheckedList;
		public System.Windows.Forms.Button btnApplyFilter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBoxSelectAllUnits;
	}
}
