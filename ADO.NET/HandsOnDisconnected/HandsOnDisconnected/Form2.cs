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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CSCINDAE745733;Initial Catalog=CSCDB;Integrated Security=True");
        SqlDataAdapter da = null;
        DataSet ds = null;
        DataRow dr = null;
        SqlCommandBuilder cb = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string qry = "Select * from employeee";
            da = new SqlDataAdapter(qry, con);
            cb = new SqlCommandBuilder(da);
            ds = new System.Data.DataSet(); 
            da.Fill(ds, "Emp");
            //based on the column we are searching for a result set, we need to set a primary key
            //PK required for searching, updating, deleting
            ds.Tables["Emp"].PrimaryKey = new DataColumn[] {
            ds.Tables[0].Columns["Eid"]};


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            dr = ds.Tables["Emp"].Rows.Find(tbempid.Text);
            if (dr != null)
            {
                tbempid.Text = dr["eid"].ToString();
                tbempname.Text = dr[1].ToString();
                tbsalary.Text = dr["sal"].ToString();
                cbdesig.Text = dr["desig"].ToString();
                cbdeptid.Text = dr["did"].ToString();

            }
            else
                MessageBox.Show("Invalid ID");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //updated record
            ds.Tables["Emp"].Rows.Find(tbempid.Text)["desig"] = cbdesig.Text;
            ds.Tables["Emp"].Rows.Find(tbempid.Text)["sal"] = tbsalary.Text ;

            //if ds has changes, to apply those changes to db, we shud call update method
            //apply ds changes to db table

            //da.Update(ds.Tables["Emp"]);
            da.Update(ds, "Emp");
            MessageBox.Show("Record Updated!");
            //sql command builder class -> we can generate qrys for any change in dataset
            // and the qry is sent to da which is further sent to db for execution

            //attach command builder now
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete record
            ds.Tables["Emp"].Rows.Find(tbempid.Text).Delete();
            da.Update(ds, "Emp");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            dr = ds.Tables["Emp"].NewRow();
            dr["eid"] = int.Parse(tbempid.Text);
            dr["ename"] = tbempname.Text;
            dr["desig"] = cbdesig.Text;
            dr["did"] = cbdeptid.Text;
            dr["sal"] = int.Parse(tbsalary.Text);
            dr["hiredate"] = dtpjoindate.Value;
            //add row to dataset table
            ds.Tables["Emp"].Rows.Add(dr);

            if (ds.HasChanges())
            da.Update(ds, "Emp");
            MessageBox.Show("Record Added!");
        }
    }
}
