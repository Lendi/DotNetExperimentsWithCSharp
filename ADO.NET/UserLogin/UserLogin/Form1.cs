using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        Hashtable ht = new Hashtable();

        public static string DisplayName;        

        public Form1()
        {                      
            ht.Add( "lendi", "123" );
            ht.Add("vihari", "456");
            ht.Add("len", "234");
            ht.Add("megha", "22");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            string uname = textBox1.Text;
            string pwd = textBox2.Text;

            if (ht.ContainsKey(uname) && ht[uname].ToString() == pwd)// select a piece of statement in bool, right click, quick watch, it shows what it returns
            {
                DisplayName = uname;
                welcome obj = new welcome();
                this.Hide(); // this is object of login class

                obj.ShowDialog(); // to open form
                this.Close();// to close parent form

            }
            else {

                MessageBox.Show("Invalid User");
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
