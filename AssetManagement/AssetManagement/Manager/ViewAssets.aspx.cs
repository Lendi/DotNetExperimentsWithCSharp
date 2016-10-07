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
    public partial class Manager_Assets : System.Web.UI.Page
    {
        ManagerBL obj = new ManagerBL();

        protected void Page_Load(object sender, EventArgs e)
        {

            int eid = Convert.ToInt32(Session["Eid"]);

            if (obj.ViewMyAssets(eid) != null)
            {
                GridView1.DataSource = obj.ViewMyAssets(eid);
                GridView1.DataBind();
            }

            if (obj.GetEmployeesAssets(eid) != null)
            {
                GridView2.DataSource = obj.GetEmployeesAssets(eid);
                GridView2.DataBind();
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lbRequests_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~\Manager\ViewRequests.aspx");
        }

        protected void lbProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~\Manager\ManagerPage.aspx");
        }

        protected void lbAssets_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~\Manager\ViewAssets.aspx");
        }

        protected void lbProfile_Click1(object sender, EventArgs e)
        {
            Response.Redirect(@"~\Manager\ViewAssets.aspx");
        }
    }
}