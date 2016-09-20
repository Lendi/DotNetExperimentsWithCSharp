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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CSCINDAE745733;Initial Catalog=CSCDB;Integrated Security=True");
        SqlCommand cmd = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string senderAcc = tbSenderAcc.Text;
            string RecieverAcc = tbRecieverAcc.Text;
            string amt = tbAmt.Text;
            con.Open();// BeginTransaction returns a transaction object.
            //open connection before creating a transaction object

            SqlTransaction tr = con.BeginTransaction();
           
            cmd = new SqlCommand("Update accounts set bal =bal-"+amt+" where acno='"+senderAcc+"'", con, tr);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("Update accounts set bal =bal-"+amt+" where acno='"+RecieverAcc+"'",con, tr);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("Select bal from accounts where acno ='"+senderAcc+"'", con, tr);

            decimal am = (decimal)cmd.ExecuteScalar(); //amount is money type
            //money converted into decimal in C#
            if(am < 5000){
            tr.Rollback();
                MessageBox.Show("Trnsctn Failed");            
            }
            else{
            tr.Commit();
                MessageBox.Show("Trnscn Success");

            }
            con.Close();
        }
    }
}
