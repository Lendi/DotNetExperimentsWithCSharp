using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using AssetManagementProject.BusinessLayer;
using AssetManagementProject.DataLayer;
namespace WebApplication2.Account.Employee
{
    public partial class Employee_AssetRequest : System.Web.UI.Page
    {
        EmployeeBAL obj = new EmployeeBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
            ArrayList list = new ArrayList() { "Mobile", "Sim", "Laptop", "DataCard" };
            if (obj.ViewMyAssets(eid) != null)
            {
                List<AssetTable> asset = obj.ViewMyAssets(eid);
                foreach (AssetTable a in asset)
                {
                    if (a.AssetName == "Mobile")
                    {
                        list.Remove("Mobile");
                    }
                    if (a.AssetName == "Laptop")
                    {
                        list.Remove("Laptop");
                    }
                    if (a.AssetName == "DataCard")
                    {
                        list.Remove("DataCard");
                    }
                    if (a.AssetName == "Sim")
                    {
                        list.Remove("Sim");
                    }
                }
            }
           AssetsList.DataSource = list;
           AssetsList.DataBind();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int eid=Convert.ToInt32(Session["Eid"]);
            string Comment=Comments.Text;
           string AssetName = AssetsList.Text;
           ArrayList a = obj.GetManagerID(eid);
           int Manager_id =Convert.ToInt32(a[0]);
           string Short_Id = a[1].ToString();
           DateTime Requestdate = DateTime.Now;
           int status = 1;
           RequestTable rt = new RequestTable();
           rt.AssetName = AssetName;
           rt.Emp_ID = eid;
           rt.Manager_ID = Manager_id;
           rt.Short_ID = Short_Id;
           rt.Status = status;
           rt.RequestDate = Requestdate;
           rt.Remarks_Comment = Comment;
           obj.CreateAssetRequest(rt);
           sts.Text = "Request submitted";

        }
    }
}