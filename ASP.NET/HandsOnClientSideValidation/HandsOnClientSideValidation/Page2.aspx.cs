using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnClientSideValidation
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = Request.QueryString["un"];
            //to stop exception
            if(Request.Cookies["un"]!=null)
            Label1.Text = Request.Cookies["un"].Value;

        }
    }
}