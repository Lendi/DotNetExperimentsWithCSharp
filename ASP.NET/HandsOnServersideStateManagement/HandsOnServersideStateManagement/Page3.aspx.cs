using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnServersideStateManagement
{
    public partial class Page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = Session["un"].ToString();
            Label1.Text = Application["un"].ToString();
            //cannot use session data for multiple browser sessions 
            //once browser closed, we cannot read session data
            //cookies exist thoughout
            
            }
        }
    }
