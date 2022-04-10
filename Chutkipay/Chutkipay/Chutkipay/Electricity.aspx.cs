using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Electricity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }


    protected void bpbill_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(bpbill.SelectedItem.Value =="1")
        {
            ebillpay.Visible = true;
            ddstates.Visible = false;
            ddboards.Visible = false;
            distype.Visible = false;
        }
        else if (bpbill.SelectedItem.Value == "2")
        {
            ebillpay.Visible = false;
            ddstates.Visible = true;
            
        }
    }
}