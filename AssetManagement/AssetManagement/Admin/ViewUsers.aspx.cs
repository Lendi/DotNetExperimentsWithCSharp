using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssetManagement.Admin
{
    public partial class ViewUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            asset.datalayer.AdminDAO obj = new asset.datalayer.AdminDAO();
            Repeater1.DataSource = obj.ViewUsers();
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            
        }

        protected void lbCreateUser_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/CreateUser.aspx");
        }

        protected void lbModifyUser_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/ModifyUser.aspx");
        }

        protected void lbDeactivateUser_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/ModifyUser.aspx");
        }

        protected void lbChangePwd_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/ModifyUser.aspx");
        }

        protected void lbViewUser_Click(object sender, EventArgs e)
        {

        }

        protected void lbViewUsers_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/ViewUsers.aspx");
        }

        protected void lbViewUsers_Click1(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/ViewUsers.aspx");
        }
    }
}