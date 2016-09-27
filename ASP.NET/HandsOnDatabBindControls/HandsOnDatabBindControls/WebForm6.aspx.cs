using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnDatabBindControls
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        HandsOnDatabBindControls.DataLayer.EmployeeDAO obj = new DataLayer.EmployeeDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView1.DataSource = obj.GetEmployees();
            //GridView1.DataBind();
        }
    }
}