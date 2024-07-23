using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ViolationSystem.Data.Entities;
namespace ViolationsSystem.Presenter.Helpers
{
	public static class ExcelHelper
	{
		public static List<Violation> Import(string filePath)
		{
			if (filePath != "")
			{
				try
				{
					using (var workbook = new XLWorkbook(filePath))
					{
						var worksheet = workbook.Worksheets.First();
						var rows = worksheet.RowsUsed().Skip(1);  // Assuming the first row is the header

						var violations = new List<Violation>();
						foreach (var row in rows)
						{
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
							var unit = row.Cell(3).GetString();
							var elManfaz = row.Cell(4).GetString();
							try
							{
							var violationDate = row.Cell(2).GetDateTime();
								violations.Add(
									new Violation
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
									});
							}
							catch (InvalidCastException)
							{
								violations.Add(
									new Violation
									{
										TruckCode = truckCode,
										ViolationDate = new DateTime(2000,1,1),
										Unit = unit,
										ElManfaz = elManfaz,
									});
							}
						}

						return violations;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error: {ex.Message}");
					return new List<Violation>();
				}
			}
			return new List<Violation>();
		}
		public static void Export(DataTable dt, string name, string savePath)
		{
			try
			{
				string fileName = savePath + $@"\{name}.xlsx";

				// Export
				using (XLWorkbook xLWorkbook = new XLWorkbook())
				{
					xLWorkbook.AddWorksheet(dt, name);
					using (MemoryStream ma = new MemoryStream())
					{
						xLWorkbook.SaveAs(ma, true);
						File.WriteAllBytes(fileName, ma.ToArray());

						// Set the file attribute to read-only
						File.SetAttributes(fileName, FileAttributes.ReadOnly);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private static string GetFolderPath()
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();
			DialogResult result = folder.ShowDialog();

			return (result == DialogResult.OK) ? folder.SelectedPath : "";
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

		private static DataTable ArrangeDataTable(DataTable dataTable)
		{
			dataTable.Columns["TruckCode"].SetOrdinal(0);
			dataTable.Columns["TruckCode"].ColumnName = "رقم الشاحنة";

			dataTable.Columns["ViolationDate"].SetOrdinal(1);
			dataTable.Columns["ViolationDate"].ColumnName = "تاريخ المخالفة";

			dataTable.Columns["Unit"].SetOrdinal(2);
			dataTable.Columns["Unit"].ColumnName = "الوحدة";

			dataTable.Columns["ElManfaz"].SetOrdinal(3);
			dataTable.Columns["ElManfaz"].ColumnName = "المنفذ";

			if (false)
			{
				dataTable.Columns["Weight"].SetOrdinal(4);
				dataTable.Columns["Weight"].ColumnName = "الوزن";

				dataTable.Columns["Payload"].SetOrdinal(4);
				dataTable.Columns["Payload"].ColumnName = "الحمولة";
			}
			else
			{
				dataTable.Columns.Remove("Weight");
				dataTable.Columns.Remove("Payload");
			}

			// remove
			dataTable.Columns.Remove("Id");
			dataTable.Columns.Remove("RegistrationDate");

			return dataTable;
		}

		private static void OpenDir(string path)
		{
			if (System.IO.Directory.Exists(path))
			{
				Process.Start("explorer.exe", path);
			}
			else
			{
				MessageBox.Show("The specified path does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
