using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationstSystem.Views;
using ViolationSystem.Data.Entities;
using ViolationSystem.Data.Repositories;

namespace ViolationsSystem
{
	public partial class ImportView : Form
	{
		public static MainView mainViewInstance;
		private IRepository repository;
		private IXLWorkbook workbook;
		private bool stopImport = false;
		private DataTable RowsHasProblem;
		public ImportView()
		{
			InitializeComponent();
			this.Owner = mainViewInstance;
			string connectionStr = ViolationstSystem.Properties.Settings.Default.SelectedConnectionType;
			repository = new Repository(connectionStr, true);

			checkOriginalFile.Checked = ViolationstSystem.Properties.Settings.Default.ValidateOriginal;
		}

		private async void btnChooseFile_Click(object sender, EventArgs e)
		{
			string path = GetFilePath();
			if (path == "")
				return;
			labFileName.Text = path.Split('\\').Last();
			btnChooseFile.Enabled = false;
			try
			{
				workbook = new XLWorkbook(path);
				if(checkOriginalFile.Checked)
					workbook.Unprotect(ViolationstSystem.Properties.Settings.Default.WorksheetPassword);

				await Import();
				// Call method to save problematic rows to a new Excel file
				if(RowsHasProblem.Rows.Count > 0)
					SaveProblematicRowsToExcel(path);
			}
			catch (IOException)
			{
				labErrorMessage.Text = "\nيبدو أن هناك تطبيق اخر يستخدم الملف أو مشكله في التعامل معل الملف";
			}
			catch (ArgumentException)
			{
				labErrorMessage.Text = "تحذير!، تبين أن هذا الملف غير مطابق لمواصفات الملف الاصلي المستخرج من برنامج الوحدات";

			}

			MessageBox.Show(
				"إجمالي الصفوف المضافة" +
				$" {labRowsCount.Text} " +
				$"\nإجمالي عدد المشاكل: {RowsHasProblem.Rows.Count}"
				,"تم الانتهاء من العملية"
				,MessageBoxButtons.OK
				,MessageBoxIcon.Information
				);
			btnChooseFile.Enabled = true;
			labFileName.Text = labCurrentCar.Text = labRowsCount.Text = "";
			labPresantage.Text = "Processing...0%";
			progressBar1.Value = 0;
			labErrorMessage.Text = "";
		}
		public async Task Import()
		{
			RowsHasProblem = new DataTable("RowsHasProblem");

			RowsHasProblem.Columns.Add("رقم السيارة", typeof(string));
			RowsHasProblem.Columns.Add("تاريخ المخالفة", typeof(string));
			RowsHasProblem.Columns.Add("الوحدة", typeof(string));
			RowsHasProblem.Columns.Add("المنفذ", typeof(string));
			RowsHasProblem.Columns.Add("عدد النقلات", typeof(string));
			RowsHasProblem.Columns.Add("رقم البلاغ", typeof(string));
			RowsHasProblem.Columns.Add("تاريخ الحجز", typeof(string));
			RowsHasProblem.Columns.Add("تاريخ السداد", typeof(string));
			RowsHasProblem.Columns.Add("الملاحظات", typeof(string));

			foreach (var worksheet in workbook.Worksheets)
			{
				var rows = worksheet.RowsUsed().Skip(1);//x => x.Style.Fill.BackgroundColor != XLColor.AppleGreen && x.RowNumber() > StartIngRow.Value).Skip(1);  // Assuming the first row is the header
				int totalRows = rows.Count();
				int processedRows = 0;
				foreach (var row in rows)
				{
					if (stopImport)
					{
						//workbook.Save();

						stopImport = false;
						break;
					}
					processedRows++;
					progressBar1.Value = (int)((double)processedRows / totalRows * 100);
					labPresantage.Text = $"Processing...{progressBar1.Value}%";
					labRowsCount.Text = $" {processedRows} من {totalRows}";
					Application.DoEvents();  // This forces the UI to update


					try
					{
						var truckCode = formatTruckCode(row.Cell("A").GetString());
						labCurrentCar.Text = truckCode;
						var violationDate = new DateTime();
						try {
							violationDate = row.Cell("B").GetDateTime(); // Format date
						}
						catch { violationDate = ParseDate(row.Cell("B").GetString());  }

						DateTime? VBlockDate = null;
						DateTime? VPaymentDate = null;
						if (!row.Cell("G").IsEmpty())
						{
							try {
								VBlockDate = row.Cell("G").GetDateTime();
							}
							catch { VBlockDate = ParseDate(row.Cell("G").GetString()); }
						}
						if (!row.Cell("H").IsEmpty())
						{
							try {
								VPaymentDate = row.Cell("H").GetDateTime();
							}
							catch { VPaymentDate = ParseDate(row.Cell("H").GetString()); }
						}
						var Vunit = row.Cell("C").GetString();
						var Vmanfaz = row.Cell("D").GetString();
						bool isExploredValue = true;
						var VreportNumber = row.Cell("F").GetString();
						var VCount = !row.Cell("E").IsEmpty() ? row.Cell("E").GetString() : "1";
						var VComments = row.Cell("I").GetString();
						try
						{
							isExploredValue = row.Cell("A").Style.Fill.BackgroundColor.Color != System.Drawing.Color.Transparent;
							isExploredValue = isExploredValue || !VreportNumber.Length.Equals(0) || VPaymentDate.HasValue;
						}
						catch { }
						var truck = new Truck
						{
							TruckCode = truckCode,
							IsExplored = isExploredValue,
						};
						var violation = new Violation
						{
							TruckCode = truckCode,
							ViolationDate = violationDate,
							Unit = Vunit,
							ElManfaz = Vmanfaz,
							Truck = truck,
							ReportNumber = VreportNumber,
							BlockDate = VBlockDate,
							PaymentDate = VPaymentDate,
							VCount = VCount,
							Comments = VComments,
						};
						// Optimize db.SaveChanges method and save changes when progress changes
						await repository.AddViolation(violation);

						///////row.Style.Fill.BackgroundColor = XLColor.AppleGreen;
					}
					catch (Exception ex)
					{
						//////row.Style.Fill.BackgroundColor = XLColor.RedMunsell;
						labErrorMessage.Text = $"مشكله في الصف : {row.RowNumber()} \n {ex.Message}";
						RowsHasProblem.Rows.Add(row.Cell("A").GetString(),
												row.Cell("B").GetString().Split(' ').First(),
												row.Cell("C").GetString(),
												row.Cell("D").GetString(),
												row.Cell("E").GetString(),
												row.Cell("F").GetString(),
												row.Cell("G").GetString().Split(' ').First(),
												row.Cell("H").GetString().Split(' ').First(),
												row.Cell("I").GetString());
					}
				}
			}
			//////workbook.Save();
			progressBar1.Value = 100;
			labPresantage.Text = "Processing...100%";
			labCurrentCar.Text = "الاستيراد مكتمل";
			btnChooseFile.Enabled = true;
		}

