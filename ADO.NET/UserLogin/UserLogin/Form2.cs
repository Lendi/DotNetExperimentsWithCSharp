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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = comboBox1.SelectedItem.ToString();
            this.BackColor = System.Drawing.Color.FromName(color) ;
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // add items to combobox
            comboBox2.Items.Add("Lilly");
            comboBox2.Items.Add("Rose");
            comboBox2.Items.Add("Tulips");
            comboBox2.Items.Add("Daffodils");
            comboBox2.Items.Add("Daisies");
        }
    }
}
