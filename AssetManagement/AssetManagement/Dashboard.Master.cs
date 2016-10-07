using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using asset.datalayer;
using Asset.BusinessLayer;

namespace AssetManagement
{
    public partial class Dashboard : System.Web.UI.MasterPage
    {
        Asset.BusinessLayer.EmployeeBL obj = new Asset.BusinessLayer.EmployeeBL();
        protected void Page_Load(object sender, EventArgs e)
        {
         
            if (Session["Eid"] == null)
            {
                Response.Redirect(@"~\Login\Login.aspx");
            }


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect(@"~\Login\Login.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect(@"~\Login\Login.aspx");

        }
    }
}