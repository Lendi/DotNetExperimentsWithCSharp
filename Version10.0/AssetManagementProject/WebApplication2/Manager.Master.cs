using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetManagementProject.BusinessLayer;
using AssetManagementProject.DataLayer;
namespace WebApplication2.Account.Manager
{
    public partial class Manager : System.Web.UI.MasterPage
    {
        ManagerBAL obj = new ManagerBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
            List<UserDetail> ud = obj.ViewEmployeeDetails(eid);
            string uname = ud[0].FirstName + " " + ud[0].LastName;
            Username.Text = uname;
            if (Session["Eid"] == null)
            {
                Response.Redirect(@"~\Account\Login.aspx");
            }
            //int eid = Convert.ToInt32(Session["Eid"]);
            int count = obj.GetRequests(eid).Count + obj.GetTrasferRequest(eid).Count;
            Count.Text = count.ToString();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect(@"~\Account\Login.aspx");
        }
    }
}