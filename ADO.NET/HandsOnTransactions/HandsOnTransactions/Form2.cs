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

namespace HandsOnTransactions
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CSCINDAE745733;Initial Catalog=CSCDB;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        //DataSet ds = null;
        DataTable dt = null;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SearchProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Pid", tbProductId.Text);
            da = new SqlDataAdapter(cmd);
            //ds = new DataSet();
            dt = new DataTable();
            //da.Fill(ds);
            da.Fill(dt);
            //if (ds.Tables[0].Rows.Count > 0)
            if(dt.Rows.Count > 0)
            {
                //string pname = ds.Tables[0].Rows[0][0].ToString();
                string pname = dt.Rows[0][0].ToString();
                MessageBox.Show(pname);
            }
            else {
                MessageBox.Show("Invalid ID");
            }
            
        }
    }
}
