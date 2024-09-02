using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Aspose.Cells;

namespace ViolationsCollector.Presenter
{
	public static class ExcelHelper
	{

		public static void Export(DataTable dt, string name, string savePath)
		{
			try
			{
				string fileName = savePath + $@"\{name}.xlsx";
				fileName = GetUniqueFileName(fileName);

				//Export
				using (var xLWorkbook = new XLWorkbook())
				{
					var worksheet = xLWorkbook.AddWorksheet(dt, name);
					xLWorkbook.Protect(Properties.Settings.Default.WorkSheetPassword);
					worksheet.Protect(Properties.Settings.Default.WorkSheetPassword, XLProtectionAlgorithm.DefaultProtectionAlgorithm, XLSheetProtectionElements.SelectUnlockedCells);
					worksheet.RightToLeft = true;
					// Apply data types and formatting
					worksheet.Column(2).Width = 15;
					//xlViolationDateColumn.Style.NumberFormat.SetFormat("d/M/yyyy"); // Set date format

					using (MemoryStream ma = new MemoryStream())
					{
						xLWorkbook.SaveAs(ma, true);
						File.WriteAllBytes(fileName, ma.ToArray());

						// Set the file attribute to read-only
						File.SetAttributes(fileName, FileAttributes.ReadOnly);
					}
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public static string GetPath()
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();
			DialogResult result = folder.ShowDialog();
	
			return (result == DialogResult.OK) ? folder.SelectedPath : "";
		}

		internal static DataTable ArrangeDataTable(DataTable dataTable)
		{
			dataTable.Columns["TruckCode"].SetOrdinal(0);
			dataTable.Columns["TruckCode"].ColumnName = "رقم السيارة";
			
			dataTable.Columns["ViolationDate"].SetOrdinal(1);
			dataTable.Columns["ViolationDate"].ColumnName = "تاريخ المخالفة";

			dataTable.Columns["Unit"].SetOrdinal(2);
			dataTable.Columns["Unit"].ColumnName = "الوحدة";
			
			dataTable.Columns["ElManfaz"].SetOrdinal(3);
			dataTable.Columns["ElManfaz"].ColumnName = "المنفذ";

			if (Properties.Settings.Default.ShowWeightAndPyload)
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

		internal static void OpenDir(string path)
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

	}
}
