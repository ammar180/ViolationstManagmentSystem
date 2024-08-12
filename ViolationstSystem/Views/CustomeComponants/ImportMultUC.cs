using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationSystem.Data.Entities;

namespace ViolationstSystem.Views.CustomeComponants
{
	public partial class ImportMultUC : UserControl
	{
		public ImportMultUC()
		{
			InitializeComponent();

		}
		private async void btnRegist_Click(object sender, EventArgs e)
		{
			btnRegist.Enabled = false;
			if (NumTrucksCount.Value != 0 && truckCodeBodx1.txtTruckCode.Length >= 5 && dateBox1.Date.HasValue && dateBox2.Date.HasValue)
			{
				try
				{
					await AddViolationsRange();

					labErrorMessage.Text = "تم اتمام العملية بنجاح";
					labErrorMessage.ForeColor = System.Drawing.Color.Green;

					truckCodeBodx1.ClearCodeBoxes();
					NumTrucksCount.Value = 0;
					btnRegist.Enabled = true;
				}
				catch (Exception ex)
				{
					labErrorMessage.Text = ex.Message;
					labErrorMessage.ForeColor = System.Drawing.Color.OrangeRed;
					btnRegist.Enabled = true;
				}
			}

		}
		private async Task AddViolationsRange()
		{
			var list = new List<Violation>();
			for (int i = 0; i < (int)NumTrucksCount.Value; i++)
			{
				var dd = GetRandomDate(dateBox1.Date.Value, dateBox2.Date.Value);
				list.Add(new Violation()
				{
					TruckCode = truckCodeBodx1.txtTruckCode,
					ViolationDate = dd,
					Unit = comboUnit.Text,
					ElManfaz = comboElManfaz.Text,
					Truck = new Truck()
					{
						TruckCode = truckCodeBodx1.txtTruckCode,
						IsExplored = false,
					}
				});
			}

			//await repository.AddTruckViolations(list);
		}
		private void ComboUnit_SelectedIndexChanged(object sender, EventArgs e)
		{
			var ListOfElMnafez = new string[] { };
			switch (comboUnit.Text)
			{
				case "كرداسة":
					ListOfElMnafez = new string[] { "صفط", "المعتمدية", "ابورواش", "كرداسة", "الصليبة" };
					break;
				case "البدرشين":
					ListOfElMnafez = new string[] { "مزغونة", "أبوربع" };
					break;
				case "منشاة القناطر":
					ListOfElMnafez = new string[] { "المحطة", "القطا", "الدرية", "نكلا الرهاوي", "كوبري القناطر", "نكلا المرور" };
					break;
				case "الصف":
					ListOfElMnafez = new string[] { "الودي", "حسن عودة", "الصوارخ", "أبو عوض", "علاء شاهين", "الميزان" };
					break;
				case "العياط":
					ListOfElMnafez = new string[] { "الرقة", "الضبعي", "الملطة خارجي", "جرزا", "طهما", "السبيل" };
					break;
				case "ابو نمرس":
					ListOfElMnafez = new string[] { "شبرامنت", "نزلة الأشطر", "المزلقان" };
					break;
				case "الواحات البحرية":
					ListOfElMnafez = new string[] { "المناجم", "منديشه" };
					break;
				case "اطفيح":
					ListOfElMnafez = new string[] { "المرتبة", "صول", "الكريمات", "الحللف" };
					break;
				case "اكتوبر":
					ListOfElMnafez = new string[] { "النشية", "الحرانية", "السفارة", "المنصورية", "المريوطية", "السياحي", "الفصبجي" };
					break;

				default:
					break;
			}
			comboElManfaz.AutoCompleteCustomSource.Clear();
			comboElManfaz.Items.Clear();

			comboElManfaz.AutoCompleteCustomSource.AddRange(ListOfElMnafez);
			comboElManfaz.Items.AddRange(ListOfElMnafez);

			comboElManfaz.Text = ListOfElMnafez.FirstOrDefault() ?? "";
		}
		public static DateTime GetRandomDate(DateTime startDate, DateTime endDate)
		{
			Random random = new Random();
			if (startDate > endDate || startDate == endDate)
			{
				throw new Exception("التاريخ المبدأي اكبر من التاريخ النهائية او نفس التاريخ");
			}

			// Calculate the range of days between the two dates
			int range = (endDate - startDate).Days;

			// Generate a random number of days to add to the start date
			int randomDays = random.Next(range + 1); // +1 to include endDate

			return startDate.AddDays(randomDays);
		}

	}
}
