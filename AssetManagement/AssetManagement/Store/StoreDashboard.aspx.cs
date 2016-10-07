using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using asset.datalayer;
using Asset.BusinessLayer;

namespace AssetManagement.Store
{
    public partial class StoreDashboard : System.Web.UI.Page
    {
        StoreBL obj = new StoreBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                GridView1.DataSource = obj.ViewRequest();
                GridView1.DataBind();
            }

        }

        protected void lbProfile_Click(object sender, EventArgs e)
        {

        }
    }
}