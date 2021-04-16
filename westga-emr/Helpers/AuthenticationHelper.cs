
using System.Security.Cryptography;
using System.Text;
using westga_emr.Model.DTO;

namespace westga_emr.Helpers
{
    /// <summary>
    /// Helper class to handle authentication flow
    /// </summary>
    public static class AuthenticationHelper
    {
        /// <summary>
        /// the current user
        /// </summary>
        public static UserDTO currentUser { get; set; }

        /// <summary>
        /// Sets the current user
        /// </summary>
        /// <param name="user"></param>
        public static void SetCurrentUser(UserDTO user)
        {
            currentUser = user;
        }
        public static string HashPassword(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}
