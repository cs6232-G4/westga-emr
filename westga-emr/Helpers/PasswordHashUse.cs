using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace westga_emr.Helpers
{
    public static class PasswordHashUse
    {
        /// <summary>
        /// Hashes a Password so that it can be saved into a db.
        /// </summary>
        /// <param name="password">Password to hash</param>
        /// <returns>Hash of the password</returns>
        public static byte[] HashPassword(string password)
        {
            return new PasswordHash(password).ToArray();
        }

        /// <summary>
        /// Verify a password against its hash in the db
        /// </summary>
        /// <param name="hashedFromDB">Hash obtained from a db</param>
        /// <param name="password">Password to verify</param>
        /// <returns></returns>
        public static bool VerifyPassword(byte[] hashFromDB, string password)
        {
            return new PasswordHash(hashFromDB).Verify(password);
        }
    }
}
