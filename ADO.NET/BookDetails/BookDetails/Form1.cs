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

namespace BookDetails
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CSCINDAE745733;Initial Catalog=CSCDB;Integrated Security=True");
        SqlCommand cmd = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("AddBooks", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //passing parameters
            cmd.Parameters.AddWithValue("@bid", tbbookid.Text );
            cmd.Parameters.AddWithValue("@bname", tbbookname.Text );    
            cmd.Parameters.AddWithValue("@authname", cbauthname.Text );
            cmd.Parameters.AddWithValue("@pubname", cbpubname.Text);
            cmd.Parameters.AddWithValue("@price", tbprice.Text);    
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            tbbookid.Text = "";
            tbbookname.Text = "";
            cbauthname.Text = "";
            cbpubname.Text = "";
            tbprice.Text = "";
            tbbookid.Focus();
            MessageBox.Show("Record Added!");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DeleteBooks", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //passing parameters
            cmd.Parameters.AddWithValue("@bid", tbbookid.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book Deleted");
            tbbookid.Text = "";
            tbbookname.Text = "";
            tbbookid.Focus();          

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UpdateBooks", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //passing parameters
            cmd.Parameters.AddWithValue("@bid", tbbookid.Text);
            cmd.Parameters.AddWithValue("@bname", tbbookname.Text);
            cmd.Parameters.AddWithValue("@authname", cbauthname.Text);
            cmd.Parameters.AddWithValue("@pubname", cbpubname.Text);
            cmd.Parameters.AddWithValue("@price", tbprice.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book Updated");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SearchBooks", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //passing parameters
            cmd.Parameters.AddWithValue("@bname", tbbookname.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                tbbookname.Text = dr[0].ToString();
            }
            else
                MessageBox.Show("Invalid Bookname");
            con.Close();
         
            tbbookid.Focus();
        
        }
    }
}
