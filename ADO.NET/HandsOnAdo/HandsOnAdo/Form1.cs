using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // all classes of this library are imp to fetch data and perform operations on it

namespace HandsOnAdo
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //creating connection 
            SqlConnection con = new SqlConnection("Data Source=CSCINDAE745733;Initial Catalog=Northwind;Integrated Security=True");
            //if connetion string has backslash, use @before string e.g. @"data source blah blah"

            con.Open(); // open connection
            SqlCommand cmd = new SqlCommand("select customerid, contactname from customers", con);//write query

            SqlDataReader dr = cmd.ExecuteReader(); // returns in the form of sql data reader object
            //sqldatareader cant be instantiated directly cause it doesnt have a public constructor

            while (dr.Read())
            {//without while, it reads only 1 record
                label2.Text += dr[0].ToString() + dr["ContactName"].ToString() + "\n";
            }

            con.Close();//conection closed
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
      
    }
}
