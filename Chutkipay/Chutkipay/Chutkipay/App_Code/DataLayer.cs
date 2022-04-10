using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Web;

public class DataLayer
{
    #region default
    private string IpAddress = GetIpAddress();
   // private string MacAddress = GetMACAddress();
    //public static string GetMACAddress()
    //{
    //    NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
    //    string str = string.Empty;
    //    foreach (NetworkInterface interface2 in allNetworkInterfaces)
    //    {
    //        if (str == string.Empty)
    //        {
    //            interface2.GetIPProperties();
    //            str = interface2.GetPhysicalAddress().ToString();
    //        }
    //    }
    //    return str;
    //}
    public static string GetIpAddress()
    {
        string str = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (!(str == "") && (str != null))
        {
            return str;
        }
        return HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
    }
    private SqlConnection cn;
    public void Connection()
    {

        this.cn = new SqlConnection();
        if (this.cn.State == ConnectionState.Closed)
        {

            SqlConnection.ClearAllPools();
            this.cn.ConnectionString = ConfigurationManager.ConnectionStrings["bank"].ConnectionString;
            this.cn.Open();
        }
    }
    public DataTable GetMemberDirectBusiness(string MemberCode, DateTime FromDate, DateTime ToDate)
    {
        DataTable dt = new DataTable();
        Connection();
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[SP_GetMemberDirectBusiness]";
            cmd.Parameters.AddWithValue("MemberCode", MemberCode);
            cmd.Parameters.AddWithValue("FromDate", FromDate);
            cmd.Parameters.AddWithValue("ToDate", ToDate);
            cmd.CommandTimeout = 3600;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
        }
        catch (Exception)
        {
            dt = null;
        }
        return dt;
    }
    public string UpdateBankDetails(M01_Member M01)
    {
        string Msg = "";
        Connection();
        SqlTransaction trans = cn.BeginTransaction();
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = trans;
            cmd.CommandText = "[SP_UpdateBankDetails]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MemberID", M01.MemberID);
            cmd.Parameters.AddWithValue("PanCardNo", M01.PanCardNo);
            cmd.Parameters.AddWithValue("@IFCCode", M01.IFSC);
            cmd.Parameters.AddWithValue("AccountNo", M01.AccNo);
            cmd.Parameters.AddWithValue("BankId", M01.BankID);
            cmd.Parameters.AddWithValue("BranchName", M01.BranchName);
            cmd.Parameters.AddWithValue("AadharNo", M01.AadharNo);
            cmd.Parameters.AddWithValue("AadharImg", M01.AadharImg);
            cmd.Parameters.AddWithValue("PANImg", M01.PANImg);


            cmd.Parameters.AddWithValue("Msg", "");
            cmd.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
            cmd.Parameters["Msg"].Size = 256;
            cmd.ExecuteNonQuery();
            Msg = cmd.Parameters["Msg"].Value.ToString();
            trans.Commit();
        }
        catch (Exception e)
        {
            trans.Rollback();
            Msg = e.ToString();
        }
        cn.Close();
        return Msg;
    }
    public string UpdateMemberProfilePic(M01_Member M01)
    {
        string Msg = "";
        Connection();
        SqlTransaction trans = cn.BeginTransaction();
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = trans;
            cmd.CommandText = "[SP_UpdateMemberProfilePic]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MemberId", M01.MemberID);
            cmd.Parameters.AddWithValue("ProfilePic", M01.UserImg);


            cmd.Parameters.AddWithValue("MSG", "");
            cmd.Parameters["MSG"].Direction = ParameterDirection.InputOutput;
            cmd.Parameters["MSG"].Size = 256;
            cmd.ExecuteNonQuery();
            Msg = cmd.Parameters["MSG"].Value.ToString();
            trans.Commit();
        }
        catch (Exception e)
        {
            trans.Rollback();
            Msg = e.ToString();
        }
        cn.Close();
        return Msg;
    }
    public DataTable CheckUserDetail1(string Client_ID, string LPass)
    {
        this.Connection();
        DataTable dataTable = new DataTable();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        command.CommandText = "[sp_VerifyAdmin]";
        command.CommandType = CommandType.StoredProcedure;
        command.Connection = this.cn;
        command.Parameters.AddWithValue("Client_ID", Client_ID);
        command.Parameters.AddWithValue("LPass", LPass);
        command.Parameters.AddWithValue("Message", "");
        command.Parameters["Message"].Direction = ParameterDirection.InputOutput;
        command.Parameters["Message"].Size = 256;
        adapter.SelectCommand = command;
        adapter.Fill(dataTable);
        this.cn.Close();
        return dataTable;
    }
    public DataTable CheckUsertype(string id, string password)
    {
        this.Connection();
        DataTable dataTable = new DataTable();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        command.CommandText = "[sp_usertype]";
        command.CommandType = CommandType.StoredProcedure;
        command.Connection = this.cn;
        command.Parameters.AddWithValue("id", id);
        command.Parameters.AddWithValue("password", password);
        command.Parameters.AddWithValue("Message", "");
        command.Parameters["Message"].Direction = ParameterDirection.InputOutput;
        command.Parameters["Message"].Size = 256;
        adapter.SelectCommand = command;
        adapter.Fill(dataTable);
        this.cn.Close();
        return dataTable;
    }
    public DataTable custom_query (string mystr)
    {
        this.Connection();
        DataTable dataTable = new DataTable();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        command.CommandText = "[Custom_Query]";
        command.CommandType = CommandType.StoredProcedure;
        command.Connection = this.cn;
        command.Parameters.AddWithValue("mystr", mystr);
        adapter.SelectCommand = command;
        adapter.Fill(dataTable);
        this.cn.Close();
        return dataTable;
    }

    public DataTable GetAdminLadger_Reports(string Client_ID, DateTime fdt, DateTime tdt)
    {
        Connection();
        // try
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "[Sp_APIAdmin_ledgerFund]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Client_ID", Client_ID);
            cmd.Parameters.AddWithValue("fdt", fdt);
            cmd.Parameters.AddWithValue("tdt", tdt);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
       
    }

    public DataTable GetUserLadger_Reports(string Client_ID, DateTime fdt, DateTime tdt)
    {
        Connection();
      //  try
       // {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "[Sp_APIUser_ledgerFund]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Client_ID", Client_ID);
            cmd.Parameters.AddWithValue("fdt", fdt);
            cmd.Parameters.AddWithValue("tdt", tdt);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
       // }

    }
    public DataSet custom_query1(string mystr)
    {
        this.Connection();
        DataSet dataTable = new DataSet();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        command.CommandText = "[Custom_Query]";
        command.CommandType = CommandType.StoredProcedure;
        command.Connection = this.cn;
        command.Parameters.AddWithValue("mystr", mystr);
        adapter.SelectCommand = command;
        adapter.Fill(dataTable);
        this.cn.Close();
        return dataTable;
    }

    public DataTable CheckUser(string UserName, string Pass)
    {
        try
        {
            this.Connection();
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            command.CommandText = "[sp_VerifyUser]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = this.cn;
            command.Parameters.AddWithValue("UserID", UserName);
            command.Parameters.AddWithValue("Password", Pass);
            command.Parameters.AddWithValue("Message", Pass);
            command.Parameters["Message"].Direction = ParameterDirection.InputOutput;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            this.cn.Close();
            return dataTable;
        }
        catch (Exception)
        {

            throw;
        }

    }

  

   
   
    #endregion


  
    public bool ChkPincode(string Pincode)
    {
        try
        {
            this.Connection();
            string selectCommandText = "select  dbo.[FS_CheckPinCode]('" + Pincode + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.cn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            this.cn.Close();
            return bool.Parse(dataTable.Rows[0][0].ToString().Trim());
        }
        catch (Exception)
        {

            throw;
        }

    }
     public string CreateRegNo(int RegLength)
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
public string Insertuserregistation(string Username, string LastName, string Fathername, string MobileNO, string Email, string Password, string Address, string pincode, string Adhar, string panno, string Createdby)
    {
        string str = "";
        Connection();
        SqlTransaction trans = cn.BeginTransaction();
         try
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[SP_RetailerRegistation]";
            cmd.Parameters.AddWithValue("FK_UserID",  CreateRegNo(2));
            cmd.Parameters.AddWithValue("Loginid", "BC" + CreateRegNo(4));
            cmd.Parameters.AddWithValue("Username", Username);
            cmd.Parameters.AddWithValue("Createdby",Createdby);
            cmd.Parameters.AddWithValue("LastName", LastName);
            cmd.Parameters.AddWithValue("Fathername", Fathername);
            cmd.Parameters.AddWithValue("MobileNO", MobileNO);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("Password", Password);
            cmd.Parameters.AddWithValue("Address", Address);
            cmd.Parameters.AddWithValue("pincode", pincode);
            cmd.Parameters.AddWithValue("Adhar", Adhar);
            cmd.Parameters.AddWithValue("panno", panno);
            cmd.Parameters.AddWithValue("Status", "P");
            cmd.Parameters.AddWithValue("usertype", "1");
            cmd.Parameters.AddWithValue("usertypename", "BC");
            cmd.Parameters.AddWithValue("Msg", "");
            //cmd.Parameters["Ticket"].Direction = ParameterDirection.InputOutput;
            //cmd.Parameters["Ticket"].Size = 256;
            cmd.Parameters["Msg"].Size = 256;
            cmd.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            str = cmd.Parameters["Msg"].Value.ToString();
            //str = cmd.Parameters["Ticket"].Value.ToString();
            trans.Commit();
        }
        catch (Exception ex)
         {
             str = ex.Message;
             trans.Rollback();
         }
        cn.Close();
        return str;
    }
