using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for GetString
/// </summary>
public class GetString
{
    public string Text(string Pass)
    {
        string strmsg = string.Empty;
        byte[] encode = new byte[Pass.Length];
        encode = Encoding.UTF8.GetBytes(Pass);
        strmsg = Convert.ToBase64String(encode);
        return strmsg;
    }
    public string DText(string Pass)
    {
        string decryptpwd = string.Empty;
        UTF8Encoding encodepwd = new UTF8Encoding();
        Decoder Decode = encodepwd.GetDecoder();
        byte[] todecode_byte = Convert.FromBase64String(Pass);
        int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
        char[] decoded_char = new char[charCount];
        Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
        decryptpwd = new String(decoded_char);
        return decryptpwd;
    }
}