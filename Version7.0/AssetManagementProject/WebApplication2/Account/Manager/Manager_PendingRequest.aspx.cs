using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetManagementProject.DataLayer;
using AssetManagementProject.BusinessLayer;
using System.Collections;
namespace WebApplication2.Account.Manager
{
    public partial class Manager_PendingRequest : System.Web.UI.Page
    {
        ManagerBAL obj = new ManagerBAL();
        ArrayList ar_reqid = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
          //   usrlist = obj.GetMyEmployeesAssets(eid);
            List<RequestTable> rt = obj.GetRequests(eid);
            ArrayList ar_Eid = new ArrayList();
           
            
            
            //foreach (UserDetail k in usrlist)
            //{
            //    ar_Eid.Add(k.Emp_ID);
               
            //}
            foreach (RequestTable r in rt)
            {
                ar_reqid.Add(r.Request_ID);
            }
            if (IsPostBack == false)
            {
                GridView2.DataSource = rt;
                GridView2.DataBind();
                DropDownList1.DataSource = obj.GetMyEmployees(eid);
                DropDownList1.DataTextField = "FirstName";
                DropDownList1.DataValueField = "Emp_ID";

                DropDownList1.DataBind();

                DropDownList2.DataSource = ar_reqid;
                DropDownList2.DataBind();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            
            if (Reject.Checked == true)
            {
                int reqid = Convert.ToInt32(DropDownList2.Text);
                int emid = Convert.ToInt32(DropDownList1.SelectedItem.Value);
                string comment = TextBox1.Text;
                int status = 4;
                obj.PendingRequestApproval(emid, reqid, status, comment);
                int eid = Convert.ToInt32(Session["Eid"]);
                GridView2.DataSource = obj.GetRequests(eid);

                GridView2.DataBind();
            }
            if (Accept.Checked == true)
            {
                int reqid = Convert.ToInt32(DropDownList2.Text);
                int emid = Convert.ToInt32(DropDownList1.SelectedItem.Value);
                string comment = TextBox1.Text;
                int status = 5;
                obj.PendingRequestApproval(emid, reqid, status, comment);
                int eid = Convert.ToInt32(Session["Eid"]);
                GridView2.DataSource = obj.GetRequests(eid);

                GridView2.DataBind();
            }
        }

       

        
    }
}