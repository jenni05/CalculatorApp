using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "1";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = TextBox1.Text + "2";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = TextBox1.Text + "3";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = TextBox1.Text + "4";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = TextBox1.Text + "5";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = TextBox1.Text + "6";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = TextBox1.Text + "7";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = TextBox1.Text + "8";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = TextBox1.Text + "9";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "0";
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(TextBox1.Text);

            TextBox1.Text = "0";
            Operation = "+";
        }

        private void subtractbutton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(TextBox1.Text);

            TextBox1.Text = "0";
            Operation = "-";
        }

        private void multiplybutton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(TextBox1.Text);

            TextBox1.Text = "0";
            Operation = "*";
        }

        private void dividebutton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(TextBox1.Text);

            TextBox1.Text = "0";
            Operation = "/";
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
        }

        private void decimalpoint_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + ".";
        }

        private void equalsign_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(TextBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                TextBox1.Text = Convert.ToString(Result);

                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                TextBox1.Text = Convert.ToString(Result);

                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                TextBox1.Text = Convert.ToString(Result);

                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    TextBox1.Text = "ERROR";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    TextBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }

        }
    }
}
