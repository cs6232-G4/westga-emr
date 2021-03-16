using System;
using System.Linq;

namespace westga_emr.Model
{
    /// <summary>
    /// Models an Address in the WestGA-EMR
    /// </summary>
    public class Address
    {
        public int ID { get; }
        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }

        /// <summary>
        /// Constructs an instance of Address according to the given data
        /// </summary>
        /// <param name="id">SQL Server's ID of the Address</param>
        /// <param name="street">Street of the Address</param>
        /// <param name="city">City of the Address</param>
        /// <param name="state">State of the Address</param>
        /// <param name="zip">Zip code of the Address</param>
        public Address(int id, string street, string city, string state, string zip)
        {
            if (id < 1)
            {
                throw new ArgumentException("id must be greater than zero");
            }
            if (string.IsNullOrWhiteSpace(street) || string.IsNullOrWhiteSpace(city)
                || string.IsNullOrWhiteSpace(state) || string.IsNullOrWhiteSpace(zip))
            {
                throw new ArgumentException("street, city, state, and zip cannot be null, empty, or " +
                    "consist only of white space");
            }
            if (zip.Length != 5 || !zip.All(char.IsDigit))
            {
                throw new ArgumentException("zip must be 5 characters in length and consist only of numbers");
            }
            if (state.Length != 2 || !state.All(char.IsLetter))
            {
                throw new ArgumentException("state must be 2 characters in length and consist only of letters");
            }
            this.ID = id;
            this.Street = street;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }
    }
}
