using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnFormsAuthentication
{
    public partial class DefaultPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack == false)
            //{
            //    System.Web.Security.FormsAuthentication.SignOut();
            //}

            //Page.User.Identity.IsAuthenticated

            if (Page.User.Identity.IsAuthenticated == false) {
                Response.Redirect("Login.aspx");
            }

            Label1.Text = User.Identity.Name; // return authd username
        }

        protected void LinkButtonSignOut_Click(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
            System.Web.Security.FormsAuthentication.RedirectToLoginPage();
            //to remove security token
        }
    }
}