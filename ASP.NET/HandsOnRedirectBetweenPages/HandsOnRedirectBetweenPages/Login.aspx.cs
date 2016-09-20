using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnRedirectBetweenPages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uname = tbUname.Text;
            string pwd = tbPwd.Text;
            if(uname == "David" && pwd =="12345")
            {
            //Server.Transfer("welcome.aspx");//can read prev page data

                Response.Redirect("welcome.aspx");//response.redirect changes the url.
                //we cannot read prev page data
            }
            else
                labelLoginPage.Text = "Invalid User";
        }
    }
}