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
        public List<string> value = new List<string>();
        double num1, num2,result;
        char MyOperator;
        public void NumClick(int MyNumber)
        {
           textBox1.Text =textBox1.Text+ MyNumber.ToString();
        }
        public void OperaClick(char myOperation)
        {
            num1=double.Parse(textBox1.Text);
            MyOperator = myOperation;
            textBox1.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumClick(8);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);
            switch (MyOperator)
            {
                case '+': result = num1 + num2;
                    break;
                case '-': result = num1 - num2;
                    break;
                case 'x':result = num1 * num2;
                    break;
                case '/':
                    {
                        if (num2 == 0)
                            result = 0;
                        else
                            result = num1 / num2;
                    }
                    break;
            }
            textBox1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumClick(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumClick(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumClick(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumClick(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumClick(5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumClick(6);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            NumClick(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumClick(9);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            NumClick(0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            OperaClick('-');
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OperaClick('/');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OperaClick('x');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OperaClick('+');
        }
    }
}
