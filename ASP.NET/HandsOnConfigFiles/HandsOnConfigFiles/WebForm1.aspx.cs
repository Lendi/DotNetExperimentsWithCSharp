using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace HandsOnConfigFiles
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
                (ConfigurationManager.ConnectionStrings["CSCDBConnection"].ConnectionString );

            Label1.Text = ConfigurationManager.AppSettings["Pending"].ToString();//using keyname we are fetching value
            int count = ConfigurationManager.AppSettings.Count;
            for (int i = 0; i < count; i++) {
                DropDownList1.Items.Add(ConfigurationManager.AppSettings[i].ToString());//using value we are fetching values
            }
        }
    }
}