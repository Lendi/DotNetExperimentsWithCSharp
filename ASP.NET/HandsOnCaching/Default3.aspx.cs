using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string str = DateTime.Now.ToString();
        if (Cache["k"] == null)
        {
            Label1.Text = "New Version";
            //add data to cache

            Cache.Insert("k", str, null, DateTime.Now.AddSeconds(40), System.Web.Caching.Cache.NoSlidingExpiration);
        }
        else
            Label1.Text = "Cache Version";
        Label2.Text = Cache["k"].ToString();//reading value
        Label3.Text = DateTime.Now.ToString();
    }
}