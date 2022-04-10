using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Rent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddlbillnmame_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlbillnmame.SelectedItem.Text =="0")
        {
            ddlbillnmame.Visible = false;
            ddlupi.Visible = false;
            pnlAccount.Visible = false;
            pnlUPI.Visible = false;
            

        }
        else
        {
            ddlbillnmame.Visible = true;
            ddlupi.Visible = true;
            pnlAccount.Visible = false;
            pnlUPI.Visible = false;
        }
           
    }

    protected void ddlupi_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlupi.SelectedItem.Text == "Account")
        {
            pnlAccount.Visible = true;
            pnlUPI.Visible = false;
           
        }
        else if(ddlupi.SelectedItem.Text == "UPI")
        {
            pnlAccount.Visible = false;
            pnlUPI.Visible = true;
        }

    }
}