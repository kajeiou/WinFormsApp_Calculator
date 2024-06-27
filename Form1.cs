using System;
using System.Windows.Forms;

namespace WinFormsApp_Calculator

{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((displayTextBox.Text == "0") || (isOperationPerformed))
                displayTextBox.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(displayTextBox.Text);
            isOperationPerformed = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    displayTextBox.Text = (result + Double.Parse(displayTextBox.Text)).ToString();
                    break;
                case "-":
                    displayTextBox.Text = (result - Double.Parse(displayTextBox.Text)).ToString();
                    break;
                case "*":
                    displayTextBox.Text = (result * Double.Parse(displayTextBox.Text)).ToString();
                    break;
                case "/":
                    displayTextBox.Text = (result / Double.Parse(displayTextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(displayTextBox.Text);
            operation = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = "0";
            result = 0;
        }

        private void displayTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
