using System;
using System.Linq;
using System.Windows.Forms;

namespace ViolationsCollecting.View.CustomeComponants
{
	public partial class TruckCodeBodx : UserControl
	{
		public string txtTruckCode
		{
			get => string.Join("", txtChars.Text, txtDigits.Text);
		}
		public string txtCodeChars { get => txtChars.Text; set => txtChars.Text = value; }
		public string txtCodeDigits { get => txtDigits.Text; set => txtDigits.Text = value; }
		public TruckCodeBodx()
		{
			InitializeComponent();
			txtDigits.Focus();
		}

		private void AssosiateEventsToTextBoxes()
		{
			textBoxes = new TextBox[] { };
			foreach (TextBox textBox in textBoxes)
			{
				textBox.KeyDown += new KeyEventHandler(TextBox_KeyDown);
				textBox.TextChanged += new EventHandler(TextBox_TextChanged);
				textBox.TextChanged += delegate { CodeChange?.Invoke(txtTruckCode, EventArgs.Empty) ; };
			}
		}
		public event EventHandler CodeChange;
		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			int currentIndex = Array.IndexOf(textBoxes, textBox);

			if (textBox.Text == " ")
				textBox.Text = "";

			if (currentIndex >= 0 && currentIndex <= 2 && textBox.Text != "")
				if (IsValiedChar(textBox.Text[0]))
					MoveToNextFaild(currentIndex);
				else
					textBox.Text = "";

			else if (currentIndex >= 3 && currentIndex <= 7 && textBox.Text != "")
				if (IsValidNumber(textBox.Text[0]))
					MoveToNextFaild(currentIndex);
				else
					textBox.Text = "";

		}

		private void MoveToNextFaild(int currentIndex)
		{
			if (currentIndex < textBoxes.Length - 1)
			{
				textBoxes[currentIndex + 1].Focus();
				textBoxes[currentIndex + 1].SelectAll();
			}
		}

		private bool IsValidNumber(char c)
		{
			return char.IsDigit(c);
		}

		private bool IsValiedChar(char c)
		{
			return (c >= '\u0600' && c <= '\u06FF');
		}

		private void TextBox_KeyDown(object sender, KeyEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			int currentIndex = Array.IndexOf(textBoxes, textBox);

			if (e.KeyCode == Keys.Right && currentIndex > 0)
			{
				textBoxes[currentIndex - 1].Focus();
				textBoxes[currentIndex - 1].SelectAll();
			}
			else if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.Space) && currentIndex < textBoxes.Length - 1)
			{
				textBoxes[currentIndex + 1].Focus();
				textBoxes[currentIndex + 1].SelectAll();
			}
			else if (e.KeyCode == Keys.Back && currentIndex > 0)
			{
				textBoxes[currentIndex - 1].Clear();
				textBoxes[currentIndex - 1].Focus();
				//textBoxes[currentIndex - 1].SelectAll();
			}

		}
		public void ClearCodeBoxes()
		{	
			txtChars.Clear();
			txtDigits.Clear();
		}
	}
}
