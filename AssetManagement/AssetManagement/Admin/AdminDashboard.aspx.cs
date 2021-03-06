﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using asset.datalayer;
using Asset.BusinessLayer;

namespace AssetManagement.Admin
{
    public partial class AdminDashboard1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void lbCreateUser_Click(object sender, EventArgs e)
        {
            
            Server.Transfer("/Admin/CreateUser.aspx");
        }

        protected void lbViewUser_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/ViewUsers.aspx");
        }

        protected void lbViewUsers_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/ViewUsers.aspx");
        }
    }
}