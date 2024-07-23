using System;
using System.Windows.Forms;

namespace ViolationstSystem.Presenter.Helpers
{
	public static class MessageHelper
	{
		public static void Allert(string message)
		{
			MessageBox.Show(message,
					"اعلام بالحالة",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
					);
		}

		internal static void ErrorMessage(string message)
		{
			MessageBox.Show(message,
					"مشكلة اثناء العملية",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
					);
		}
	}
}
