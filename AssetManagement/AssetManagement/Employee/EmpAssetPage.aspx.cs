using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using asset.datalayer;
using Asset.BusinessLayer;

namespace AssetManagement.Employee
{
        public partial class EmpAssetPage : System.Web.UI.Page
    {
            EmployeeBL obj = new EmployeeBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
            if (obj.ViewMyAssets(eid) != null)
            {
                GridView1.DataSource = obj.ViewMyAssets(eid);
                GridView1.DataBind();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}