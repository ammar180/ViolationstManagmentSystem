using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Globalization;
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
		public ImportView()
		{
			InitializeComponent();
			this.Owner = mainViewInstance;
			string connectionStr = ViolationstSystem.Properties.Settings.Default.SelectedConnectionType;
			repository = new Repository(connectionStr);
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
				await Import();
			}
			catch
			{
				MessageBox.Show("هناك تطبيق اخر يستخدم الملف، يرجى اغلاقه وإعادة المحاولة");
			}

			MessageBox.Show("تم الانتهاء من العملية");
			btnChooseFile.Enabled = true;
			labFileName.Text = labCurrentCar.Text = labRowsCount.Text = "";
			labPresantage.Text = "Processing...0%";
			progressBar1.Value = 0;
		}
		public async Task Import()
		{
			foreach (var worksheet in workbook.Worksheets)
			{
				var rows = worksheet.RowsUsed(x => x.Style.Fill.BackgroundColor != XLColor.AppleGreen).Skip(1);  // Assuming the first row is the header
				int totalRows = rows.Count();
				int processedRows = 0;
				int isProgress = 0;
				foreach (var row in rows)
				{
					if (stopImport)
					{
						workbook.Save();
						stopImport = false;
						break;
					}
					processedRows++;
					progressBar1.Value = (int)((double)processedRows / totalRows * 100);
					labPresantage.Text = $"Processing...{progressBar1.Value}%";
					labRowsCount.Text = $" {processedRows}" +
						$"من " +
						$"{totalRows}";

					// formmat the truck 
					var originalValue = row.Cell("A").GetString().Replace(" ", "");
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

					var truckCode = string.Join("", chars, digits);
					labCurrentCar.Text = truckCode;
					Application.DoEvents();  // This forces the UI to update

					try
					{
						var dateCellValue = row.Cell("B").GetString();
						var violationDate = ParseDate(dateCellValue); // format date
						var violation = new Violation
						{
							TruckCode = truckCode,
							ViolationDate = violationDate ?? throw new Exception(),
							Unit = row.Cell("C").GetString(),
							ElManfaz = row.Cell("D").GetString(),
							Truck = new Truck
							{
								TruckCode = truckCode,
								IsExplored = (row.Cell("A").Style.Fill.BackgroundColor != XLColor.Transparent),
							},
							ReportNumber = row.Cell("F").GetString(),
							BlockDate = ParseDate(row.Cell("G").GetString(), false),
							PaymentDate = ParseDate(row.Cell("H").GetString(), false),
							Comments = "",
							VCount = !row.Cell("E").IsEmpty() ? row.Cell("E").GetString() : "1",
						};
						// the approtch to Obtomize db.SaveChanges methode
						// and savechanges when progress is changes 
						await repository.AddViolation(violation, progressBar1.Value != isProgress);
						if (progressBar1.Value != isProgress)
						{
							isProgress = progressBar1.Value;
							//workbook.Save();
						}

						row.Style.Fill.BackgroundColor = XLColor.AppleGreen;
					}
					catch (Exception ex)
					{
						row.Style.Fill.BackgroundColor = XLColor.RedMunsell;
						// Save the workbook to preserve the changes
						labErrorMessage.Text = $"مشكله في الصف : {row.RowNumber()}";
						//workbook.Save();
					}
				}
			}
			workbook.Save();
			progressBar1.Value = 100;
			labPresantage.Text = "Processing...100%";
			labCurrentCar.Text = "الاستيراد مكتمل";
			btnChooseFile.Enabled = true;
		}
		private DateTime? ParseDate(string dateString, bool isTraditionalFormate = true)
		{
			if (dateString == "")
				return null;
			string[] formats = isTraditionalFormate ?
				new string[] { "M/d/yyyy", "MM/dd/yyyy", "d/M/yyyy", "dd/MM/yyyy" }
				: new string[] { "d/M/yyyy", "dd/MM/yyyy", "M/d/yyyy", "MM/dd/yyyy" };
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
				stopImport = true;
			}
		}

	}
}
