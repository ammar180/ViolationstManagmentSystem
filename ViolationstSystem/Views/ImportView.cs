using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationsCollecting.View.CustomeComponants;
using ViolationSystem.Data.Entities;
using ViolationSystem.Data.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ViolationsSystem
{
	public partial class ImportView : Form
	{
		public static MainView mainViewInstance;
		private IRepository repository;
		public ImportView()
		{
			InitializeComponent();
			this.Owner = mainViewInstance;
			repository = Repository.GetInstance();

		}
		private async void btnChooseFile_Click(object sender, EventArgs e)
		{
			string path = GetFilePath();
			if (path == "")
				return;
			labFileName.Text = path.Split('\\').Last();
			btnChooseFile.Enabled = false;
			
			await Import(path);

			MessageBox.Show("تم الانتهاء من الإدراج");
			btnChooseFile.Enabled = true;
			labFileName.Text = labCurrentCar.Text = labRowsCount.Text = "";
			labPresantage.Text = "Processing...0%";
			progressBar1.Value = 0;
		}
		public async Task Import(string filePath)
		{
			if (filePath != "")
			{
				try
				{
					using (var workbook = new XLWorkbook(filePath))
					{
						var worksheet = workbook.Worksheets.First();
						var rows = worksheet.RowsUsed().Skip(1);  // Assuming the first row is the header
						int totalRows = rows.Count();
						int processedRows = 0;

						foreach (var row in rows)
						{
							processedRows++;
							progressBar1.Value = (int)((double)processedRows / totalRows * 100);
							labPresantage.Text = $"Processing...{progressBar1.Value}%";
							labRowsCount.Text = $" {processedRows}" +
								$"من " +
								$"{totalRows}";

							var originalValue = row.Cell(1).GetString().Replace(" ", "");
							var digits = "";
							var chars = "";
							foreach (char c in originalValue)
							{
								if (char.IsDigit(c))
									digits += c;
								else
									chars += c;
							}

							var truckCode = string.Join("", chars, digits);
							labCurrentCar.Text = truckCode;
							Application.DoEvents();  // This forces the UI to update
							
							var unit = row.Cell(3).GetString();
							var elManfaz = row.Cell(4).GetString();
							try
							{
								var dateCellValue = row.Cell(2).GetString();
								var violationDate = ParseDate(dateCellValue);
								if (truckCode.Length > 7)
									throw new Exception();
								var violation = new Violation
								{
									TruckCode = truckCode,
									ViolationDate = violationDate,
									Unit = unit,
									ElManfaz = elManfaz,
									Truck = new Truck
									{
										TruckCode = truckCode,
										IsExplored = false,

									}
								};

								await repository.AddViolation(violation);
							}
							catch 
							{
								row.Style.Fill.BackgroundColor = XLColor.RedMunsell;
							}
						}
						// Save the workbook to preserve the changes
						workbook.Save();

						progressBar1.Value = 100;
						labPresantage.Text = "Processing...100%";
						labCurrentCar.Text = "الاستيراد مكتمل";
					}
					btnChooseFile.Enabled = true;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
		private static DateTime ParseDate(string dateString)
		{
			var formats = new string [] { "d/M/yyyy", "dd/MM/yyyy", "M/d/yyyy", "MM/dd/yyyy" };
			foreach (var format in formats)
				if (DateTime.TryParseExact(dateString.Split(' ').First(), format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
					return date;
			throw new FormatException("Invalid date format.");
		}
		public static string GetFilePath()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Excel Files|*.xlsx;*.xls",
				Title = "Select an Excel File"
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				return openFileDialog.FileName;
			}
			return "";
		}

		private static ImportView printv;
		public static ImportView Instance()
		{
			return printv ?? (printv = new ImportView());
		}
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				Hide();
			}
		}

		private void ComboUnit_SelectedIndexChanged(object sender, EventArgs e)
		{
			var ListOfElMnafez = new string[] { };
			switch (comboUnit.Text)
			{
				case "كرداسة":
					ListOfElMnafez = new string []{"صفط", "المعتمدية", "ابورواش", "كرداسة", "الصليبة"};
					break;
				case "البدرشين":
					ListOfElMnafez = new string []{ "مزغونة", "أبوربع" };
					break;
				case "منشاة القناطر":
					ListOfElMnafez = new string []{"المحطة", "القطا", "الدرية", "نكلا الرهاوي", "كوبري القناطر", "نكلا المرور"};
					break;
				case "الصف":
					ListOfElMnafez = new string []{"الودي", "حسن عودة", "الصوارخ", "أبو عوض", "علاء شاهين", "الميزان"};
					break;
				case "العياط":
					ListOfElMnafez = new string []{"الرقة", "الضبعي", "الملطة خارجي", "جرزا", "طهما", "السبيل"};
					break;
				case "ابو نمرس":
					ListOfElMnafez = new string []{"شبرامنت", "نزلة الأشطر", "المزلقان"};
					break;
				case "الواحات البحرية":
					ListOfElMnafez = new string []{"المناجم", "منديشه"};
					break;
				case "اطفيح":
					ListOfElMnafez = new string []{"المرتبة", "صول", "الكريمات", "الحللف"};
					break;
				case "اكتوبر":
					ListOfElMnafez = new string []{"النشية", "الحرانية", "السفارة", "المنصورية", "المريوطية", "السياحي", "الفصبجي"};
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

		private async void btnRegist_Click(object sender, EventArgs e)
		{
			btnRegist.Enabled = false;
			if (NumTrucksCount.Value != 0 && truckCodeBodx1.txtTruckCode.Length >= 5)
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
				var dd = GetRandomDate(dateBox1.Date, dateBox2.Date);
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

			await repository.AddTruckViolations(list);
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
