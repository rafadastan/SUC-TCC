using SUC.Domain.Contracts.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SUC.CrossCutting.Cryptography
{
    public class MD5Cryptography : IMD5Cryptoghaphy
    {
        public string Encrypt(string value)
        {
            var md5 = new MD5CryptoServiceProvider();

            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(value));

            var result = string.Empty;
            foreach (var item in hash)
            {
                result += item.ToString("X2");
            }

            return result;
        }
    }
}
