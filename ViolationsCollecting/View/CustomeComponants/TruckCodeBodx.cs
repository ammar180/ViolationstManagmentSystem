using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolationsCollecting.View.CustomeComponants
{
	public partial class TruckCodeBodx : UserControl
	{

		public TruckCodeBodx()
		{
			InitializeComponent();
			InitializeTextBoxes();

		}
		private void InitializeTextBoxes()
		{
			textBoxes = new TextBox[]
			{
				a1,
				a2,
				a3,

			};
			foreach (TextBox textBox in textBoxes)
			{
				textBox.KeyDown += new KeyEventHandler(TextBox_KeyDown);
				textBox.TextChanged += new EventHandler(TextBox_TextChanged);
			}
			//textBoxes[0].Focus();  Focus on the first TextBox
		}
		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			int currentIndex = Array.IndexOf(textBoxes, textBox);
			if (currentIndex < textBoxes.Length - 1)
			{
				textBoxes[currentIndex + 1].Focus();
				textBoxes[currentIndex + 1].SelectAll();
			}
			else if (e.Equals(" ") && currentIndex < textBoxes.Length - 1)
			{
				textBoxes[currentIndex + 1].Focus();
				textBoxes[currentIndex + 1].SelectAll();
			}
			else
				jumpToNumberFaild();
		}

		public void jumpToNumberFaild()
		{
			if (FirstNumberTextBox != null)
				FirstNumberTextBox.Focus();
		}

		private void TextBox_KeyDown(object sender, KeyEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			int currentIndex = Array.IndexOf(textBoxes, textBox);

			if (e.KeyCode == Keys.Right && currentIndex < textBoxes.Length - 1)
			{
				textBoxes[currentIndex + 1].Focus();
				textBoxes[currentIndex + 1].SelectAll();
			}
			else if (e.KeyCode == Keys.Space && currentIndex < textBoxes.Length - 1)
			{
				textBoxes[currentIndex + 1].Focus();
				textBoxes[currentIndex + 1].SelectAll();
			}

			else if (e.KeyCode == Keys.Left && currentIndex > 0)
			{
				textBoxes[currentIndex - 1].Focus();
				textBoxes[currentIndex - 1].SelectAll();
			}
			else if (e.KeyCode == Keys.Back && currentIndex > 0)
			{
				textBoxes[currentIndex].Clear();
				//textBoxes[currentIndex - 1].Focus();
				//textBoxes[currentIndex - 1].SelectAll();
			}

		}


	}
}
