using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using asset.datalayer;
using Asset.BusinessLayer;

namespace AssetManagement.Employee
{
    public partial class PasswordChange : System.Web.UI.Page
    {
        asset.datalayer.EmployeeDAO obj = new asset.datalayer.EmployeeDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbOldPwd_TextChanged(object sender, EventArgs e)
        {

        }

/*        protected void lbPwdChangeCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Employee/EmployeePage.aspx");
        }*/

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            user usr = new user();
            usr.emp_id = Convert.ToInt32(Session["Eid"]);

            if (tbOldPwd.Text != usr.user_password) {
                Label5.Text = "Denied! Wrong Password";
            }
            else
                { 
                if(tbNewPwd != tbConfirmPwd){
                Label4.Text = "Passwords do not match!!";
                }
                else{        
   
                        usr.user_password = tbNewPwd.Text;
                        obj.ChangePassword(usr.emp_id , usr);
                        Label4.Text = "New Password Set!";
                }
                    }
                    
                
                }

/*        protected void lbPwdChangeCancel_Click(object sender, EventArgs e)
        {
        
        }*/
        }
    }
}