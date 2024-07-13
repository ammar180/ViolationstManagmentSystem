using System.Data;
using System.Diagnostics;
using ClosedXML.Excel;
namespace ViolationsCollecting.Presenter
{
	public static class ExcelHelper
	{

		public static void Export(DataTable dt, string name, string savePath)
		{
			try
			{
				string fileName = savePath + @$"\{name}.xlsx";

				// Export
				using (XLWorkbook xLWorkbook = new XLWorkbook())
				{
					xLWorkbook.AddWorksheet(dt, name);
					using (MemoryStream ma = new MemoryStream())
					{
						xLWorkbook.SaveAs(ma);
						File.WriteAllBytes(fileName, ma.ToArray());
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
			dataTable.Columns["TruckCode"].ColumnName = "رقم الشاحنة";
			
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
	}
}
