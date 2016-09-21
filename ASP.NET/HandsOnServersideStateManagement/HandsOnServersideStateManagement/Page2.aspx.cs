using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnServersideStateManagement
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Application["un"] != null)
            {
                Label1.Text = Application["un"].ToString();

            }
            else
                Response.Redirect("Webform1.aspx");
            //if (Session["un"] != null)
            //{

            //    Label1.Text = Session["un"].ToString();
            //    foreach (string s in (System.Collections.ArrayList)Session["flr"])
            //    {
            //        Response.Write(s + "<br>");
            //    }
            //}
            //else Response.Redirect("Webform1.aspx");
        }

        protected void btnClickPg3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Page3.aspx");
            
        }
    }
}