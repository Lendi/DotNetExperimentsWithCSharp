using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnDatabBindControls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HandsOnDatabBindControls.DataLayer.EmployeeDAO obj = new DataLayer.EmployeeDAO();
            GridView1.DataSource = obj.GetEmployees();
            GridView1.DataBind();

            //web.config we are using to maintain connection. connection string auto generated in linq to sql
        }
    }
}