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

namespace StudentDetailsAssignment
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source= CSCINDAE745733;Initial Catalog=CSCDB;Integrated Security=True");
        SqlCommand cmd = null;

        int studid;
        string studname = null;
        DateTime joindate;
        string course = null;
        string timings = null;
        int fee;    

        public Form1()
        {
          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbMorning.Checked)
                timings = rbMorning.Text;
            if (rbNoon.Checked)
                timings = rbNoon.Text;
            if (rbEve.Checked)
                timings = rbEve.Text;

            cmd = new SqlCommand("AddStudDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@studid", tbStudId.Text);
            cmd.Parameters.AddWithValue("@studname", tbStudName.Text);
            cmd.Parameters.AddWithValue("@joindate", dtpJoinDate.Value.ToString() );
            cmd.Parameters.AddWithValue("@course", cbCourse.Text);
            cmd.Parameters.AddWithValue("@timings", timings);
            cmd.Parameters.AddWithValue("@fee", tbFee.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Added");
            tbStudId.Text = "";
            tbStudName.Text = "";
            tbFee.Text = "";
            tbStudId.Focus();
        }
    }
}
