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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CSCINDAE745733;Initial Catalog=Northwind;Integrated Security=True");
        SqlDataAdapter da = null;
        DataSet ds = null;
        

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //two tables in same dataset
            ds = new DataSet();
            da = new SqlDataAdapter("Select * from customers", con);
            da.Fill(ds, "cus");
            da = new SqlDataAdapter("select * from Employees", con);
            da.Fill(ds, "Emp");
            dataGridView1.DataSource = ds.Tables["cus"];
            dataGridView2.DataSource = ds.Tables["emp"];
        }
    }
}
