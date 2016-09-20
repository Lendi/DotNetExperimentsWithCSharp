using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnClientSideValidation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int x;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            x = 10;
            //set value in hidden field
            h1.Value = x.ToString();
            Response.Write(x);
            //how inputs are converted to hidden during runtime; input type = hidden 
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            x = int.Parse(h1.Value);
            Response.Write(x);

        }

        protected void h1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}