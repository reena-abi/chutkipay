﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Broadband : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void ddlupi_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlupi.SelectedItem.Text == "0")
        {
            ddlupi.Visible = true;
         


        }
    }
}