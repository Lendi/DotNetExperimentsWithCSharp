using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddSumMulDiv
{
    public partial class Form1 : Form
    {

        public int a, b, result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            result = a + b;
            MessageBox.Show(" Addition = " + result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            result = 0;
            if (a < b)
            {
                result  = b - a;
            }
            else {
                result = a - b;            
            }

            MessageBox.Show(" Subtraction = " + result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            result = a * b;
            MessageBox.Show(" Multiplication = " + result);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            result = a / b;
            MessageBox.Show(" Division = " + result);
        }
    }
}
