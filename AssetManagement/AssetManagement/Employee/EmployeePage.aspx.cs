using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Asset.BusinessLayer;

namespace AssetManagement.Employee
{
	public partial class EmployeePage : System.Web.UI.Page
	{
        asset.datalayer.EmployeeDAO obj = new asset.datalayer.EmployeeDAO();
		protected void Page_Load(object sender, EventArgs e)
		{
            int eid = Convert.ToInt32(Session["Eid"]);
            DetailsView1.DataSource = obj.ViewEmployeeDetails(eid);
            DetailsView1.DataBind();

		}
	}
}