using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnServersideStateManagement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            string uname = TextBox1.Text;
            //set value in session

            //Session["un"] = uname; //session[keyname] = value;
                //session is the object of http session class
            System.Collections.ArrayList ar = new System.Collections.ArrayList() {"Rose", "Lilly", "Sunflower" };
            Session["flr"] = ar;//session can store simple as well as complex data

            Application.Add("un", uname );

            Response.Redirect("Page2.aspx");
        }
    }
}