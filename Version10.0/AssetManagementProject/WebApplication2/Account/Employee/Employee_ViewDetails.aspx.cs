﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetManagementProject.BusinessLayer;
namespace WebApplication2.Account.Employee
{
    public partial class Employee_ViewDetails : System.Web.UI.Page
    {
        EmployeeBAL obj = new EmployeeBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["Eid"]);
            if (obj.ViewEmployeeDetails(eid) != null)
            {
                DetailsView1.DataSource = obj.ViewEmployeeDetails(eid);
                DetailsView1.DataBind();
            }
        }
    }
}