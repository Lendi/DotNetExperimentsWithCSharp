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


namespace HandsOnAdo
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source= CSCINDAE745733;Initial Catalog=CSCDB;Integrated Security=True");
        SqlCommand cmd = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("AddProduct", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //passing parameters
            cmd.Parameters.AddWithValue("@pid", textID.Text);
            cmd.Parameters.AddWithValue("@pname", textName.Text );
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            textID.Text = "";
            textName.Text = "";
            textID.Focus();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SearchProduct", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //passing parameters
            cmd.Parameters.AddWithValue("@pid", textID.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                textName.Text = dr[0].ToString();
            }
            else
                MessageBox.Show("Invalid ID");
            con.Close();
         
            textID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DeleteProduct", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //passing parameters
            cmd.Parameters.AddWithValue("@pid", textID.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted");
            textID.Text = "";
            textName.Text = "";
            textID.Focus();          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UpdateProduct", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //passing parameters
            cmd.Parameters.AddWithValue("@pid", textID.Text);
            cmd.Parameters.AddWithValue("@pname", textName.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated");
            
            //textID.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textName.Text = "";
            textID.Focus();
        }
    }
}
