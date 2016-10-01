using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace client
{
    public partial class _Default : System.Web.UI.Page
    {
        CalculateServiceReference.calculateSoapClient obj = new CalculateServiceReference.calculateSoapClient();//we can access all service functinoality

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int i = int.Parse(TextBox1.Text);
            int j = int.Parse(TextBox2.Text);
            int k = obj.Add(i, j);
            Label1.Text = "Addition = " + k;
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            int i = int.Parse(TextBox1.Text);
            int j = int.Parse(TextBox2.Text);
            int k = obj.Sub(i, j);
            Label1.Text = "Subtraction = " + k;
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            int i = int.Parse(TextBox1.Text);
            int j = int.Parse(TextBox2.Text);
            int k = obj.Mul(i, j);
            Label1.Text = "Multiplication = " + k;
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            int i = int.Parse(TextBox1.Text);
            int j = int.Parse(TextBox2.Text);
            int k = obj.Div(i, j);
            Label1.Text = "Division = " + k;
        }


    }
}