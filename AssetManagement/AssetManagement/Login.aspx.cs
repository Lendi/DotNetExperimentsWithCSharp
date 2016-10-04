using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Asset.BusinessLayer;
using System.Collections;

namespace AssetManagement
{
    public partial class Login : System.Web.UI.Page
    {
        LoginBL obj = new LoginBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = tbUname.Text;
            string password = tbPwd.Text;
            ArrayList al = obj.LoginDetails(uname, password);

            try
            {
                if (uname == "Admin" && password == "Admin")
                {
                    Session["Eid"] = "Admin";
                    Response.Redirect(@"~\Admin\AdminDashboard.aspx");
                }
                else if ((string)al[1] == "err")
                {
                    Label1.Text = "Invalid Login";
                }

                else if ((string)al[1] == "Employee")
                {
                    Session["Eid"] = (int)al[0];
                    Response.Redirect(@"~\Employee\EmployeePage.aspx");
                }
                else if ((string)al[1] == "Manager")
                {
                    Session["Eid"] = (int)al[0];
                    Response.Redirect(@"~\Manager\ManagerDashboard.aspx");
                }
                else
                {
                    Label1.Text = "Invalid Login";
                }
            }
            catch (Exception)
            {


                Label1.Text = "Invalid Login";
            }

        }
    }
}