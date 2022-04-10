using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ViewOwnCommition : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataLayer dl= new DataLayer();
        DataTable dt = dl.custom_query("select * from tbltxn_payout where ClientID='" + Session["clientid"].ToString() + "' and status!='Failed' and Dr!='Dr'");
        if (dt != null && dt.Rows.Count > 0)
        {
            DataView dv = dt.DefaultView;
            new BusinessLayer().setSerialNo(ref dt, "sno");
            //grid2.DataSource = dt;
          //  grid2.DataBind();
        }
    }
}