public DataTable CheckUserDetail(string loginid, string pass)
{
    Connection();
    DataTable dt = new DataTable();
    try
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "[SP_GetSLogin]";
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("loginid", loginid);
        cmd.Parameters.AddWithValue("pass", pass);
      //  cmd.Parameters.AddWithValue("Status", Status);
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        da.Fill(dt);
    }
    catch (Exception exp)
    {
        dt = null;
    }
    cn.Close();
    return dt;
}
public DataTable Getuserregistationlist(string login, string mobile,string adhar)
{
    Connection();
    DataTable dt = new DataTable();
    try
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "[SP_gettbluserregistation]";
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("login", login);
        cmd.Parameters.AddWithValue("mobile", mobile);
        cmd.Parameters.AddWithValue("adhar", adhar);
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        da.Fill(dt);
    }
    catch (Exception exp)
    {
        dt = null;
    }
    cn.Close();
    return dt;
}

public DataTable GetVitualAclist(string accountno, string mobile, string name)
{
    Connection();
    DataTable dt = new DataTable();
     try
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "[SP_GetVirtualAccont]";
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("VirtualAccount", accountno);
        cmd.Parameters.AddWithValue("Mobile", mobile);
        cmd.Parameters.AddWithValue("Name", name);
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        da.Fill(dt);
    }
     catch (Exception exp)
    {
         dt = null;
    }
    cn.Close();
    return dt;
}


