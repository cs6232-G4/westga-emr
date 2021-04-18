using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using System;

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

        /// <see cref="AddressDAL.GetAddress(int)"/>
        public Address GetAddress(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException("invalid id");
            }
            return AddressDAL.GetAddress(id);
        }
    }
}
