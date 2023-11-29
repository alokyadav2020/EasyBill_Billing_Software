using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BillingApp.main_class
{
    public class SecureData
    {
        public static string EncryptData(String simplestring)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] passwordHash = Encoding.UTF8.GetBytes(simplestring);
            return Encoding.UTF8.GetString(md5.ComputeHash(passwordHash));
        }
    }
}
