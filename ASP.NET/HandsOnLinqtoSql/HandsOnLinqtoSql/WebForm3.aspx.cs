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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(tbID.Text);
            //one record is returned
            Employeee objEmp = (from emp in obj.Employeees
                       where emp.Eid == eid select emp).SingleOrDefault();//extension method used
            //from the given extension, singleordefault returns a single record
            //if returns more than one rec, it returns an exception
            // single Vs singleOrdefault --> 

            if (objEmp != null)
            {
                tbEname.Text = objEmp.Ename;
                tbDesig.Text = objEmp.Desig;
                tbHiredate.Text = objEmp.hiredate.ToString();
                tbSal.Text = objEmp.Sal.ToString();
                ddlDid.Text = objEmp.Did;
            }
            else
                Label1.Text = "Invalid ID";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(tbID.Text);
            Employeee objEmp = (from emp in obj.Employeees
                                where emp.Eid == eid
                                select emp).SingleOrDefault();

            objEmp.Sal = decimal.Parse(tbSal.Text);
            obj.SubmitChanges();
            Label1.Text = "Record Updated!";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(tbID.Text);
            Employeee objEmp = (from emp in obj.Employeees
                                where emp.Eid == eid
                                select emp).SingleOrDefault();

            obj.Employeees.DeleteOnSubmit(objEmp);
            obj.SubmitChanges();
            Label1.Text = "Record Deleted!";

        }
    }
}