public string InsertBranchregistation(string Username, string LastName, string Fathername, string MobileNO, string Email, string Password, string Address, string pincode, string Adhar, string panno, string Createdby)
{
    string str = "";
    Connection();
    SqlTransaction trans = cn.BeginTransaction();
    try
    {

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = this.cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "[SP_BranchRegistation]";
        cmd.Parameters.AddWithValue("FK_UserID", CreateRegNo(2));
        cmd.Parameters.AddWithValue("Loginid", "Emp" + CreateRegNo(4));
        cmd.Parameters.AddWithValue("Username", Username);
        cmd.Parameters.AddWithValue("Createdby", Createdby);
        cmd.Parameters.AddWithValue("LastName", LastName);
        cmd.Parameters.AddWithValue("Fathername", Fathername);
        cmd.Parameters.AddWithValue("MobileNO", MobileNO);
        cmd.Parameters.AddWithValue("Email", Email);
        cmd.Parameters.AddWithValue("Password", Password);
        cmd.Parameters.AddWithValue("Address", Address);
        cmd.Parameters.AddWithValue("pincode", pincode);
        cmd.Parameters.AddWithValue("Adhar", Adhar);
        cmd.Parameters.AddWithValue("panno", panno);
        cmd.Parameters.AddWithValue("Status", "P");
        cmd.Parameters.AddWithValue("usertype", "2");
        cmd.Parameters.AddWithValue("usertypename", "User");
        cmd.Parameters.AddWithValue("Msg", "");
        //cmd.Parameters["Ticket"].Direction = ParameterDirection.InputOutput;
        //cmd.Parameters["Ticket"].Size = 256;
        cmd.Parameters["Msg"].Size = 256;
        cmd.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
        cmd.Transaction = trans;
        cmd.ExecuteNonQuery();
        str = cmd.Parameters["Msg"].Value.ToString();
        //str = cmd.Parameters["Ticket"].Value.ToString();
        trans.Commit();
    }
    catch (Exception ex)
    {
        str = ex.Message;
        trans.Rollback();
    }
    cn.Close();
    return str;
}
public string InsertEntUser_registation(string Username, string LastName, string Fathername, string MobileNO, string Email, string Password, string Address, string pincode, string Adhar, string panno, string Createdby)
{
    string str = "";
    Connection();
    SqlTransaction trans = cn.BeginTransaction();
    try
    {

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = this.cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "[SP_Entry_Registation]";
        cmd.Parameters.AddWithValue("FK_UserID", CreateRegNo(2));
        cmd.Parameters.AddWithValue("Loginid", "Emp" + CreateRegNo(4));
        cmd.Parameters.AddWithValue("Username", Username);
        cmd.Parameters.AddWithValue("Createdby", Createdby);
        cmd.Parameters.AddWithValue("LastName", LastName);
        cmd.Parameters.AddWithValue("Fathername", Fathername);
        cmd.Parameters.AddWithValue("MobileNO", MobileNO);
        cmd.Parameters.AddWithValue("Email", Email);
        cmd.Parameters.AddWithValue("Password", Password);
        cmd.Parameters.AddWithValue("Address", Address);
        cmd.Parameters.AddWithValue("pincode", pincode);
        cmd.Parameters.AddWithValue("Adhar", Adhar);
        cmd.Parameters.AddWithValue("panno", panno);
        cmd.Parameters.AddWithValue("Status", "P");
        cmd.Parameters.AddWithValue("usertype", "3");
        cmd.Parameters.AddWithValue("usertypename", "EntUser");
        cmd.Parameters.AddWithValue("Msg", "");
        //cmd.Parameters["Ticket"].Direction = ParameterDirection.InputOutput;
        //cmd.Parameters["Ticket"].Size = 256;
        cmd.Parameters["Msg"].Size = 256;
        cmd.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
        cmd.Transaction = trans;
        cmd.ExecuteNonQuery();
        str = cmd.Parameters["Msg"].Value.ToString();
        //str = cmd.Parameters["Ticket"].Value.ToString();
        trans.Commit();
    }
    catch (Exception ex)
    {
        str = ex.Message;
        trans.Rollback();
    }
    cn.Close();
    return str;
}

