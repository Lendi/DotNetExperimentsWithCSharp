using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnClientSideValidation
{
    //send one page data to another page, 
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            //Response.Redirect("Page2.aspx?un="+name+"&fg=0");
            //query string is also a client side state management technique
            //a query strig is a collection of name-value pairs appending to end of the url
            //Server.Transfer("Page2.aspx?un=" + name + "&fg=0");
            //the above line doesnt let the values reflect in the URL so all values are hidden and safe


            //set value in cookie
            Response.Cookies["un"].Value = name;
            Response.Cookies["un"].Expires = System.DateTime.Now.AddDays(5);
            Response.Redirect("Page2.aspx");
            //on same website only cookies are used
            //cookies are stored based on the website
        }
    }
}