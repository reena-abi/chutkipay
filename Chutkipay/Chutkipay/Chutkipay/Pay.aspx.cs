using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void button1_Click(object sender, EventArgs e)
    {
        string amount = Request.Form["amount"].Trim();
        string firstname = Request.Form["firstname"].Trim();
        string email = Request.Form["email"].Trim();
        string phone = Request.Form["phone"].Trim();
        string productinfo = Request.Form["productinfo"].Trim();
        string surl = Request.Form["surl"].Trim();
        string furl = Request.Form["furl"].Trim();
        string Txnid = Request.Form["Txnid"].Trim();
        string UDF1 = Request.Form["udf1"].Trim();
        string UDF2 = Request.Form["udf2"].Trim();
        string UDF3 = Request.Form["udf3"].Trim();
        string UDF4 = Request.Form["udf4"].Trim();
        string UDF5 = Request.Form["udf5"].Trim();
        string Show_payment_mode = Request.Form["show_payment_mode"].Trim();
        //call the object of class and start payment
        //Easebuzz t = new Easebuzz(salt, Key, env);
        //string str = t.initiatePaymentAPI(amount, firstname, email, phone, productinfo, surl, furl, Txnid, UDF1, UDF2, UDF3, UDF4, UDF5, Show_payment_mode);
        ///string strForm = t.initiatePaymentAPI(amount, firstname, email, phone, productinfo, surl, furl,Txnid,UDF1,UDF2,UDF3,UDF4,UDF5,Show_payment_mode);
        //Page.Controls.Add(new LiteralControl(str));
    }
}