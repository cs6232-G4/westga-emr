using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages SQL queries to the Address table of the WestGA-EMR db
    /// </summary>
    class AddressDAL
    {
        /// <summary>
        /// Gets a list of all addresses in the db
        /// </summary>
        /// <returns>List of all Addresses in db</returns>
        public static List<Address> GetAddresses()
        {
            List<Address> addresses = new List<Address>();
            String selectStatement = @"SELECT id, street, city, state, zip FROM Address";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("id");
                        int ordStreet = reader.GetOrdinal("street");
                        int ordCity = reader.GetOrdinal("city");
                        int ordState = reader.GetOrdinal("state");
                        int ordZip = reader.GetOrdinal("zip");
                        while (reader.Read())
                        {
                            addresses.Add(new Address(reader.GetInt32(ordID),
                                reader.GetString(ordStreet), reader.GetString(ordCity),
                                reader.GetString(ordState), reader.GetString(ordZip)));
                        }
                    }
                }
            }
            return addresses;
        }
    }
}
