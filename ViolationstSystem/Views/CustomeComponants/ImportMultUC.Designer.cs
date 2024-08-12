namespace ViolationstSystem.Views.CustomeComponants
{
	partial class ImportMultUC
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
			this.dateBox1 = new ViolationsCollecting.View.CustomeComponants.DateBox();
			this.dateBox2 = new ViolationsCollecting.View.CustomeComponants.DateBox();
			this.btnRegist = new System.Windows.Forms.Button();
			this.NumTrucksCount = new System.Windows.Forms.NumericUpDown();
			this.comboElManfaz = new System.Windows.Forms.ComboBox();
			this.comboUnit = new System.Windows.Forms.ComboBox();
			this.truckCodeBodx1 = new ViolationsCollecting.View.CustomeComponants.TruckCodeBodx();
			this.labErrorMessage = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.NumTrucksCount)).BeginInit();
			this.SuspendLayout();
			// 
			// dateBox1
			// 
			this.dateBox1.Font = new System.Drawing.Font("Cairo", 10.2F);
			this.dateBox1.Location = new System.Drawing.Point(25, 248);
			this.dateBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.dateBox1.Name = "dateBox1";
			this.dateBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateBox1.Size = new System.Drawing.Size(484, 90);
			this.dateBox1.TabIndex = 10;
			// 
			// dateBox2
			// 
			this.dateBox2.Font = new System.Drawing.Font("Cairo", 10.2F);
			this.dateBox2.Location = new System.Drawing.Point(26, 380);
			this.dateBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.dateBox2.Name = "dateBox2";
			this.dateBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateBox2.Size = new System.Drawing.Size(483, 87);
			this.dateBox2.TabIndex = 11;
			// 
			// btnRegist
			// 
			this.btnRegist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnRegist.Location = new System.Drawing.Point(64, 481);
			this.btnRegist.Name = "btnRegist";
			this.btnRegist.Size = new System.Drawing.Size(293, 45);
			this.btnRegist.TabIndex = 13;
			this.btnRegist.Text = "تسجيل";
			this.btnRegist.UseVisualStyleBackColor = true;
			// 
			// NumTrucksCount
			// 
			this.NumTrucksCount.Location = new System.Drawing.Point(371, 483);
			this.NumTrucksCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.NumTrucksCount.Name = "NumTrucksCount";
			this.NumTrucksCount.Size = new System.Drawing.Size(101, 45);
			this.NumTrucksCount.TabIndex = 12;
			this.NumTrucksCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// comboElManfaz
			// 
			this.comboElManfaz.AutoCompleteCustomSource.AddRange(new string[] {
            "الصليبة",
            "كرداسة",
            "أبورواش",
            "المعتمدية",
            "صفط"});
			this.comboElManfaz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboElManfaz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.comboElManfaz.FormattingEnabled = true;
			this.comboElManfaz.Items.AddRange(new object[] {
            "الصليبة",
            "كرداسة",
            "أبورواش",
            "المعتمدية",
            "صفط"});
			this.comboElManfaz.Location = new System.Drawing.Point(25, 170);
			this.comboElManfaz.Name = "comboElManfaz";
			this.comboElManfaz.Size = new System.Drawing.Size(243, 45);
			this.comboElManfaz.TabIndex = 9;
			// 
			// comboUnit
			// 
			this.comboUnit.AutoCompleteCustomSource.AddRange(new string[] {
            "كرداسة",
            "البدرشين",
            "الصف",
            "العياط",
            "منشاة القناطر",
            "ابو نمرس",
            "الواحات البحرية",
            "اطفيح",
            "اكتوبر"});
			this.comboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.comboUnit.FormattingEnabled = true;
			this.comboUnit.Items.AddRange(new object[] {
            "كرداسة",
            "البدرشين",
            "الصف",
            "العياط",
            "منشاة القناطر",
            "ابو نمرس",
            "الواحات البحرية",
            "اطفيح",
            "اكتوبر"});
			this.comboUnit.Location = new System.Drawing.Point(350, 170);
			this.comboUnit.Name = "comboUnit";
			this.comboUnit.Size = new System.Drawing.Size(159, 45);
			this.comboUnit.TabIndex = 8;
			// 
			// truckCodeBodx1
			// 
			this.truckCodeBodx1.FirstNumberTextBox = null;
			this.truckCodeBodx1.Font = new System.Drawing.Font("Cairo", 12F);
			this.truckCodeBodx1.Location = new System.Drawing.Point(29, 73);
			this.truckCodeBodx1.Name = "truckCodeBodx1";
			this.truckCodeBodx1.Padding = new System.Windows.Forms.Padding(5);
			this.truckCodeBodx1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.truckCodeBodx1.Size = new System.Drawing.Size(477, 79);
			this.truckCodeBodx1.TabIndex = 7;
			this.truckCodeBodx1.txtCodeChars = "";
			this.truckCodeBodx1.txtCodeDigits = "";
			// 
			// labErrorMessage
			// 
			this.labErrorMessage.AutoSize = true;
			this.labErrorMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labErrorMessage.Location = new System.Drawing.Point(268, 529);
			this.labErrorMessage.Name = "labErrorMessage";
			this.labErrorMessage.Size = new System.Drawing.Size(0, 37);
			this.labErrorMessage.TabIndex = 14;
			// 
			// ImportMultUC
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.labErrorMessage);
			this.Controls.Add(this.dateBox1);
			this.Controls.Add(this.dateBox2);
			this.Controls.Add(this.btnRegist);
			this.Controls.Add(this.NumTrucksCount);
			this.Controls.Add(this.comboElManfaz);
			this.Controls.Add(this.comboUnit);
			this.Controls.Add(this.truckCodeBodx1);
			this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "ImportMultUC";
			this.Size = new System.Drawing.Size(534, 598);
			((System.ComponentModel.ISupportInitialize)(this.NumTrucksCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ViolationsCollecting.View.CustomeComponants.DateBox dateBox1;
		private ViolationsCollecting.View.CustomeComponants.DateBox dateBox2;
		private System.Windows.Forms.Button btnRegist;
		private System.Windows.Forms.NumericUpDown NumTrucksCount;
		private System.Windows.Forms.ComboBox comboElManfaz;
		private System.Windows.Forms.ComboBox comboUnit;
		private ViolationsCollecting.View.CustomeComponants.TruckCodeBodx truckCodeBodx1;
		private System.Windows.Forms.Label labErrorMessage;
	}
}
