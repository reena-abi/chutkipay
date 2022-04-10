using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class returnID : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Application["order_token"] != null)
        {
            string returnid = Application["order_token"].ToString();
            //Response.Write(Name);
        }
    }
}