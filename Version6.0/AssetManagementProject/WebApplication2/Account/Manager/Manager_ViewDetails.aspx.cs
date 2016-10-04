using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetManagementProject.BusinessLayer;

namespace WebApplication2.Account.Manager
{
    public partial class Manager_ViewDetails : System.Web.UI.Page
    {
        ManagerBAL obj = new ManagerBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
            DetailsView1.DataSource = obj.ViewEmployeeDetails(eid);
            DetailsView1.DataBind();
        }
    }
}