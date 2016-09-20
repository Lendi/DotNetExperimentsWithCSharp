using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLogin
{
    public partial class ComputerApp : Form
    {
        public ComputerApp()
        {
            InitializeComponent();
        }

        private void ComputerApp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        double amt = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbti3.Checked)
                amt = amt + 34000;
            else
                amt = amt - 34000;
            tbamount.Text = amt.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbti7.Checked)
                amt = amt + 46000;
            else
                amt = amt - 46000;
            tbamount.Text = amt.ToString();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbpendrive.Checked)
                amt = amt + 3000;
            else
                amt = amt - 3000;
            tbamount.Text = amt.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkeyboard.Checked)
                amt = amt + 10000;
            else
                amt = amt - 10000;
            tbamount.Text = amt.ToString();
        }

        private void rbti5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbti5.Checked)
                amt = amt + 44000;
            else
                amt = amt - 44000;
            tbamount.Text = amt.ToString();
        }

        private void cbspeakers_CheckedChanged(object sender, EventArgs e)
        {
            if (cbspeakers.Checked)
                amt = amt + 8000;
            else
                amt = amt - 8000;
            tbamount.Text = amt.ToString();
        }

       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            panel2.Visible = false;            

        }

        private void rbcard_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
