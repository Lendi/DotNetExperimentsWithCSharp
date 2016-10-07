using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using asset.datalayer;
using Asset.BusinessLayer;

namespace AssetManagement.Admin
{
    public partial class ModifyUser : System.Web.UI.Page
    {
        asset.datalayer.AdminDAO obj = new asset.datalayer.AdminDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false) {
                FillGrid();
            }
            
            
        }

        private void FillGrid()
        {
            GridView1.DataSource = obj.ViewUsers();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillGrid();
            
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int eid;
            string sid;
            eid = int.Parse(((GridView1.Rows[e.RowIndex].Cells[1].FindControl("LinkButton1")) as LinkButton).Text);
            sid = GridView1.Rows[e.RowIndex].Cells[2].Text; //returns the selected row index 
            obj.DeleteUser(eid);
            FillGrid();

        }

       // protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
      //  {

       // }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int eid;//1 
            string sid;//2 
            TextBox fname;//3 c
            TextBox lname;//4 c
            TextBox email;//5 c
            TextBox pwd;//6 c
            TextBox mid; //7 c
            DropDownList desig;//8 c
            TextBox phno;//9 c
            DateTime doj;//10 
            DropDownList active;//11 c
            eid =int.Parse(((GridView1.Rows[e.RowIndex].Cells[1].FindControl("LinkButton1"))as LinkButton).Text);
            sid = ((GridView1.Rows[e.RowIndex].Cells[2].FindControl("Label1") as Label).Text);
            fname = ((GridView1.Rows[e.RowIndex].Cells[3].FindControl("TextBox1")) as TextBox);
            lname = ((GridView1.Rows[e.RowIndex].Cells[4].FindControl("TextBox2")) as TextBox);
            email = ((GridView1.Rows[e.RowIndex].Cells[5].FindControl("TextBox3")) as TextBox);
            pwd = ((GridView1.Rows[e.RowIndex].Cells[6].FindControl("TextBox5")) as TextBox);
            mid = ((GridView1.Rows[e.RowIndex].Cells[7].FindControl("TextBox6")) as TextBox);
            desig = ((GridView1.Rows[e.RowIndex].Cells[8].FindControl("DropDownList1")) as DropDownList);
            phno = ((GridView1.Rows[e.RowIndex].Cells[9].FindControl("TextBox7")) as TextBox);
            //doj = DateTime.Parse(GridView1.Rows[e.RowIndex].Cells[10].Text);          
            doj = DateTime.Parse(((GridView1.Rows[e.RowIndex].Cells[10].FindControl("Label11") as Label).Text));
            active = ((GridView1.Rows[e.RowIndex].Cells[11].FindControl("DropDownList2")) as DropDownList);
            obj.ModifyUser(eid, sid, fname.Text, lname.Text, email.Text, pwd.Text, int.Parse(mid.Text), 
                desig.SelectedValue , int.Parse(phno.Text), doj, active.SelectedValue);
            GridView1.EditIndex = -1;//to set grid in normal mode
            
            FillGrid();

            

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void lbCreateUser_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/CreateUser.aspx");
        }

        protected void lbModifyUser_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/ModifyUser.aspx");
        }

        protected void lbDeactivateUser_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/ModifyUser.aspx");
        }

        protected void lbViewUsers_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/ViewUsers.aspx");
        }

        protected void lbChangePwd_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/ModifyUser.aspx");
        }

        protected void lbViewUsers_Click1(object sender, EventArgs e)
        {
            Server.Transfer("/Admin/ViewUsers.aspx");
        }

       

    }
}