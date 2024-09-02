using System;
using System.Linq;
using System.Windows.Forms;

namespace ViolationsCollecting.View.CustomeComponants
{
	public partial class TruckCodeBodx : UserControl
	{
		// Property for getting the concatenated truck code
		public string txtTruckCode
		{
			get => string.Join("", txtCodeChars, txtCodeDigits);
		}

		// Property for getting/setting the Arabic characters part of the truck code
		public string txtCodeChars
		{
			get => msChar.Text.Replace(" ", "");
			set => msChar.Text = value;
		}

		// Property for getting/setting the digit part of the truck code
		public string txtCodeDigits
		{
			get => msDigits.Text.Replace(" ", "");
			set => msDigits.Text = value;
		}

		// Constructor
		public TruckCodeBodx()
		{
			InitializeComponent();
			msDigits.Focus();
			AssosiateEventsToTextBoxes();  // Ensure events are associated
		}

		// Method to associate events with text boxes
		private void AssosiateEventsToTextBoxes()
		{
			// Associate additional TextChanged event for msChar to filter Arabic characters
			msChar.TextChanged += MsChar_TextChanged;
		}

		// TextChanged event handler to filter Arabic characters in msChar
		private void MsChar_TextChanged(object sender, EventArgs e)
		{
			MaskedTextBox textBox = sender as MaskedTextBox;

			// Remove non-Arabic characters
			textBox.Text = string.Concat(textBox.Text.Where(IsValiedChar));

			// Keep the cursor at the end of the text
			textBox.SelectionStart = textBox.Text.Replace(" ", "").Length;
		}

		// Method to check if a character is a valid Arabic character
		private bool IsValiedChar(char c)
		{
			return c >= '\u0600' && c <= '\u06FF';
		}
		public void ClearCodeBoxes()
		{
			msChar.Clear();
			msDigits.Clear();
		}
	}
}