public DataTable GetPachakegList()
{
    Connection();
    DataTable dt = new DataTable();
     try
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "[SP_Getpackages]";
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        da.Fill(dt);
    }
    catch (Exception exp)
    {
          dt = null;
    }
    cn.Close();
    return dt;
}
public string InsertVfyUser_registation(string Username, string LastName, string Fathername, string MobileNO, string Email, string Password, string Address, string pincode, string Adhar, string panno, string Createdby)
{
    string str = "";
    Connection();
    SqlTransaction trans = cn.BeginTransaction();
    try
    {

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = this.cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "[SP_Verfy_Registation]";
        cmd.Parameters.AddWithValue("FK_UserID", CreateRegNo(2));
        cmd.Parameters.AddWithValue("Loginid", CreateRegNo(4));
        cmd.Parameters.AddWithValue("Username", Username);
        cmd.Parameters.AddWithValue("Createdby", Createdby);
        cmd.Parameters.AddWithValue("LastName", LastName);
        cmd.Parameters.AddWithValue("Fathername", Fathername);
        cmd.Parameters.AddWithValue("MobileNO", MobileNO);
        cmd.Parameters.AddWithValue("Email", Email);
        cmd.Parameters.AddWithValue("Password", Password);
        cmd.Parameters.AddWithValue("Address", Address);
        cmd.Parameters.AddWithValue("pincode", pincode);
        cmd.Parameters.AddWithValue("Adhar", Adhar);
        cmd.Parameters.AddWithValue("panno", panno);
        cmd.Parameters.AddWithValue("Status", "P");
        cmd.Parameters.AddWithValue("usertype", "4");
        cmd.Parameters.AddWithValue("usertypename", "VfyUser");
        cmd.Parameters.AddWithValue("Msg", "");
        //cmd.Parameters["Ticket"].Direction = ParameterDirection.InputOutput;
        //cmd.Parameters["Ticket"].Size = 256;
        cmd.Parameters["Msg"].Size = 256;
        cmd.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
        cmd.Transaction = trans;
        cmd.ExecuteNonQuery();
        str = cmd.Parameters["Msg"].Value.ToString();
        //str = cmd.Parameters["Ticket"].Value.ToString();
        trans.Commit();
    }
    catch (Exception ex)
    {
        str = ex.Message;
        trans.Rollback();
    }
    cn.Close();
    return str;
}
public string InsertLoanUser_registation(string Username, string LastName, string Fathername, string MobileNO, string Email, string Password, string Address, string pincode, string Adhar, string panno, string Createdby)
{
    string str = "";
    Connection();
    SqlTransaction trans = cn.BeginTransaction();
    try
    {

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = this.cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "[SP_LoanUSer_Registation]";
        cmd.Parameters.AddWithValue("FK_UserID", CreateRegNo(2));
        cmd.Parameters.AddWithValue("Loginid", CreateRegNo(4));
        cmd.Parameters.AddWithValue("Username", Username);
        cmd.Parameters.AddWithValue("Createdby", Createdby);
        cmd.Parameters.AddWithValue("LastName", LastName);
        cmd.Parameters.AddWithValue("Fathername", Fathername);
        cmd.Parameters.AddWithValue("MobileNO", MobileNO);
        cmd.Parameters.AddWithValue("Email", Email);
        cmd.Parameters.AddWithValue("Password", Password);
        cmd.Parameters.AddWithValue("Address", Address);
        cmd.Parameters.AddWithValue("pincode", pincode);
        cmd.Parameters.AddWithValue("Adhar", Adhar);
        cmd.Parameters.AddWithValue("panno", panno);
        cmd.Parameters.AddWithValue("Status", "P");
        cmd.Parameters.AddWithValue("usertype", "5");
        cmd.Parameters.AddWithValue("usertypename", "LoanUser");
        cmd.Parameters.AddWithValue("Msg", "");
        //cmd.Parameters["Ticket"].Direction = ParameterDirection.InputOutput;
        //cmd.Parameters["Ticket"].Size = 256;
        cmd.Parameters["Msg"].Size = 256;
        cmd.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
        cmd.Transaction = trans;
        cmd.ExecuteNonQuery();
        str = cmd.Parameters["Msg"].Value.ToString();
        //str = cmd.Parameters["Ticket"].Value.ToString();
        trans.Commit();
    }
    catch (Exception ex)
    {
        str = ex.Message;
        trans.Rollback();
    }
    cn.Close();
    return str;
}
public string InserStatemaster(string Userid, string pincode, string distic, string statename)
{
    string str = "";
    Connection();
    SqlTransaction trans = cn.BeginTransaction();
    try
    {

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = this.cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "[SP_tblstatemaster]";
        cmd.Parameters.AddWithValue("Userid",Userid);
        cmd.Parameters.AddWithValue("pincode", pincode);
        cmd.Parameters.AddWithValue("distic", distic);
        cmd.Parameters.AddWithValue("statename", statename);
        cmd.Parameters.AddWithValue("Msg", "");
        cmd.Parameters["Msg"].Size = 256;
        cmd.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
        cmd.Transaction = trans;
        cmd.ExecuteNonQuery();
        str = cmd.Parameters["Msg"].Value.ToString();
        trans.Commit();
    }
    catch (Exception ex)
    {
        str = ex.Message;
        trans.Rollback();
    }
    cn.Close();
    return str;
}
public string Inserloantyper(string Userid, string lonetype)
{
    string str = "";
    Connection();
    SqlTransaction trans = cn.BeginTransaction();
    try
    {

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = this.cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "[SP_tbllonetype]";
        cmd.Parameters.AddWithValue("Userid", Userid);
        cmd.Parameters.AddWithValue("lonetype", lonetype);
        cmd.Parameters.AddWithValue("Msg", "");
        cmd.Parameters["Msg"].Size = 256;
        cmd.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
        cmd.Transaction = trans;
        cmd.ExecuteNonQuery();
        str = cmd.Parameters["Msg"].Value.ToString();
        trans.Commit();
    }
    catch (Exception ex)
    {
        str = ex.Message;
        trans.Rollback();
    }
    cn.Close();
    return str;
}

