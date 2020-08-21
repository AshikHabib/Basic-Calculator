using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double result = 0;
        string operation = "";
        bool operationPressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void PressButton(object sender, EventArgs e)
        {
            if ((ResultScreen.Text == "0") || (operationPressed))
                ResultScreen.Clear();

            Button b = (Button)sender;
            operationPressed = false;
            
            if(b.Text  == ".")
            {
                if(!ResultScreen.Text.Contains("."))
                    ResultScreen.Text = ResultScreen.Text + b.Text; ;
            }

            else
                ResultScreen.Text = ResultScreen.Text + b.Text;
        }
        private void AllClear_Click(object sender, EventArgs e)
        {
            ResultScreen.Text = "0";
            result = 0;
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            ResultScreen.Text = "0";
        }

        private void PressOperation(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (result != 0)
            {
                EqualTo.PerformClick();
                operation = b.Text;
                operationPressed = true;
            }

            else
            {
                operation = b.Text;
                result = double.Parse(ResultScreen.Text);
                operationPressed = true;
            }

        }

        private void EqualTo_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    ResultScreen.Text = (result + double.Parse(ResultScreen.Text)).ToString();
                    break;

                case "-":
                    ResultScreen.Text = (result - double.Parse(ResultScreen.Text)).ToString();
                    break;

                case "*":
                    ResultScreen.Text = (result * double.Parse(ResultScreen.Text)).ToString();
                    break;

                case "/":
                    ResultScreen.Text = (result / double.Parse(ResultScreen.Text)).ToString();
                    break;

                default:
                    break;
            }

            result = double.Parse(ResultScreen.Text);
            operationPressed = false;

        }

    }
}
