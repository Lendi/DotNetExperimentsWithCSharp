using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnDatabBindControls
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HandsOnDatabBindControls.DataLayer.EmployeeDAO obj = new DataLayer.EmployeeDAO();
            Repeater1.DataSource = obj.GetEmployees();
            Repeater1.DataBind();
        }
    }
}