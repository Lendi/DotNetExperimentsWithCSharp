using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnLinqtoSql
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //to display employeee ID, his name, and his Dept name (working using 2 tables)
            using(ModelDataContext obj = new ModelDataContext())//creating object first 
            {//using is used because after coming from this block of code, objects get disposed 
                var res = from e1 in obj.Employeees
                          join
                          d1 in obj.Depts
                          on e1.Did equals d1.Did
                          select new { e1.Eid, e1.Ename, d1.Dname };// these are called anonymous objects, which are created without a class
                GridView1.DataSource = res;
                GridView1.DataBind();
            }
            

        }
    }
}