using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetManagementProject.BusinessLayer;
namespace WebApplication2.Account.Manager
{
    public partial class Manager_EmployeesAssets : System.Web.UI.Page
    {
        ManagerBAL obj = new ManagerBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
            GridView1.DataSource = obj.GetMyEmployeesAssets(eid);
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}