		private string formatTruckCode(string originalValue)
		{
			if (originalValue.Replace(" ", "").Length < 5)
				throw new Exception("رقم سيارة غير صحيح");
			else if (originalValue.Replace(" ", "").Length > 7)
				return originalValue;

			originalValue = originalValue.Replace(" ", "");
			// Format the truck 
			var digits = "";
			var chars = "";
			foreach (char c in originalValue)
			{
				if (char.IsDigit(c))
					digits += c;
				else
				{
					switch (c)
					{
						case 'ة':
							chars += 'ه';
							break;
						case 'أ':
							chars += 'ا';
							break;
						case 'ى':
							chars += 'ي';
							break;
						default:
							chars += c;
							break;
					}
				}
			}
			return string.Join("", chars, digits);
		}

		private void SaveProblematicRowsToExcel(string originalFilePath)
		{
			string newFilePath = "";
			if (originalFilePath.Contains("-المشاكل.xlsx"))
			{
				File.Delete(originalFilePath);
				newFilePath = originalFilePath;
			}
			else
			{
				originalFilePath = originalFilePath.Remove(originalFilePath.Length - 5);
				newFilePath = originalFilePath + $@"-المشاكل.xlsx";
				newFilePath = GetUniqueFileName(newFilePath);
			}

			// Export
			using (XLWorkbook xLWorkbook = new XLWorkbook())
			{
				var worksheet = xLWorkbook.AddWorksheet(RowsHasProblem, "sheet1");
				worksheet.RightToLeft = true;
				worksheet.Column(2).Width = 20.33;
				worksheet.Column(2).Style.NumberFormat.SetFormat("d/M/yyyy"); // Set date format
				using (MemoryStream ma = new MemoryStream())
				{
					xLWorkbook.SaveAs(ma, true);
					File.WriteAllBytes(newFilePath, ma.ToArray());
				}
			}

			// Open the new Excel file
			System.Diagnostics.Process.Start(newFilePath);
		}
		private static string GetUniqueFileName(string fileName)
		{
			if (!File.Exists(fileName))
				return fileName;

			string directory = Path.GetDirectoryName(fileName);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
			string extension = Path.GetExtension(fileName);
			int count = 1;

			string newFileName;
			do
			{
				newFileName = Path.Combine(directory, $"{fileNameWithoutExtension} ({count}){extension}");
				count++;
			} while (File.Exists(newFileName));

			return newFileName;
		}
		private DateTime ParseDate(string dateString)
		{
			string[] formats = new string[] { "d/M/yyyy", "dd/MM/yyyy", "M/d/yyyy", "MM/dd/yyyy" };
			string temp = "";
			for(int i = 0; i < dateString.Length; i++)
				if (char.IsDigit(dateString[i]) || dateString[i] == '/')
					temp += dateString[i];
			dateString = temp;
			
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
			=> printv ?? (printv = new ImportView());
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				Hide();
				stopImport = true;
			}
		}

		private void checkOriginalFile_CheckedChanged(object sender, EventArgs e)
		{
			ViolationstSystem.Properties.Settings.Default.ValidateOriginal = checkOriginalFile.Checked;
			ViolationstSystem.Properties.Settings.Default.Save();

		}
	}
}
