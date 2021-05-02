/**
 * Source: https://stackoverflow.com/questions/57110603/verify-sha512-hashed-password-in-c-sharp
 * Author: Prochu1991
 * Date: 07/19/2019
 * Accessed: 04/30/2021
 */

using System.Security.Cryptography;
using System.Text;

namespace westga_emr.Helpers
{
    public static class PasswordHashSHA512
    {
        public static string GenerateSHA512String(string stringToHash)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(stringToHash);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}
