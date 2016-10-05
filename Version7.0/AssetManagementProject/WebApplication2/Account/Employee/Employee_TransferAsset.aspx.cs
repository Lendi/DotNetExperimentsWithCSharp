using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetManagementProject.BusinessLayer;
namespace WebApplication2.Account.Employee
{
    public partial class Employee_TrasferAsset : System.Web.UI.Page
    {
        EmployeeBAL obj = new EmployeeBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
            GridView1.DataSource = obj.ViewMyAssets(eid);
            GridView1.DataBind();
            AssetNameDDL.DataSource = obj.ViewMyAssets(eid);
            AssetNameDDL.DataTextField = "AssetName";
            AssetNameDDL.DataValueField = "Asset_ID";
            AssetNameDDL.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int From_Eid = Convert.ToInt32(Session["Eid"]);
            int To_Eid = Convert.ToInt32(To_EmpId.Text);
            int Asset_id = Convert.ToInt32(AssetNameDDL.SelectedItem.Value);
            if (obj.TransferRequest(From_Eid, To_Eid, Asset_id))
            {
                Label3.Text = "Succesfully submitted request";
            }
            else
            {
                Label3.Text = "Invalid employee Number";
            }
        }
    }
}