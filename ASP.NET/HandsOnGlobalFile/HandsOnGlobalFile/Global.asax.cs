//!!!!!!!!! NEVER RENAME A GLOBAL.ASAX FILE!!!!!!!!!! WONT RUN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace HandsOnGlobalFile
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //Exception obj = Server.GetLastError();
            //Context.ClearError();//clear error in server
            //string msg = obj.GetBaseException().Message;
            //Server.Transfer("Error.aspx?err=" +msg);
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}