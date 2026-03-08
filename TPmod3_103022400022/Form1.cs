using System;
using System.Windows.Forms;

namespace TPmod3_103022400022
{
    public partial class Form1 : Form
    {
        private string currentInput = "";
        private double firstNumber = 0;
        private bool isOperatorPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            currentInput += btn.Text;
            lblOutput.Text = currentInput;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (currentInput != "")
            {
                firstNumber = double.Parse(currentInput);
                currentInput = "";
                isOperatorPressed = true;
                lblOutput.Text = firstNumber + " +";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (isOperatorPressed && currentInput != "")
            {
                double secondNumber = double.Parse(currentInput);
                double result = firstNumber + secondNumber;
                lblOutput.Text = result.ToString();
                currentInput = result.ToString();
                isOperatorPressed = false;
            }
        }
    }
}