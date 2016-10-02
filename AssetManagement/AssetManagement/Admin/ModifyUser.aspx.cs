using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssetManagement.Admin
{
    public partial class ModifyUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            asset.datalayer.AdminDAO obj = new asset.datalayer.AdminDAO();
            
        }
    }
}