public string Inserloantpospuse(string Userid, string lonetype,string loanname)
{
    string str = "";
    Connection();
    SqlTransaction trans = cn.BeginTransaction();
    try
    {

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = this.cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "[SP_tbllonepospuse]";
        cmd.Parameters.AddWithValue("Userid", Userid);
        cmd.Parameters.AddWithValue("lonetype", lonetype);
        cmd.Parameters.AddWithValue("loanname", loanname);
        cmd.Parameters.AddWithValue("Msg", "");
        cmd.Parameters["Msg"].Size = 256;
        cmd.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
        cmd.Transaction = trans;
        cmd.ExecuteNonQuery();
        str = cmd.Parameters["Msg"].Value.ToString();
        trans.Commit();
    }
    catch (Exception ex)
    {
        str = ex.Message;
        trans.Rollback();
    }
    cn.Close();
    return str;
}
public string InserVirtualAccount(string Name,string LastName,string FatherName,string  DOB,string Mobile,string Email,string PanNO,string AdharNo,string CreatedBy)
{
    string str = "";
    Connection();
    SqlTransaction trans = cn.BeginTransaction();
    try
    {

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = this.cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "[SP_Virtual]";
        cmd.Parameters.AddWithValue("Name", Name);
        cmd.Parameters.AddWithValue("LastName", LastName);
        cmd.Parameters.AddWithValue("FatherName", FatherName);
        cmd.Parameters.AddWithValue("DOB", DOB);
        cmd.Parameters.AddWithValue("Mobile", Mobile);
        cmd.Parameters.AddWithValue("Email", Email);
        cmd.Parameters.AddWithValue("PanNO", PanNO);
        cmd.Parameters.AddWithValue("AdharNo", AdharNo);
        cmd.Parameters.AddWithValue("VirtualAC", "1004" + Mobile);
        cmd.Parameters.AddWithValue("CreatedBy", CreatedBy);
        cmd.Parameters.AddWithValue("Msg", "");
        cmd.Parameters["Msg"].Size = 256;
        cmd.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
        cmd.Transaction = trans;
        cmd.ExecuteNonQuery();
        str = cmd.Parameters["Msg"].Value.ToString();
        trans.Commit();
    }
    catch (Exception ex)
    {
        str = ex.Message;
        trans.Rollback();
    }
    cn.Close();
    return str;
}

