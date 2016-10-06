using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetManagementProject.BusinessLayer;
using AssetManagementProject.DataLayer;
namespace WebApplication2.Account.Store
{
    public partial class Store_ViewRequest : System.Web.UI.Page
    {
        StoreBAL obj = new StoreBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                GridView1.DataSource = obj.ViewRequest();
                GridView1.DataBind();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<RequestTable> rt = obj.ViewRequest();
            while (i < rt.Count)
            {
                CheckBox c = GridView1.Rows[i].Cells[0].FindControl("Select") as CheckBox;
                RadioButton ri1 = GridView1.Rows[i].Cells[0].FindControl("Reject") as RadioButton;
                RadioButton ri2 = GridView1.Rows[i].Cells[0].FindControl("Approve") as RadioButton;
                if (c.Checked == true)
                {
                    int reqid = Convert.ToInt32(rt[i].Request_ID);
                    int status = 5;
                    if (ri1.Checked == true)
                    {
                         status = 6;
                    }
                    
                    obj.ApproveRequest(reqid, status);
                }
                i++;
            }
        }
    }
}