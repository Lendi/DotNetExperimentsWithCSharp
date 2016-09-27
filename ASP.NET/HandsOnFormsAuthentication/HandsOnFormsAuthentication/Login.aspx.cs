using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


namespace HandsOnFormsAuthentication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string uname = tbUname.Text;
            string pwd = tbPwd.Text;

            if (FormsAuthentication.Authenticate(uname, pwd)) {

                FormsAuthentication.RedirectFromLoginPage(uname, true);
                //when persistent cookie true, the uname saved in cookie automatically            
            }
            else
                Label1.Text = "Invalid User";
        }
    }
}