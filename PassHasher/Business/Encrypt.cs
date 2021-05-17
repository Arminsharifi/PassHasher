using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PassHasher.Business
{
    class Encrypt
    {
        public string fncEncryptSha1(string strText , string strXType)
        {
            using (SHA1Managed SHA1 = new SHA1Managed())
            {
                var bytehash = SHA1.ComputeHash(Encoding.UTF8.GetBytes(strText));
                string StrBuilder = "";

                foreach (byte bytes in bytehash)
                {
                    StrBuilder = StrBuilder + (bytes.ToString(strXType));
                }

                return StrBuilder.ToString();
            }
        }

        public string fncEncryptMD5(string strText)
        {              
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(strText);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
