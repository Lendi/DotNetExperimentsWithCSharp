using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using asset.datalayer;
using Asset.BusinessLayer;

namespace AssetManagement.Employee
{
    public partial class EmpRequestPage : System.Web.UI.Page
    {
        Asset.BusinessLayer.EmployeeBL obj = new Asset.BusinessLayer.EmployeeBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
            string assetname = DropDownList1.Text;
            string justification = tbComments.Text;
            ArrayList al = obj.GetManagerID(eid);
            int mid = Convert.ToInt32(al[0]);
            string uname = al[1].ToString();
            DateTime requested_date = DateTime.Now;
            int status = 2;
            RequestInfo reqinf = new RequestInfo();
            reqinf.asset_name = assetname; //asset name
            reqinf.emp_id = eid; //emp id 
            reqinf.manager_id = mid; //manager id
            reqinf.short_id = uname; //short id
            reqinf.request_status = status; //req status
            reqinf.request_date = requested_date;
            reqinf.remarks = justification;
            obj.CreateRequest(reqinf);
            RequestSubmission.Text = "Request Sent!!";
            
        }

        protected void lbRequests_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}