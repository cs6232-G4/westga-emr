using System;
using System.Security.Cryptography;

namespace westga_emr.Helpers
{
    /// <summary>
    /// Utility class for working with storage and verification of hashed passwords
    /// </summary>
    public sealed class PasswordHash
    {
        const int SaltSize = 16, HashSize = 20, HashIter = 10000;
        readonly byte[] _salt, _hash;

        public byte[] Salt { get { return (byte[])_salt.Clone(); } }
        public byte[] Hash { get { return (byte[])_hash.Clone(); } }

        /// <summary>
        /// Create a PasswordHash from the given password
        /// </summary>
        /// <param name="password">Password to create a PasswordHash from</param>
        public PasswordHash(string password)
        {
            new RNGCryptoServiceProvider().GetBytes(_salt = new byte[SaltSize]);
            _hash = new Rfc2898DeriveBytes(password, _salt, HashIter).GetBytes(HashSize);
        }

        /// <summary>
        /// Create a PasswordHash from the given hashBytes
        /// </summary>
        /// <param name="hashBytes">hashBytes to create PasswordHash from</param>
        public PasswordHash(byte[] hashBytes)
        {
            Array.Copy(hashBytes, 0, _salt = new byte[SaltSize], 0, SaltSize);
            Array.Copy(hashBytes, SaltSize, _hash = new byte[HashSize], 0, HashSize);
        }

        /// <summary>
        /// Create a PasswordHash from the given hash and salt
        /// </summary>
        /// <param name="salt">Salt to create PasswordHash from</param>
        /// <param name="hash">Hash to create PasswordHash from</param>
        public PasswordHash(byte[] salt, byte[] hash)
        {
            Array.Copy(salt, 0, _salt = new byte[SaltSize], 0, SaltSize);
            Array.Copy(hash, 0, _hash = new byte[HashSize], 0, HashSize);
        }

        /// <summary>
        /// Returns this PasswordHash as an array of bytes
        /// </summary>
        /// <returns>This PasswordHash as an array of bytes</returns>
        public byte[] ToArray()
        {
            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(_salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(_hash, 0, hashBytes, SaltSize, HashSize);
            return hashBytes;
        }

        /// <summary>
        /// Verifies if this PasswordHash matches the given password's hash
        /// </summary>
        /// <param name="password">Password to verify</param>
        /// <returns>Whether or not this matches the given password's hash</returns>
        public bool Verify(string password)
        {
            byte[] test = new Rfc2898DeriveBytes(password, _salt, HashIter).GetBytes(HashSize);
            for (int i = 0; i < HashSize; i++)
            {
                if (test[i] != Hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
