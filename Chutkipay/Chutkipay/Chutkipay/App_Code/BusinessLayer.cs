using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

public class BusinessLayer
{
    #region default
    public DataTable CheckUserDetail(string loginid, string pass)
    {
        return new DataLayer().CheckUserDetail(loginid, pass);
    }

    public DataTable CheckUserDetail1(string id, string password)
    {
        return new DataLayer().CheckUsertype(id, password);
    }
    public DataTable CheckUser(string UserName, string Pass)
    {
        return new DataLayer().CheckUser(UserName, Pass);
    }
  
    public static void FillDropDown(DropDownList ddl, DataTable dt, string DisplayName, string ValueName, Char HeaderTitle)
    {
        if (dt != null)
        {
            DataRow dr;
            dr = dt.NewRow();
            if (HeaderTitle == 'S')
            {
                dr[DisplayName] = "--Select--";
                dr[ValueName] = "-1";
                dt.Rows.InsertAt(dr, 0);
            }
            else if (HeaderTitle == 'A')
            {
                dr[DisplayName] = "--All--";
                dr[ValueName] = "-1";
                dt.Rows.InsertAt(dr, 0);
            }
            else if (HeaderTitle == 'N')
            {
                dr[DisplayName] = "--None--";
                dr[ValueName] = "-1";
                dt.Rows.InsertAt(dr, 0);
            }
            else if (HeaderTitle == 'F')
            {
                dr[DisplayName] = "--Franchisee Location--";
                dr[ValueName] = "-1";
                dt.Rows.InsertAt(dr, 0);
            }
        }
        ddl.DataSource = dt;
        ddl.DataTextField = DisplayName;
        ddl.DataValueField = ValueName;
        ddl.DataBind();
    }
    public void setSerialNo(ref DataTable dt, string p)
    {
        dt.Columns.Add(p);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt.Rows[i][p] = i + 1;
        }
    }
 
   
    public string getAlp(int i)
    {
        string str = "";
        switch (i)
        {
            case 1: str = "A"; break;
            case 2: str = "B"; break;
            case 3: str = "C"; break;
            case 4: str = "D"; break;
            case 5: str = "E"; break;
            case 6: str = "F"; break;
            case 7: str = "G"; break;
            case 8: str = "H"; break;
            case 9: str = "I"; break;
            case 10: str = "J"; break;
            case 11: str = "K"; break;
            case 12: str = "L"; break;
            case 13: str = "M"; break;
            case 14: str = "N"; break;
            case 15: str = "O"; break;
            case 16: str = "P"; break;
            case 17: str = "Q"; break;
            case 18: str = "R"; break;
            case 19: str = "S"; break;
            case 20: str = "T"; break;
            case 21: str = "U"; break;
            case 22: str = "V"; break;
            case 23: str = "W"; break;
            case 24: str = "X"; break;
            case 25: str = "Y"; break;
            case 26: str = "Z"; break;
            case 27: str = "a"; break;
            case 28: str = "b"; break;
            case 29: str = "c"; break;
            case 30: str = "d"; break;
            case 31: str = "e"; break;
            case 32: str = "f"; break;
            case 33: str = "g"; break;
            case 34: str = "h"; break;
            case 35: str = "i"; break;
            case 36: str = "j"; break;
            case 37: str = "k"; break;
            case 38: str = "l"; break;
            case 39: str = "m"; break;
            case 40: str = "n"; break;
            case 41: str = "o"; break;
            case 42: str = "p"; break;
            case 43: str = "q"; break;
            case 44: str = "r"; break;
            case 45: str = "s"; break;
            case 46: str = "t"; break;
            case 47: str = "u"; break;
            case 48: str = "v"; break;
            case 49: str = "w"; break;
            case 50: str = "x"; break;
            case 51: str = "y"; break;
            case 52: str = "z"; break;
            case 53: str = "@"; break;
            case 54: str = "$"; break;
            case 55: str = "*"; break;
            case 56: str = "^"; break;
            case 57: str = "#"; break;

        }
        return str;
    }

    public static DateTime Setdate(string Cdate)
    {
        char[] a = { ',' };
        string[] date = Cdate.Split('/');
        DateTime dt = new DateTime(int.Parse(date[2].ToString()), int.Parse(date[1].ToString()), int.Parse(date[0].ToString()));
        return dt;
    }
    #endregion

   
   
}