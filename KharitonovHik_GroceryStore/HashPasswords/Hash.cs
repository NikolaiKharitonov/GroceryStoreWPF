using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HashPasswords
{
    public class Hash
    {
        public static string GetHashPassword(string password)
        {
            string hashPassword = "";
            if (!string.IsNullOrEmpty(password))
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytePassword = Encoding.UTF8.GetBytes(password);
                    byte[] hashBytePassword = sha256Hash.ComputeHash(bytePassword);
                    hashPassword = BitConverter.ToString(hashBytePassword).Replace("-", string.Empty);

                }
            }
            return hashPassword;
        }
    }
}
