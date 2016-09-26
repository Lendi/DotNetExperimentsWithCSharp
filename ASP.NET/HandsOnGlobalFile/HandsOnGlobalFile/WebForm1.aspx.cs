using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnGlobalFile
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        protected void Page_Error(object sender, EventArgs e) {
            Exception obj = Server.GetLastError();
            Context.ClearError();//clear error in server
            string msg = obj.GetBaseException().Message;
            Response.Write(msg);        
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                byte a = byte.Parse(TextBox1.Text);
                byte b = byte.Parse(TextBox2.Text);
                int c = a / b;
                Label1.Text = "Division =" + c;
            }
            catch (DivideByZeroException ex)
            {
                string msg = ex.Message;
                Server.Transfer("Error.aspx?err=" + msg);
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}