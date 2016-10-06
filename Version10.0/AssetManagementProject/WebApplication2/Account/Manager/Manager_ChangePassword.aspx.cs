using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetManagementProject.BusinessLayer;
namespace WebApplication2.Account.Manager
{
    public partial class Manager_ChangePassword : System.Web.UI.Page
    {
        ManagerBAL obj = new ManagerBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
            string Pass = NewPassword.Text;
            obj.ChangePassword(eid, Pass);
            NewPassword.Text = "";
            ConfirmPassword.Text = "";
        }
    }
}