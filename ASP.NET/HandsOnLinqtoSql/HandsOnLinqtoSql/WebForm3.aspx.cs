using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnLinqtoSql
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        ModelDataContext obj = new ModelDataContext();//why?
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //need to get dropdown list data
            if (Page.IsPostBack == false)
            {//if this condition not given, for every request to the page is reloaded
                ddlDid.DataSource = obj.Depts;
                ddlDid.DataTextField = "Dname";// user sees ful forms like banking and Finance
                ddlDid.DataValueField = "Did";// but when he selects Banking and finance, BFS gets stored
                ddlDid.DataBind(); //at max how many stored in dropdownlist? A. 2
            }
            Response.Write(Page.IsPostBack);
            //for everypost back request, 
            //post back request --> reqests to server
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {//when u drag n drop table, its class is created, thus suggesting Employeee in any webform
            Employeee objEmp = new Employeee();
            objEmp.Eid = int.Parse(tbID.Text);
            objEmp.Ename = tbEname.Text;
            objEmp.Desig = tbDesig.Text;
            objEmp.hiredate = DateTime.Parse(tbHiredate.Text);
            objEmp.Sal = decimal.Parse(tbSal.Text);

            //below obj.Employeees is the datasource
            obj.Employeees.InsertOnSubmit(objEmp);//insert record into table
            // to updarte ur data context, we use the method below
            //while inserting, updating, deleting, we need to call it so the changes are reflected in db
            obj.SubmitChanges();//update data context
            Label1.Text = "Record is added!";

           
        }
    }
}