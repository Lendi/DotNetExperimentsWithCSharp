using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnDatabBindControls
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            DetailsView1.PageIndex = e.NewPageIndex;
            DetailsView1.DataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        { 
 
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(TextBox1.Text);   
            HandsOnDatabBindControls.DataLayer.EmployeeDAO obj = new DataLayer.EmployeeDAO();
            DetailsView1.DataSource = obj.GetEmpById(eid);
            DetailsView1.DataBind();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //int eid = int.Parse(TextBox1.Text);
            //HandsOnDatabBindControls.DataLayer.EmployeeDAO obj = new DataLayer.EmployeeDAO();
            //DetailsView1.DataSource = obj.DeleteEmployee(eid);
            //DetailsView1.DataBind();

        }

        


    }
}