using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product_Supplier
{
    public partial class supplier : System.Web.UI.Page
    {
        ModelDataContext obj = new ModelDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbSuplierID0_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sid = int.Parse(tbSupID.Text);
            supplier_info sp = (from sdetails in obj.supplier_infos
                                 where sdetails.supplierid == sid
                                 select sdetails).SingleOrDefault();

            if (sp != null)
            {
                tbSupName.Text = sp.suppliername;
                tbSupAddr.Text = sp.supplier_address;
                tbSupCity.Text = sp.city;
                tbSupContact.Text = sp.contact_no.ToString();
                tbSupEmail.Text = sp.email;
               
            }
            else
                Label7.Text = "Invalid Product ID";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            supplier_info sp = new supplier_info();
            sp.supplierid = int.Parse(tbSupID.Text);
            sp.suppliername = tbSupName.Text;
            sp.supplier_address = tbSupAddr.Text;
            sp.contact_no = int.Parse(tbSupContact.Text);
            sp.city = tbSupCity.Text;
            sp.email = tbSupEmail.Text;

            
            obj.supplier_infos.InsertOnSubmit(sp);
            obj.SubmitChanges();

            Label7.Text = "Record is added!";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int sid = int.Parse(tbSupID.Text);
            supplier_info sp = (from sdetails in obj.supplier_infos
                                where sdetails.supplierid == sid
                                select sdetails).SingleOrDefault();

            sp.suppliername = tbSupName.Text;
            sp.supplier_address = tbSupAddr.Text;
            sp.contact_no = int.Parse(tbSupContact.Text);
            sp.city = tbSupCity.Text;
            sp.email = tbSupEmail.Text;
            
            obj.SubmitChanges();
            Label7.Text = "Record Updated!";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int sid = int.Parse(tbSupID.Text);
            supplier_info sp = (from sdetails in obj.supplier_infos
                                where sdetails.supplierid == sid
                                select sdetails).SingleOrDefault();


            obj.supplier_infos.DeleteOnSubmit(sp);
            obj.SubmitChanges();
            Label7.Text = "Record Deleted!";
        }
    }
}