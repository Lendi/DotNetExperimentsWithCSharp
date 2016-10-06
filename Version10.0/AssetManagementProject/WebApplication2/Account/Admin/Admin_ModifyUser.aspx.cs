using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetManagementProject.BusinessLayer;
using AssetManagementProject.DataLayer;
namespace WebApplication2.Account.Admin
{
    public partial class Admin_ModifyUser : System.Web.UI.Page
    {
        AdminBAL obj = new AdminBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Emp.DataSource = obj.ViewUser();
                Emp.DataTextField = "FirstName";
                Emp.DataValueField = "Emp_ID";
                Emp.DataBind();
                Manager_ID.DataSource = obj.ViewUser();
                Manager_ID.DataTextField = "FirstName";
                Manager_ID.DataValueField = "Emp_ID";
                Manager_ID.DataBind();
                Panel1.Visible = false;
            }
            
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Emp.Text);
            UserDetail ud = obj.GetUserById(eid);
            ud.FirstName = FirstName.Text;
            ud.LastName = LastName.Text;
            ud.Email_ID = Email_ID.Text;
            ud.Designation = Designation.Text;
            ud.Manager_ID = Convert.ToInt32(Manager_ID.SelectedItem.Value);
            ud.Mobile = Mobile_No.Text;
           
            obj.ModifyUser(eid, ud);
            Panel1.Visible = false;
            Status.Text = "Updated";
        }

        protected void S_Click(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Emp.Text);
            try
            {
                Panel1.Visible = true;
                UserDetail ud = obj.GetUserById(eid);
                FirstName.Text = ud.FirstName;
                LastName.Text = ud.LastName;
                Email_ID.Text = ud.Email_ID;
                Designation.Text = ud.Designation;
                Manager_ID.SelectedItem.Value = ud.Manager_ID.ToString();
                Mobile_No.Text = ud.Mobile.ToString();
               
                

            }
            catch (Exception)
            {

                Sts.Text = "invalid Id";
            }
        }

        protected void Deactivate_Click(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Emp.Text);
            UserDetail ud = obj.GetUserById(eid);
            ud.Active = "I";
            obj.ModifyUser(eid, ud);
            Sts.Text = "Deactivated";
        }
    }
}