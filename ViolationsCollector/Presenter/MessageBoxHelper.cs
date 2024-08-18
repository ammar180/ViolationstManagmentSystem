using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolationsCollector.Presenter
{
	public static class MessageBoxHelper
	{

		public static bool SelectBath()
		{
			var result = MessageBox.Show("المسار الخاص باستخراج البياتات غير موجود، اضغط 'نعم' لتحديد المسار واستخراج البيانات",
				"تحديد مسار استخراج البيانات",
				MessageBoxButtons.OKCancel);
			return result == DialogResult.OK;
		}
		public static void ExtrationDone()
		{
			MessageBox.Show(
					"تم استخراج البيانات بنجاح، تفقد المسار التالي للحصول على البيانات بصيغة اكسل:\n" +
					Properties.Settings.Default.ExportPath
					);
		}
		public static bool AlertExportDate(int mon)
		{
			var result = MessageBox.Show($"{mon} سيتم استخراج مخالفات شهر", "إعلام باستخراج البيانات",
					MessageBoxButtons.OKCancel
					);
			return result == DialogResult.OK;
		}
	}
}