public string InsertUpdateCommission(List<AddPackage> lstS02)
{
    this.Connection();
    string message = "";

    SqlTransaction transaction = this.cn.BeginTransaction();
    try
    {

        for (int i = 0; i < lstS02.Count; i++)
        {
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                Connection = this.cn,
                CommandText = "SP_AddPachages"
            };
            command.Parameters.AddWithValue("id", lstS02[i].PK_id);
            command.Parameters.AddWithValue("FromAmt", lstS02[i].FromAmt);
            command.Parameters.AddWithValue("ToAmt", lstS02[i].ToAmt);
            command.Parameters.AddWithValue("comtype", lstS02[i].comtype);
            command.Parameters.AddWithValue("rt_amt", lstS02[i].rt_amt);
            command.Parameters.AddWithValue("mycom", lstS02[i].mycom);
           // command.Parameters.AddWithValue("Client_Id", lstS02[i].ClientId);
            command.Parameters.AddWithValue("CreateBy", lstS02[i].CreateBy);
            command.Parameters.AddWithValue("Msg", "");
            command.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
            command.Parameters["Msg"].Size = 0x100;
            command.Transaction = transaction;
            command.ExecuteNonQuery();
            message = command.Parameters["Msg"].Value.ToString();

        }
        if (message.Contains("Successfully"))
        {
            transaction.Commit();
        }

    }
    catch (Exception exception)
    {
        transaction.Rollback();
        message = exception.Message;
    }
    this.cn.Close();
    return message;
}

