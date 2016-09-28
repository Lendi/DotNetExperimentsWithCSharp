using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnDatabBindControls
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(FileUploadBrowse.HasFile){
                string filename = FileUploadBrowse.FileName;
                ViewState["k"] = filename;                
                string path = Server.MapPath(@"\Images\") + filename; // mappath returns physical path of website
                Response.Write(path);
                FileUploadBrowse.SaveAs(path);
                Image1.ImageUrl = "~/Images/"+filename;
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(TextBox1.Text);
            string profilename = ViewState["k"].ToString();
            HandsOnDatabBindControls.DataLayer.EmployeeDAO obj = new DataLayer.EmployeeDAO();
            obj.UpdateImage(eid, profilename);

        }
    }
}