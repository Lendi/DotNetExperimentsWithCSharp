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
            List<TranserHistory> th = obj.GetTrasferRequest(eid);
            ArrayList ar_Eid = new ArrayList();
            foreach (RequestTable r in rt)
            {
                ar_reqid.Add(r.Request_ID);
            }
            if (IsPostBack == false)
            {
                if (rt != null)
                {
                    GridView2.DataSource = rt;
                    GridView2.DataBind();
                }
                if (th != null)
                {
                    GridView3.DataSource = th;
                    GridView3.DataBind();
                }
                if (rt.Count == 0)
                {
                    Submit.Visible = true;
                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
            int i = 0,j=0;
            List<RequestTable> rt = obj.GetRequests(eid);
            List<TranserHistory> Th = obj.GetTrasferRequest(eid);
            //CheckBox [] c=new CheckBox[rt.Count];
            //RadioButton[] rb = new RadioButton[rt.Count];
            while (i < rt.Count)
            {
                CheckBox c = GridView2.Rows[i].Cells[0].FindControl("Select") as CheckBox;
                RadioButton ri1 = GridView2.Rows[i].Cells[0].FindControl("Reject") as RadioButton;
                RadioButton ri2 = GridView2.Rows[i].Cells[0].FindControl("SendBack") as RadioButton;
                RadioButton ri3 = GridView2.Rows[i].Cells[0].FindControl("Approve") as RadioButton;
                if (c.Checked == true)
                {
                    if (ri1.Checked == true)
                    {
                        // rb[i] = ri1;
                        int reqid = Convert.ToInt32(rt[i].Request_ID);
                        int emid = Convert.ToInt32(rt[i].Emp_ID);
                        //string comment = TextBox1.Text;
                        int status = 4;
                        obj.PendingRequestApproval(emid, reqid, status);
                    }
                    else if (ri2.Checked == true)
                    {
                        // rb[i] = ri2;
                        int reqid = Convert.ToInt32(rt[i].Request_ID);
                        int emid = Convert.ToInt32(rt[i].Emp_ID);
                        // string comment = TextBox1.Text;
                        int status = 2;
                        obj.PendingRequestApproval(emid, reqid, status);
                    }
                    else if (ri3.Checked == true)
                    {
                        // rb[i] = ri3;
                        int reqid = Convert.ToInt32(rt[i].Request_ID);
                        int emid = Convert.ToInt32(rt[i].Emp_ID);
                        // string comment = TextBox1.Text;
                        int status = 3;
                        obj.PendingRequestApproval(emid, reqid, status);
                    }
                }
                i++;
            }
            //i = 0;
            while (j < Th.Count)
            {
                CheckBox c_t = GridView3.Rows[j].Cells[0].FindControl("Select_1") as CheckBox;
                RadioButton ri1_t = GridView3.Rows[j].Cells[0].FindControl("Reject_t") as RadioButton;
                RadioButton ri2_t = GridView3.Rows[j].Cells[0].FindControl("Approve_t") as RadioButton;
                
                
                if (c_t.Checked == true)
                {
                     int to_emp = Convert.ToInt32(Th[j].To_Emp_ID);
                        int from_emp = Convert.ToInt32(Th[j].From_Emp_ID);
                        int Asset_id = Convert.ToInt32(Th[j].Asset_ID);
                        int status = 0;
                    if (ri1_t.Checked == true)
                    {
                         status = 2;
                    }
                    if (ri2_t.Checked == true)
                    {
                        status = 1;
                    }

                    obj.PendingTrasferRequest(from_emp, to_emp, Asset_id, status);
                    

                }
                j++;
            }
        }

       

       
    }
}

