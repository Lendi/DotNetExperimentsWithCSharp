using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HandsOnDisconnected
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CSCINDAE745733;Initial Catalog=Northwind;Integrated Security=True");
        SqlDataAdapter da = null;
        DataSet ds = null;
        DataView dv = null;


        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("Select * from customers", con);
            da.Fill(ds, "cus");
            dv = new DataView(ds.Tables[0]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "customerid ='" + textBox1.Text + "'";
            dataGridView1.DataSource = dv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "country ='" + textBox2.Text + "'";
            dataGridView1.DataSource = dv;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "city ='" + textBox3.Text + "'";
            dv.Sort = "companyname"; //sorts accoring to that column by default
            dataGridView1.DataSource = dv;
        }
    }
}
