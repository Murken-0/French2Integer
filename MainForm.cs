using System;
using System.Windows.Forms;
using System.Drawing;

namespace koryagin1
{
	public partial class MainForm : Form
	{
		Converter converter = new Converter();
		public MainForm()
		{
			InitializeComponent();
		}

		private void TranslateButton_Click(object sender, EventArgs e)
		{
			try
			{
				outputLabel.Text = "Ваше число: " + converter.Convert(inputBox.Text);
				outputLabel.ForeColor = Color.Black;
			}
			catch (ArgumentException exc)
			{
				outputLabel.Text = exc.Message;
				outputLabel.ForeColor = Color.Red;
			}
		}

		private void InputBox_TextChanged(object sender, EventArgs e)
		{
			outputLabel.Text = "";
		}
	}
}
