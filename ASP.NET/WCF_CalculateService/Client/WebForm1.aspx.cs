using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Calculate client is a proxy class
        CalculateServiceReference.CalculateClient obj = new CalculateServiceReference.CalculateClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            int i = int.Parse(TextBox1.Text);
            int j = int.Parse(TextBox2.Text);
            int k = obj.Add(i, j);
            Label1.Text = k.ToString();
        }

        protected void ButtonDiv_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(TextBox1.Text);
                int j = int.Parse(TextBox2.Text);
                int k = obj.Div(i, j);
                Label1.Text = k.ToString();
            }
            catch (Exception ex) {
                Label1.Text = ex.Message;
            }
        }
    }
}