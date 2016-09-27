using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnDatabBindControls
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        HandsOnDatabBindControls.DataLayer.EmployeeDAO obj = new DataLayer.EmployeeDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                GridView1.DataSource = obj.GetEmployees();
                GridView1.DataBind();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            CheckBox ch = null;
            for (int i = 0; i < GridView1.Rows.Count; i++) {

                ch =  GridView1.Rows[i].Cells[0].FindControl("CheckBox1") as CheckBox;
                if (ch.Checked) {
                    int eid = int.Parse(GridView1.Rows[i].Cells[1].Text);
                    Response.Write(eid);
                    //obj.DeleteEmployee();
                }
                //ch = GridView1.Rows[i].Cells[0].FindControl("CheckBox1");
            
            }
        }
    }
}