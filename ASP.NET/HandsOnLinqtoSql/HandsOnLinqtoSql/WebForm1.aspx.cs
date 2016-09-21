using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnLinqtoSql
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //creating object to db contect class -> ModelDataContext
            ModelDataContext obj = new ModelDataContext();
            GridView1.DataSource = obj.Employeees;
            GridView1.DataBind();//to bind the data to that control
            // all the LINQ query expressions are converted to SQL queries at runtime, all taken care by ORM
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}