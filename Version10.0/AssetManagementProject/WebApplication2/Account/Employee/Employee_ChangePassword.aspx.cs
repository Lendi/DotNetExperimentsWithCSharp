using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetManagementProject.BusinessLayer;
namespace WebApplication2.Account.Employee
{
    public partial class Employee_ChangePassword : System.Web.UI.Page
    {
        EmployeeBAL obj = new EmployeeBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
            string Pass = NewPassword.Text;
            obj.ChangePassword(eid, Pass);
            Status.Text = "Succsfully Changed";
            NewPassword.Text = "";
            ConfirmPassword.Text = "";
        }
    }
}