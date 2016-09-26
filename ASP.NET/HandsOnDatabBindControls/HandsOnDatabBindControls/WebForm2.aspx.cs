using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnDatabBindControls
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HandsOnDatabBindControls.DataLayer.EmployeeDAO obj = new DataLayer.EmployeeDAO();
            GridView1.DataSource = obj.GetEmployees();
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //set page index
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}