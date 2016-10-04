using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetManagementProject.BusinessLayer;
using System.Collections;
namespace WebApplication2.Account
{
    public partial class Login : Page
    {
        LoginBAL obj =new  LoginBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string UserName = Username.Text;
            string Password = PassWord.Text;
            ArrayList o = obj.Login_Check(UserName, Password);

            try
            {
                if (UserName == "Admin" && Password == "Admin")
                {
                    Session["Eid"] = "Admin";
                    Response.Redirect(@"~\Account\Admin\Admin_Home.aspx");
                }
                    else if((string)o[1]=="Error")
                {
                    Label3.Text = "invalid Login";
                }
                
                else if ((string)o[1] == "Employee")
                {
                    Session["Eid"] = (int)o[0];
                    Response.Redirect(@"~\Account\Employee\Employee_Home.aspx");
                }
                else if ((string)o[1] == "Manager")
                {
                    Session["Eid"] = (int)o[0];
                    Response.Redirect(@"~\Account\Manager\Manager_Home.aspx");
                }
                else
                {
                    Label3.Text = "invalid Login";
                }
            }
            catch (Exception)
            {


                Label3.Text = "invalid Login";
            }


        }
    }
}