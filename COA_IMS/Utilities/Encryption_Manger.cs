using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace COA_IMS.Utilities
{
    internal class Encryption_Manger
    {
        private const int salt_size = 16;
        private const int hash_size = 20;
        private const int Iterations = 10000;

        public string HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[salt_size]);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(hash_size);

            byte[] hashBytes = new byte[salt_size + hash_size];
            Array.Copy(salt, 0, hashBytes, 0, salt_size);
            Array.Copy(hash, 0, hashBytes, salt_size, hash_size);

            string hash_pass = Convert.ToBase64String(hashBytes);

            return hash_pass;
        }

        public bool VerifyPassword(string hash_pass, string user_pass)
        {
            byte[] hashBytes = Convert.FromBase64String(hash_pass);
            byte[] salt = new byte[salt_size];
            Array.Copy(hashBytes, 0, salt, 0, salt_size);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(user_pass, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(hash_size);

            for (int i = 0; i < hash_size; i++)
            {
                if (hashBytes[i + salt_size] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
