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
            if (IsPostBack == false)
            {
                int eid = Convert.ToInt32(Session["Eid"]);
                if (obj.ViewMyAssets(eid) != null)
                {
                    GridView1.DataSource = obj.ViewMyAssets(eid);
                    GridView1.DataBind();
                }
                if (obj.GetAllEmployees(eid) != null)
                {
                    EmpId.DataSource = obj.GetAllEmployees(eid);
                    EmpId.DataTextField = "FirstName";
                    EmpId.DataValueField = "Emp_ID";
                    EmpId.DataBind();
                }
                if (obj.ViewMyAssets(eid) != null)
                {
                    AssetNameDDL.DataSource = obj.ViewMyAssets(eid);
                    AssetNameDDL.DataTextField = "AssetName";
                    AssetNameDDL.DataValueField = "Asset_ID";
                    AssetNameDDL.DataBind();
                }
                if (AssetNameDDL.Items.Count == 0)
                {
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    EmpId.Visible = false;
                    TextBox1.Visible = false;
                    Submit.Visible = false;
                    AssetNameDDL.Visible = false;
                   
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int From_Eid = Convert.ToInt32(Session["Eid"]);
            int To_Eid = Convert.ToInt32(EmpId.SelectedItem.Value);
            int Asset_id = Convert.ToInt32(AssetNameDDL.SelectedItem.Value);
            string Comments = TextBox1.Text;
            if (obj.TransferRequest(From_Eid, To_Eid, Asset_id, Comments))
            {
                Label3.Text = "Succesfully submitted request";
                GridView1.DataSource = obj.ViewMyAssets(From_Eid);
                GridView1.DataBind();
            }
            else
            {
                Label3.Text = "Invalid employee Number";
            }
        }
    }
}