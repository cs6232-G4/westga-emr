
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

    }
}
