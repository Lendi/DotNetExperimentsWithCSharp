using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnRedirectBetweenPages
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        // B1 returns 10, B2 returns 0
        //the object WebForm2 is created everytime a request is sent
        static int a;// maknig this static will share the value throughout whole class
        // but the problem with static is, same data is used for all users

        //
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            a = 10;
            Response.Write(a);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write(a);
        }
    }
}