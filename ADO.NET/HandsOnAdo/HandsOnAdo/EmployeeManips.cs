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
    public partial class EmployeeManips : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CSCINDAE745733;Initial Catalog=CSCDB;Integrated Security=True"); //one conn obj and one comm obj
        SqlCommand cmd = null;
        string eid;
        string ename;
        string sal;
        string desig;
        string hiredate;
        string dept;
        string qry;

        public EmployeeManips()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeManips_Load(object sender, EventArgs e)
        {
            FillDeptId();
            GetID();

        }

        private void GetID() {
            qry = "select max(eid) from employeee";
            cmd = new SqlCommand(qry, con);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            count++;
            tbempid.Text = count.ToString();
            tbempid.ReadOnly = true;
            con.Close();
            
        }

        private void FillDeptId()
        {
            qry = "Select did from dept";
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbdeptid.Items.Add(dr["did"]);

            }
            con.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            eid = tbempid.Text;
            ename = tbempname.Text;
            desig = cbdesig.Text;
            dept = cbdeptid.Text.Trim();
            sal = tbsalary.Text;
            hiredate = dtpjoindate.Value.ToString();
            qry = @" insert into employeee values("+eid+" , '"+ename+"', '"+desig+"' , "+ sal +", '"+hiredate+"', '"+dept+"')";
            cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Added");
            //reset values
            tbempid.Text = string.Empty;         
            tbempname.Text = string.Empty;
            tbsalary.Text = string.Empty;
            cbdeptid.SelectedIndex = -1;
            cbdesig.SelectedIndex = -1;
            GetID();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ename = tbempname.Text;
            qry = "Select * from employeee where Ename='" + ename+"'";
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataReader dr=cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                tbempid.Text = dr["Eid"].ToString();
                tbsalary.Text = dr["sal"].ToString();
                cbdesig.Text = dr["desig"].ToString();
                cbdeptid.Text = dr["did"].ToString();
                dtpjoindate.Value = (DateTime)dr["hiredate"];
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
            }
            else {
                MessageBox.Show("Invalid Name");
            }

            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            eid = tbempid.Text;
            desig = cbdesig.Text;
            sal = tbsalary.Text;
            qry = "Update employeee set desig='"+desig+"', sal ="+sal+" where eid="+eid;
            cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            eid = tbempid.Text;          
            qry = "Delete from employeee where Eid="+eid;
            cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted");
        }

        private void cbdesig_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbdeptid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