public DataTable getwallet(string ClientID)
{
    Connection();
    DataTable dt = new DataTable();
    try
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "[Sp_tbltxn_payout]";
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("ClientID", ClientID);
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        da.Fill(dt);
    }
     catch (Exception exp)
    {
         dt = null;
    }
    cn.Close();
    return dt;
}

public DataSet GetDMTComm(string amount, string clientid)
{
    Connection();
    DataSet dt = new DataSet();
    try
    {
       SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "[SP_Get_RTDMTComm]";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("amount", amount);
        cmd.Parameters.AddWithValue("clientid", clientid);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
     }
    catch (Exception ex)
    {
        dt = null;
    }
    cn.Close();
    return dt;
}
public string Insertp_addfund(string Comtype, decimal amount, decimal rt_amt, decimal admin_amt, decimal com_amt, string client_id, string Accountno, string IFSC, string Holdername, string Bankname, string bankrrnno, string txnNo, string Remark, string bankiin, string status, string payment_mode)
{
    string str = "";
    Connection();
    SqlTransaction trans = cn.BeginTransaction();
    try
    {

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = this.cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "[Sp_Cr_DrTxnCommition]";
        cmd.Parameters.AddWithValue("Comtype", Comtype);
        cmd.Parameters.AddWithValue("amount", amount);
        cmd.Parameters.AddWithValue("rt_amt", rt_amt);
        cmd.Parameters.AddWithValue("admin_amt", admin_amt);
        cmd.Parameters.AddWithValue("com_amt", com_amt);
        cmd.Parameters.AddWithValue("client_id", client_id);
        cmd.Parameters.AddWithValue("Accountno", Accountno);
        cmd.Parameters.AddWithValue("IFSC", IFSC);
        cmd.Parameters.AddWithValue("Holdername", Holdername);
        cmd.Parameters.AddWithValue("Bankname", Bankname);
        cmd.Parameters.AddWithValue("bankrrnno", bankrrnno);
        cmd.Parameters.AddWithValue("txnNo", txnNo);
        cmd.Parameters.AddWithValue("Remark", Remark);
        cmd.Parameters.AddWithValue("bankiin", bankiin);
        cmd.Parameters.AddWithValue("status", status);
        cmd.Parameters.AddWithValue("payment_mode", payment_mode);
        cmd.Parameters.AddWithValue("Msg", "");
        cmd.Parameters["Msg"].Size = 256;
        cmd.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
        cmd.Transaction = trans;
        cmd.ExecuteNonQuery();
        str = cmd.Parameters["Msg"].Value.ToString();
        trans.Commit();
    }
    catch (Exception ex)
    {
        str = ex.Message;
        trans.Rollback();
    }
    cn.Close();
    return str;
}

