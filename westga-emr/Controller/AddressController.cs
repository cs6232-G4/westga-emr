using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for the Address DAL and Model
    /// </summary>
    public class AddressController
    {
        /// <see cref="AddressDAL.GetAddresses"/>
        public List<Address> GetAddresses()
        {
            return AddressDAL.GetAddresses();
        }
    }
}
