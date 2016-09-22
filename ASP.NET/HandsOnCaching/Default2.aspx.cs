using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string culture = DropDownList1.SelectedItem.Value;
        //text has country name value has culture name

        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
        System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);

        Label1.Text = string.Format("{0:C}", 123);
        Label2.Text = DateTime.Now.ToLongDateString();
        Label3.Text = DateTime.Now.ToString();

        //for every country, what if we create a separate cache?
        // just create VarybyParams attribute in aspx page
    }
}