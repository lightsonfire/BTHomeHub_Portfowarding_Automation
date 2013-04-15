using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Net;

namespace Li_Port_Foward.Web
{
    class HomeHub
    {
        private CookieWebClient wc;
        private bool isLoggedIn;
        public HomeHub()
        {
            wc = new CookieWebClient();
            wc.Proxy = null;
            isLoggedIn = false;
        }
        public void login(string password)
        {
            string enc = encodePass(password);
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string res = wc.UploadString(new Uri("http://192.168.1.254/index/login.cgi?RequestFile=/html/settings/b_basic_settings.html&ActionID=95"), "Username=admin&Password=" + enc);
            if (res.Equals("login success"))
            {
                isLoggedIn = true;
            }
        }
        private string encodePass(string password)
        {
            string s = base64(password);
            s = md5(s);
            s = base64(s);
            return s;
        }
        private string md5(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] b = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(b);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        private string base64(string pw)
        {
            byte[] b = ASCIIEncoding.ASCII.GetBytes(pw);
            string res = Convert.ToBase64String(b);
            return res;
        }
    }
}
