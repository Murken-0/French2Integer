using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace koryagin1
{
	public partial class Form1 : Form
	{
		Converter converter = new Converter();
		public Form1()
		{
			InitializeComponent();
		}

		private void TranslateButton_Click(object sender, EventArgs e)
		{
			try
			{
				outputLabel.Text = "Ваше число: " + converter.Convert(inputBox.Text);
			}
			catch (ArgumentException exc)
			{
				outputLabel.Text = exc.Message;
			}
		}

		private void InputBox_TextChanged(object sender, EventArgs e)
		{
			outputLabel.Text = "";
		}
	}
}
