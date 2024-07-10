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
		public string txtTruckCode
		{
			get
			{
				return a1.Text + a2.Text + a3.Text  + n4.Text+ n3.Text+ n2.Text + n1.Text ;
			}
			set
			{
				if(value.Length == 7)
				{
					a1.Text = value[0].ToString();
					a2.Text = value[1].ToString();
					a3.Text = value[2].ToString();
				
					n4.Text = value[3].ToString();
					n3.Text = value[4].ToString();
					n2.Text = value[5].ToString();
					n1.Text = value[6].ToString();
				}
				else if(value.Length == 6)
				{ 
					a1.Text = value[0].ToString();
					a2.Text = value[1].ToString();
					a3.Text = "";
				
					n4.Text = value[2].ToString();
					n3.Text = value[3].ToString();
					n2.Text = value[4].ToString();
					n1.Text = value[5].ToString();
				}
			}
		}
		public TruckCodeBodx()
		{
			InitializeComponent();
			AssosiateEventsToTextBoxes();

		}
		private void AssosiateEventsToTextBoxes()
		{
			textBoxes = new TextBox[]
			{
				a1,
				a2,
				a3,

				n1,
				n2,
				n3,
				n4,

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

			if (textBox.Text == " ")
				textBox.Text = "";

			if (currentIndex >= 0 && currentIndex <= 2 && textBox.Text != "")
				if (IsValiedChar(textBox.Text[0]))
					MoveToNextFaild(currentIndex);
				else
					textBox.Text = "";

			else if(currentIndex >= 3 && currentIndex <= 7 && textBox.Text != "")
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
			else if (e.KeyCode == Keys.Left && currentIndex < textBoxes.Length - 1)
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
			foreach (TextBox textBox in textBoxes)
			{
				textBox.Text = "";
			}
			textBoxes[0].Focus();
		}


	}
}
