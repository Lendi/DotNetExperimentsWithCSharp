using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Asset.BusinessLayer;
using asset.datalayer;

namespace AssetManagement.Manager
{
    public partial class ManagerPage : System.Web.UI.Page
    {
        asset.datalayer.EmployeeDAO obj = new asset.datalayer.EmployeeDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            

        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
            if (obj.ViewEmployeeDetails(eid) != null)
            {
                DetailsView1.DataSource = obj.ViewEmployeeDetails(eid);
                DetailsView1.DataBind();
            }
        }

        protected void lbChangePwd_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~\Manager\PasswordChange.aspx");
        }

        protected void lbProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~\Manager\ManagerPage.aspx");
        }

        protected void lbRequests_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~\Manager\ViewRequests.aspx");
        }

        protected void lbAssets_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~\Manager\ViewAssets.aspx");
        }
    }
}