using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace XGame_Domain.Extensions
{
    public static class StringExtensions
    {
        public static string ConvertToMD5( this string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                StringBuilder hash = new StringBuilder();
                MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
                byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

                for (int i = 0; i < bytes.Length; i++)
                {
                    hash.Append(bytes[i].ToString("x2"));
                }
                return hash.ToString();
            }
            else
            {
                return string.Empty;
            }
            
        }
    }
}
