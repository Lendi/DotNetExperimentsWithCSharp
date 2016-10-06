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
    public partial class Admin_CreateUser : System.Web.UI.Page
    {
        AdminBAL obj = new AdminBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Manager_ID.DataSource = obj.ViewUser();
                Manager_ID.DataTextField = "FirstName";
                Manager_ID.DataValueField = "Emp_ID";
                Manager_ID.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string First_Name = FirstName.Text;
            string Last_Name = LastName.Text;
            string Mobile = Mobile_No.Text;
            string Short_id = (First_Name[0] + Last_Name).ToUpper();
            string EmailId = Email_ID.Text;
            string Pass = Password.Text;
            string Desig = Designation.Text;
            string Active = "A";
            
            int ManageId = Convert.ToInt32(Manager_ID.SelectedItem.Value);
            DateTime Doj = DateTime.Parse(Date_OF_Joining.Text);
            UserDetail NewUser = new UserDetail();
            NewUser.Active = Active;
            NewUser.DateOfJoining = Doj;
            
            NewUser.Manager_ID = ManageId;
            NewUser.Designation = Desig;
            NewUser.Mobile = Mobile;
            NewUser.Password = Pass;
            NewUser.Short_ID = Short_id;
            NewUser.FirstName = First_Name;
            NewUser.LastName = Last_Name;
            NewUser.Email_ID = EmailId;
            if (obj.CreateUser(NewUser))
            {

                Sts.Text = "Registered succesfully";
            }
            else
            {
                Sts.Text = "Email Already Registerd tryusing different";
            }
        }
    }
}