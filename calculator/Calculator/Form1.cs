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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = check_zero("1", label1.Text);
            label1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = check_zero("2", label1.Text);
            label1.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = check_zero("3", label1.Text);
            label1.Text = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = check_zero("4", label1.Text);
            label1.Text = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = check_zero("5", label1.Text);
            label1.Text = str;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str = check_zero("6", label1.Text);
            label1.Text = str;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string str = check_zero("7", label1.Text);
            label1.Text = str;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string str = check_zero("8", label1.Text);
            label1.Text = str;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string str = check_zero("9", label1.Text);
            label1.Text = str;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string str = check_zero("0", label1.Text);
            label1.Text = str;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string labelData = label1.Text;
            if(label1.Text == "")
            {
                label1.Text = "0+";
            } else
            {
                string opData = func_op("+", labelData);
                label1.Text = opData;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string labelData = label1.Text;
            if (label1.Text == "")
            {
                label1.Text = "0-";
            }
            else
            {
                string opData = func_op("-", labelData);
                label1.Text = opData;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string labelData = label1.Text;
            if (label1.Text == "")
            {
                label1.Text = "0X";
            } else
            {
                string opData = func_op("*", labelData);
                label1.Text = opData;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string labelData = label1.Text;
            if ( label1.Text == "")
            {
                label1.Text = "0%";
            } else
            {
                string opData = func_op("/", labelData);
                label1.Text = opData;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string labelData = label1.Text;
            if (labelData != "")
            {
                char lastchar = char.Parse(labelData.Substring(labelData.Length - 1));
                if (lastchar != '+' && lastchar != '-' && lastchar != '*' && lastchar != '/')
                {
                    int result = calculate();
                    label1.Text = result.ToString();
                }
            }
        }

        private string func_op(string op, string labelData)
        {
            string lastchar = labelData.Substring(labelData.Length - 1);
            if (lastchar == "+" || lastchar == "-" || lastchar == "*" || lastchar == "/")
            {
                labelData = labelData.Substring(0, labelData.Length - 1);
            }
            labelData += op;
            return labelData;
        }

        private string check_zero(string num, string labelData)
        {
            if (labelData == "0")
            {
                labelData = num;
            } else
            {
                labelData += num;
            }
            return labelData;
        }

        private int calculate()
        {
            string labelData = label1.Text;

            int result = (int) new DataTable().Compute(labelData, null);

            return result;
        }
    }
}
