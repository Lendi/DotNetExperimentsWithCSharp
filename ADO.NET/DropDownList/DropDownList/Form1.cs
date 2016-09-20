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

namespace DropDownList
{
    public partial class Form1 : Form
    {

        ArrayList samsung = new ArrayList();
        ArrayList iPhone = new ArrayList();
        ArrayList Micromax = new ArrayList();

        public Form1()
        {
            samsung.Add("blah1");
            samsung.Add("blah2");
            samsung.Add("blah3");
            samsung.Add("blah4");

            iPhone.Add("4s");
            iPhone.Add("5s");
            iPhone.Add("6s");

            Micromax.Add("bleh1");
            Micromax.Add("bleh2");
            Micromax.Add("bleh3");
            
            InitializeComponent();
        }

        ArrayList ar = new ArrayList();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
