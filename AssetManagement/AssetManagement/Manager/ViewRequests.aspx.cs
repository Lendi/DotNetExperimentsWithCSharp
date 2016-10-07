using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Asset.BusinessLayer;
using asset.datalayer;
using System.Collections;

namespace AssetManagement.Manager
{
    public partial class Manager_Requests : System.Web.UI.Page
    {
        ManagerBL obj = new ManagerBL();
        ArrayList ar_reqid = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            //gv 1
            int eid = Convert.ToInt32(Session["Eid"]);
            GridView1.DataSource = obj.ViewMyRequest(eid);
            GridView1.DataBind();

            //gv2

            int eid = Convert.ToInt32(Session["Eid"]);
            List<RequestInfo> reqinf = obj.ViewMyRequest(eid);
            List<RequestInfo> fromemp = obj.GetRequests(eid);
            List<TransferHistory> transhis = obj.GetTransferRequest(eid);
            ArrayList ar_Eid = new ArrayList();
            foreach (RequestInfo r in reqinf)
            {
                ar_reqid.Add(r.request_id);
            }
            if (IsPostBack == false)
            {
                if (reqinf != null)
                {
                    GridView1.DataSource = reqinf;
                    GridView1.DataBind();
                }
                if (fromemp != null)
                {
                    GridView2.DataSource = fromemp;
                    GridView2.DataBind();
                }
                if (transhis != null)
                {
                    GridView3.DataSource = transhis;
                    GridView3.DataBind();
                }
                if (reqinf.Count == 0)
                {
                    btnSubmit.Visible = true;
                }
            }



           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
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

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        protected void tbComments_TextChanged(object sender, EventArgs e)
        {

        }

       

       
    }
}