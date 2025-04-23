using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test16_forms_app_that_uses_cpp_dll
{
    public partial class Form1 : Form
    {
        [DllImport("attemptDll.dll")] 
        public static extern double add(double a, double b);
        [DllImport("attemptDll.dll")]
        public static extern double subtract(double a, double b);
        [DllImport("attemptDll.dll")]
        public static extern double multiply(double a, double b);
        [DllImport("attemptDll.dll")]
        public static extern double divide(double a, double b);

        string sign = "+";
        double saved_val = 0;
        bool newEntry = true;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numberClicked(string number)
        {
            if (newEntry)
            {
                textBox1.Text = number;
            }
            else
            {
                textBox1.Text += number;
            }
            newEntry = false;
        }

        private void performOperation()
        {
            double disp_val = Convert.ToDouble(textBox1.Text);
            double result;
            if (sign == "+")
            {
                result = add(saved_val, disp_val);
            }
            else if (sign == "-")
            {
                result = subtract(saved_val, disp_val);
            }
            else if (sign == "*")
            {
                result = multiply(saved_val, disp_val);
            }
            else if (sign == "/")
            {
                result = divide(saved_val, disp_val);
            }
            else
            {
                result = disp_val;
            }
            displayValue(result);
            saved_val = result;
        }

        private void displayValue(double v)
        {
            textBox1.Text = Convert.ToString(v);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberClicked("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numberClicked("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numberClicked("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numberClicked("4");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            numberClicked("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numberClicked("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numberClicked("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numberClicked("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numberClicked("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (newEntry && sign == "/")
            {
                return;
            }
            numberClicked("0");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (!newEntry)
            {
                performOperation();
            }
            sign = "+";
            newEntry = true;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (!newEntry)
            {
                performOperation();
            }
            sign = "-";
            newEntry = true;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            if (!newEntry)
            {
                performOperation();
            }
            sign = "*";
            newEntry = true;
        }

        private void divi_Click(object sender, EventArgs e)
        {
            if (!newEntry)
            {
                performOperation();
            }
            sign = "/";
            newEntry = true;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (!newEntry)
            {
                performOperation();
            }
            newEntry = true;
            sign = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            saved_val = 0;
            textBox1.Text = "0";
            newEntry = true;
            equals.Enabled = true;
            sign = "";
        }

    }
}
