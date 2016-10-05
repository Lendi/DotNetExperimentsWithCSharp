using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetManagementProject.BusinessLayer;
namespace WebApplication2.Account.Admin
{
    public partial class Admin_ViewUsers : System.Web.UI.Page
    {
        AdminBAL obj = new AdminBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = obj.ViewUser();
            GridView1.DataBind();
        }
    }
}