using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayRoll.BusinessLayer;
using PayRoll.DataLayer;

namespace PayRoll.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        EmployeeBAL obj = new EmployeeBAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = obj.GetEmpDetails();
            GridView1.DataBind();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(tbID.Text);
            Employee objEmployee = obj.GetEmpById(eid);

            if (objEmployee != null)
            {
                tbEname.Text = objEmployee.Ename;
                tbDesig.Text = objEmployee.Desig;
                //tbHiredate.Text = objEmp.hiredate.ToString();
                tbHiredate.TextMode = TextBoxMode.SingleLine;
                tbHiredate.Text = objEmployee.hiredate.Value.ToShortDateString();
                tbSal.Text = objEmployee.Sal.ToString();
                tbDid.Text = objEmployee.Did;
            }
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Employee objEmployee = new Employee();
            objEmployee.Eid = int.Parse(tbID.Text);
            objEmployee.Ename = tbEname.Text;
            objEmployee.Desig = tbDesig.Text;
            objEmployee.Sal = decimal.Parse(tbSal.Text);
            objEmployee.hiredate = DateTime.Parse(tbHiredate.Text);

            obj.AddEmployee(objEmployee);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(tbID.Text);
            Employee objEmployee = new Employee();
            objEmployee.Ename = tbEname.Text;
            objEmployee.Desig = tbDesig.Text;            
            objEmployee.Sal = decimal.Parse(tbSal.Text);
            objEmployee.hiredate = DateTime.Parse(tbHiredate.Text);
            objEmployee.Did = tbDid.Text;
            
            obj.UpdateEmployee(eid, objEmployee);

            //objEmployee.Ename = tbEname.Text;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(tbID.Text);
            Employee objEmployee = new Employee();

            obj.DeleteEmployee(eid);
        }
    }
}