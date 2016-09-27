using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product_Supplier

//FEEDBACK: use try catch, ajax, everything taught to u.
//use linkbutton instead of hyperlink.    

{
    public partial class product : System.Web.UI.Page
    {
        ModelDataContext obj = new ModelDataContext();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Product_Detail pd = new Product_Detail();
            pd.prodid = int.Parse(tbProdID.Text);
            pd.prodname = tbProdName.Text;
            pd.supplierid = int.Parse(tbSuplierID.Text);

            obj.Product_Details.InsertOnSubmit(pd);
            obj.SubmitChanges();

            Label4.Text = "Record is added!";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int pid = int.Parse(tbProdID.Text);           
            Product_Detail pd = (from pdetails in obj.Product_Details
                                where pdetails.prodid == pid
                                select pdetails).SingleOrDefault();

            if (pd != null)
            {
                tbProdName.Text = pd.prodname;
                tbSuplierID.Text = pd.supplierid.ToString();              
            }
            else
                Label4.Text = "Invalid Product ID";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int pid = int.Parse(tbProdID.Text);
            Product_Detail pd = (from pdetails in obj.Product_Details
                                where pdetails.prodid == pid
                                select pdetails).SingleOrDefault();

            pd.prodname = tbProdName.Text;
            pd.supplierid = int.Parse(tbSuplierID.Text);
            obj.SubmitChanges();
            Label4.Text = "Record Updated!";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int pid = int.Parse(tbProdID.Text);
            Product_Detail pd = (from pdetails in obj.Product_Details
                                 where pdetails.prodid == pid
                                 select pdetails).SingleOrDefault();

            obj.Product_Details.DeleteOnSubmit(pd);
            obj.SubmitChanges();
            Label4.Text = "Record Deleted!";
        }
    }
}