using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnDatabBindControls
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        HandsOnDatabBindControls.DataLayer.EmployeeDAO obj = new DataLayer.EmployeeDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
           

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int eid;
            eid = int.Parse(GridView1.Rows[e.RowIndex].Cells[1].Text); //returns the selected row index 
            obj.DeleteEmployee(eid);
            FillGrid();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillGrid();//have to do this compulsory, else it wont edit
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int eid;
            string ename;
            TextBox sal;
            TextBox hiredate;
            TextBox desig;
            TextBox did;
            eid = int.Parse(GridView1.Rows[e.RowIndex].Cells[1].Text);
            ename = GridView1.Rows[e.RowIndex].Cells[2].Text;
            desig = GridView1.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox;
            sal = GridView1.Rows[e.RowIndex].Cells[4].Controls[1] as TextBox;
            hiredate = GridView1.Rows[e.RowIndex].Cells[5].Controls[2] as TextBox;
            did = GridView1.Rows[e.RowIndex].Cells[6].Controls[3] as TextBox;

            //using object datasource is much better than this


            obj.UpdateEmployee(eid, ename, desig.Text, decimal.Parse(sal.Text), DateTime.Parse(hiredate.Text), did.Text);
            GridView1.EditIndex = -1;//to set grid in normal mode
                FillGrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
    }
}