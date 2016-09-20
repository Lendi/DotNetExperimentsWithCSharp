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

    
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=CSCINDAE745733;Initial Catalog=CSCDB;Integrated Security=True");
        SqlDataAdapter da = null;
        DataSet ds = null;
        DataRow dr = null;

        //variable for index [for next and prev]

        int rowindex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string qry = "Select * from employeee";
            da = new SqlDataAdapter(qry, con);

            //instantiate dataset; ds was null before

            ds = new System.Data.DataSet();

            //fill dataset

            da.Fill(ds, "Emp"); // new dataset name ; dont rename employeee same as table in db
            //fetch first record

            FillRow(0);


        }
        private void FillRow(int r) {
            dr = ds.Tables["Emp"].Rows[r];
            //dr = ds.Tables[0].Rows[0];// returns first row values inthe form of datarow object
            tbempid.Text = dr["eid"].ToString();
            tbempname.Text = dr[1].ToString();
            tbsalary.Text = dr["sal"].ToString();
            cbdesig.Text = dr["desig"].ToString();
            cbdeptid.Text = dr["did"].ToString();
        
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(rowindex < ds.Tables["Emp"].Rows.Count-1 )
            rowindex++;
            FillRow(rowindex);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (rowindex > 0)
            rowindex--;
            FillRow(rowindex);
        }
    }
}
