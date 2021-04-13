using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace westga_emr.Helpers
{
    public static class PasswordHashUse
    {
        public static byte[] GetHash(string password)
        {
            return new PasswordHash(password).ToArray();
        }

        public static bool Verify(byte[] hashedPassword, string password)
        {
            return new PasswordHash(hashedPassword).Verify(password);
        }
    }
}
