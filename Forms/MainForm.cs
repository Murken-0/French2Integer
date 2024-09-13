using System;
using System.Windows.Forms;

namespace French2Integer
{
    public partial class MainForm : Form
    {
        private readonly Converter converter = new Converter();
        public MainForm()
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
                MessageBox.Show(exc.Message, "Ошибка");
            }
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            outputLabel.Text = "";
        }
    }
}
