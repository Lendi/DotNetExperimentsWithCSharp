using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Asset.BusinessLayer;
using asset.datalayer;


namespace AssetManagement.Admin
{
    public partial class CreateUser : System.Web.UI.Page
    {
        AdminBL obj = new AdminBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

       

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            user usr = new user();
            usr.emp_id = int.Parse(tbEmpID.Text);
            usr.short_id = tbUname.Text;
            usr.fname = tbFirstname.Text;
            usr.lname = tbLastName.Text;
            usr.email_id = tbEmailID.Text;
            usr.user_password = tbPassword.Text;
            usr.manager_id = int.Parse(tbManagerID.Text);
            usr.designation = ddlDesignation.Text;
            usr.mobile = int.Parse(tbPhno.Text);
            usr.date_of_join = CalendarDOJ.SelectedDate;//check
            usr.active = ddlAccountStatus.SelectedItem.Value;

            obj.CreateUser(usr);
            Label1.Text = "User Created!";
            
           


        }




        protected void CalendarDOJ_SelectionChanged(object sender, EventArgs e)
        {

        }

        
    }
}