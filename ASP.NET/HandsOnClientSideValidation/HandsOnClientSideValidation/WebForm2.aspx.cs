using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnClientSideValidation
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        int x;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hello" + TextBox1.Text;
            Label1.ForeColor = System.Drawing.Color.Blue;
            x = 10;
            Response.Write(x);
            //set values in view state
            ViewState["k"] = x;
            ViewState["k1"] = new int[] { 12, 23, 34, 45, 56};
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //read value from viewstate; so check if viewstate exists or not
            if(ViewState["k"] != null)
                x = (int)ViewState["k"];
            // View state can maintain page data control data
            //view state can store simple as well as complex data in the form of object
            //while reading, we can convert from obj to int/char/whatever and read it
            //viewstate can store arraylists etc 
            //scope of viewstate and hiddenfield within the page
            //hidden filed used for storing small calues
            Response.Write(x);
        }
    }
}
