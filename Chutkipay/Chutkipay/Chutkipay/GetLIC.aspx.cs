using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;


public partial class GetLIC : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void save_Click(object sender, EventArgs e)
    {
        ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        var url = "https://paysprint.in/service-api/api/v1/service/bill-payment/bill/fetchlicbill";

        var httpRequest = (HttpWebRequest)WebRequest.Create(url);
        httpRequest.Method = "POST";

        httpRequest.ContentType = "application/json";
        httpRequest.Accept = "application/json";
        httpRequest.Headers["Token"] = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ0aW1lc3RhbXAiOiIxNjQ2NTYwODEzIiwicGFydG5lcklkIjoiUFMwMDU2NCIsInJlcWlkIjoxNTE2MjM5MDIyfQ.ZsOeSofpwcSjLfQOvC6bWLyhzkJFKD6wyNZE5-J8kxw";

        var data = "{\n\"canumber\":\"" + canumber.Text + "\",\n\"ad1\":\"" + ad1.Text + "\",\n\"mode\":\"offline\"}";

        using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
        {
            streamWriter.Write(data);
        }

        var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);
            txtres.Text = result;
        }

        //Console.WriteLine(httpResponse.StatusCode);
    }
}