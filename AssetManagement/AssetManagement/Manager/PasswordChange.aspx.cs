using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Asset.BusinessLayer;
using asset.datalayer;

namespace AssetManagement.Manager
{
    public partial class PasswordChange : System.Web.UI.Page
    {
        asset.datalayer.ManagerDAO obj = new asset.datalayer.ManagerDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            user usr = new user();
            int eid = Convert.ToInt32(Session["Eid"]);
            string oldpwd = tbOldPwd.Text;
            string newpwd = tbNewPwd.Text;
            string msg;
            obj.ChangePassword(eid, oldpwd, newpwd, out msg);
            status.Text = msg;
            tbNewPwd.Text = "";
            tbConfirmPwd.Text = "";
        }

        protected void lbPwdChangeCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~\Manager\ManagerPage.aspx");
        }
    }
}