using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

public partial class Insurance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            paysprint obb = new paysprint();
            obb.amount = lblant.Text;
            lblname.Text = obb.name;
            lbldd.Text = obb.duedate;
            lblstatus.Text = obb.status;
        }
       
    }

    protected void LIC_Click(object sender, ImageClickEventArgs e)
    {
        pnlLICD.Visible = true;
        pnlmyshow.Visible = false;
    }

    protected void ddlliclist_TextChanged(object sender, EventArgs e)
    {
        pnlLICD.Visible = false;
        Pnlddl1.Visible = true;

    }
    protected void btnbacktohome_Click(object sender, EventArgs e)
    {
        pnlLICD.Visible = false;
        pnlmyshow.Visible = true; ;
    }

    protected void save_Click(object sender, EventArgs e)
    {
        ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        WriteLog.WriteLogs(DateTime.Now.ToString() + " " + "LIC Process");
        WriteLog.WriteLogs("*******************");
        var url = "https://paysprint.in/service-api/api/v1/service/bill-payment/bill/fetchlicbill";
        WriteLog.WriteLogs(DateTime.Now.ToString() + " URL: " + url);
        var httpRequest = (HttpWebRequest)WebRequest.Create(url);
        httpRequest.Method = "POST";
        httpRequest.ContentType = "application/json";
        httpRequest.Accept = "application/json";
        httpRequest.Headers["Token"] = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ0aW1lc3RhbXAiOiIxNjQ2NTYwODEzIiwicGFydG5lcklkIjoiUFMwMDU2NCIsInJlcWlkIjoxNTE2MjM5MDIyfQ.ZsOeSofpwcSjLfQOvC6bWLyhzkJFKD6wyNZE5-J8kxw";
        var data = "{\n\"canumber\":\"" + canumber.Text + "\",\n\"ad1\":\"" + ad1.Text + "\",\n\"mode\":\"offline\"}";

        using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
        {
            streamWriter.Write(data);
            WriteLog.WriteLogs(DateTime.Now.ToString() + " PassData: " + data);
        }

        var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);
           // WriteLog.WriteLogs(DateTime.Now.ToString() + " Result: " + obj);
            //string cid = CreateRegNo(3);
            //string uid = CreateRegNo(2);
            //uid = "101" + uid;

            //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            //var url = "https://sandbox.cashfree.com/pg/orders";
            //var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            //httpRequest.Method = "POST";
            //httpRequest.ContentType = "application/json";
            //httpRequest.Headers["x-api-version"] = "2022-01-01";
            //httpRequest.Headers["x-client-id"] = "1404682fb5b98227cc34e481f6864041";
            //httpRequest.Headers["x-client-secret"] = "d57047a712565f7ae9751adaf6cf24d6faa80b40";
            //var data = "{\n\"order_id\":\"" + uid + "\",\n\"order_amount\":\"12\",\n\"order_currency\":\"INR\",\n\"customer_details\":{\n\"customer_id\":\"" + cid + "\",\n\"customer_email\":\"re@gmail.com\",\n\"customer_phone\":\"9876543210\",\n\"return_url\":\"http://bill.chutkipay.com/returnID.aspx \",\n\"notify_url\":\"http://bill.chutkipay.com/Notyfy.aspx\"}\n}";
            ////        var data = @"{
            //  ""order_id"": ""order_1626945143520"",
            //  ""order_amount"": '"+txtamt.Text+"',
            //  ""order_currency"": ""INR"",
            //  ""customer_details"": {
            //    ""customer_id"": ""12345"",
            //    ""customer_email"": ""techsupport@cashfree.com"",
            //    ""customer_phone"": ""9816512345""
            //     
            //  }
            //}";

            //    using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            // {
            // streamWriter.Write(data);
            //  }

            //  var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            //   using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            // {
            //var result = streamReader.ReadToEnd();
            //var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);
            txtres.Text = result;
            paysprint ob = new paysprint();
            ob.amount = obj.order_id;
            ob.status = obj.order_amount;
            ob.name = obj.customer_id;
            ob.duedate = obj.customer_email;
            getdatails.Visible = true;
        }
    }
   
    protected void btnproced_Click(object sender, EventArgs e)
    {
        PnlForm.Visible = true;
        Pnlddl1.Visible = false;
      

    }
    public static string CreateRegNo(int RegLength)
    {
        string _allowedChars = "0123456789";
        Random randNum = new Random();
        char[] chars = new char[RegLength];
        int allowedCharCount = _allowedChars.Length;
        for (int i = 0; i < RegLength; i++)
        {
            chars[i] = _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())];
        }

        return new string(chars);
    }
    protected void btnbillpay_Click(object sender, EventArgs e)
    {
        paysprint obb = new paysprint();
        lblant.Text = obb.amount;
        lblname.Text = obb.name;
        lbldd.Text = obb.duedate;
        lblstatus.Text = obb.status;
        obb.amount = lblant.Text;
        string cid= CreateRegNo(3);
        string uid = CreateRegNo(2);
        uid = "101" + uid;
       
        ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        WriteLog.WriteLogs("*******************");
        var url = "https://sandbox.cashfree.com/pg/orders";
        WriteLog.WriteLogs("*******************");
        WriteLog.WriteLogs(DateTime.Now.ToString() + " " + url);
        var httpRequest = (HttpWebRequest)WebRequest.Create(url);
        httpRequest.Method = "POST";
        httpRequest.ContentType = "application/json";
        httpRequest.Headers["x-api-version"] = "2022-01-01";
        httpRequest.Headers["x-client-id"] = "1404682fb5b98227cc34e481f6864041";
        httpRequest.Headers["x-client-secret"] = "d57047a712565f7ae9751adaf6cf24d6faa80b40";
        var data = "{\n\"order_id\":\"" + uid + "\",\n\"order_amount\":\"" + txtamt.Text + "\",\n\"order_currency\":\"INR\",\n\"customer_details\":{\n\"customer_id\":\""+ cid + "\",\n\"customer_email\":\""+txtemail.Text+ "\",\n\"customer_phone\":\"" + txtphone.Text + "\",\n\"return_url\":\"http://bill.chutkipay.com/returnID.aspx \",\n\"notify_url\":\"http://bill.chutkipay.com/Notyfy.aspx\"}\n}";
        //  var data = @"{
        //  ""order_id"": ""order_1626945143520"",
        //  ""order_amount"": '"+txtamt.Text+"',
        //  ""order_currency"": ""INR"",
        //  ""customer_details"": {
        //  ""customer_id"": ""12345"",
        //  ""customer_email"": ""techsupport@cashfree.com"",
        //  ""customer_phone"": ""9816512345""
        //     
        //  }
        //}";

        using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
        {
            streamWriter.Write(data);
            WriteLog.WriteLogs("*******************");
            WriteLog.WriteLogs(DateTime.Now.ToString() + " PassData:  " + data);
            WriteLog.WriteLogs("*******************");
        }

        var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);
            WriteLog.WriteLogs("*******************");
            WriteLog.WriteLogs(DateTime.Now.ToString() + " Result: " + obj);
            WriteLog.WriteLogs("*******************");
            ShowMessage.Show("PayMentID :" + obj.cf_order_id + " Amount: " + obj.order_amount + "Status: Success");
            Response.Redirect("https://payments-test.cashfree.com/order/#" + obj.order_token + "");
            Application["order_token"] = obj.order_token;  
            Response.Redirect("returnid .aspx");
            //Response.Redirect("http://localhost:16734/returnid'"+ obj.order_token + "'");
            // string Rurl = "https://payments-test.cashfree.com/order/#'" + obj.order_token + "'";
            //txtamt.Text = "";
            //txtemail.Text = "";
            //txtphone.Text = "";
        }
    }



    protected void btnlicpay_Click(object sender, EventArgs e)
    {
//        var client = new RestClient("https://paysprint.in/service-api/api/v1/service/bill-payment/bill/paylicbill");
//        client.Timeout = -1;
//        var request = new RestRequest(Method.POST);
//        request.AddHeader("token", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ0aW1lc3RhbXAiOiIxNjQ2OTA1MTI1IiwicGFydG5lcklkIjoiUFMwMDU2NCIsInJlcWlkIjoxNTE2MjM5MDIyfQ.M56YaxiL55jvWRiee0JjGnbHtAHfjUwI0oxuuO_23LE");
//        request.AddHeader("Authorisedkey", "NmFkYTlmNGEyYWFjOGY1ZDYyM2QwNTEwYjc5ZWJmMTY=");
//        request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
//        request.AddHeader("Cookie", "ci_session=a45f8013c5fc3354a5804cf5020a38725b922f02");
//        var body = @"
//" + "\n" +
//        @"
//" + "\n" +
//        @"{""canumber"":""368155537"",""mode"":""offline"",""amount"":""100"",""ad1"":""nitesh@rnfiservices.com"",""ad2"":""HDC610532"",""ad3"":""HDC416601"",""referenceid"":""2021052415"",""latitude"":""26.843680"",""longitude"":""81.011620"",""bill_fetch"":{""billNumber"":""LICI2122000037468013"",""billAmount"":""1548.00"",""billnetamount"":""1548.00"",""billdate"":""25-05-2021 00:44:29"",""acceptPayment"":""true"",""acceptPartPay"":""false"",""cellNumber"":""905514651"",""dueFrom"":""11/05/2021"",""dueTo"":""11/05/2021"",""validationId"":""HGA8V00A110382264047"",""billId"":""HGA8V00A110382264047B""}}";
//        request.AddParameter("application/x-www-form-urlencoded", body, ParameterType.RequestBody);
//        IRestResponse response = client.Execute(request);
        ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        var url = "https://paysprint.in/service-api/api/v1/service/bill-payment/bill/paylicbill";
        WriteLog.WriteLogs(DateTime.Now.ToString() + " URL: " + url);
        var httpRequest = (HttpWebRequest)WebRequest.Create(url);
        httpRequest.Method = "POST";
        httpRequest.Headers["token"]= "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ0aW1lc3RhbXAiOiIxNjQ2OTA1MTI1IiwicGFydG5lcklkIjoiUFMwMDU2NCIsInJlcWlkIjoxNTE2MjM5MDIyfQ.M56YaxiL55jvWRiee0JjGnbHtAHfjUwI0oxuuO_23LE";
        httpRequest.Headers["Authorisedkey"]= "NmFkYTlmNGEyYWFjOGY1ZDYyM2QwNTEwYjc5ZWJmMTY=";
        httpRequest.Headers["Content-Type"]= "application/x-www-form-urlencoded"; var data = "{\n\"canumber\":\"368155537\",\n\"mode\":\"offline\",\n\"amount\":\"100\",\n\"ad1\":\"nitesh@rnfiservices.com\",\n\"ad2\":\"HDC610532\",\n\"ad3\":\"HDC416601\",\n\"referenceid\":202105\",\n\"latitude\":27.2232\",\n\"longitude\":78.26535\",\n\"bill_fetch\":{\"billNumber\":\"LICI2122000037468013\",\"billAmount\":\"1548.00\",\n\"billnetamount\":\"1548.00\",\n\"billdate\":\"25-05-2021 00:44:29\",\n\"acceptPayment\":true\",\n\"acceptPartPay\":false\",\n\"cellNumber\":\"905514651\",\n\"dueFrom\":\"11/05/2021\",\n\"dueTo\":\"11/05/2021\",\n\"validationId\":\"HGA8V00A110382264047\",\n\"billId\":\"HGA8V00A110382264047B\"}}";

        using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
        {
            streamWriter.Write(data);
            WriteLog.WriteLogs(DateTime.Now.ToString() + " PassData: " + data);
        }

        var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);

        }
    }
}