public DataTable GetPayoutList(string clientid, string status, DateTime todate, DateTime fromdate)
{
    Connection();
    DataTable dt = new DataTable();
    try
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "[SP_get_usertxnpayout]";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("login", clientid);
        cmd.Parameters.AddWithValue("status", status);
        cmd.Parameters.AddWithValue("todate", todate);
        cmd.Parameters.AddWithValue("fromdate", fromdate);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
    }
    catch (Exception ex)
    {
        dt = null;
    }
    cn.Close();
    return dt;
}
public DataTable GetLogin(string loginid, string pass)
{
    Connection();
    DataTable dt = new DataTable();
    try
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "[SP_GetSLogin]";
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("loginid", loginid);
        cmd.Parameters.AddWithValue("pass", pass);
       
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        da.Fill(dt);
    }
    catch (Exception exp)
    {
        dt = null;
    }
    cn.Close();
    return dt;
}

public string AddDataforpay(string holdername, string accountno, string bankname, string ifsc, string payeename, string mobile, string email, string Address, string relatedBy, string createdBy, string adhar)
{
    string str = "";
    Connection();
    SqlTransaction trans = cn.BeginTransaction();
    try
    {

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = this.cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "[SP_tbladdpayee]";
        cmd.Parameters.AddWithValue("holdername", holdername);
        cmd.Parameters.AddWithValue("accountno", accountno);
        cmd.Parameters.AddWithValue("bankname", bankname);
        cmd.Parameters.AddWithValue("ifsc", ifsc);
      //  cmd.Parameters.AddWithValue("bankname", bankname);
        cmd.Parameters.AddWithValue("payeename", payeename);
        cmd.Parameters.AddWithValue("mobile", mobile);
        cmd.Parameters.AddWithValue("email", email);
        cmd.Parameters.AddWithValue("Address", Address);
       cmd.Parameters.AddWithValue("adhar", adhar);
        cmd.Parameters.AddWithValue("relatedBy", relatedBy);
        cmd.Parameters.AddWithValue("createdBy", createdBy);
        cmd.Parameters.AddWithValue("Msg", "");
        cmd.Parameters["Msg"].Size = 256;
        cmd.Parameters["Msg"].Direction = ParameterDirection.InputOutput;
        cmd.Transaction = trans;
        cmd.ExecuteNonQuery();
        str = cmd.Parameters["Msg"].Value.ToString();
        trans.Commit();
    }
    catch (Exception ex)
    {
        str = ex.Message;
        trans.Rollback();
    }
    cn.Close();
    return str;
}

public DataTable GetPyeename(string payeename, string AccountNo)
{
    Connection();
    DataTable dt = new DataTable();
    try
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "[Get_tbladdpayee]";
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("payeename", payeename);
        cmd.Parameters.AddWithValue("AccountNo", AccountNo);

        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        da.Fill(dt);
    }
    catch (Exception exp)
    {
        dt = null;
    }
    cn.Close();
    return dt;
}

}