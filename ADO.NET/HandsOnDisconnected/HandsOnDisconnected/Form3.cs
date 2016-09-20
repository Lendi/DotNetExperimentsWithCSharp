using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HandsOnDisconnected
{
    public partial class Form3 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=CSCINDAE745733;Initial Catalog=Northwind;Integrated Security=True");
        SqlDataAdapter da = null;
        DataSet ds = null;
        

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string qry = "Select * from Customers";
            da = new SqlDataAdapter(qry, con);
            ds = new System.Data.DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //create ds called cus like emp and pass it as tables["cus"] above
            //with the help of DGV, we can make manipulations

            //to apply Data grid view manipulations to database, use command builder
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
