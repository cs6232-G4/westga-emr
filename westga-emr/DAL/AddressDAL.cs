using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages SQL queries to the Address table of the WestGA-EMR db
    /// </summary>
    public class AddressDAL
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

        /// <summary>
        /// Gets an address by it's id
        /// </summary>
        /// <param name="id">ID of the Address</param>
        /// <returns>The Address</returns>
        public static Address GetAddress(int id)
        {
            Address address = null;
            String selectStatement = @"SELECT id, street, city, state, zip FROM Address WHERE id = @id";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("id");
                        int ordStreet = reader.GetOrdinal("street");
                        int ordCity = reader.GetOrdinal("city");
                        int ordState = reader.GetOrdinal("state");
                        int ordZip = reader.GetOrdinal("zip");
                        while (reader.Read())
                        {
                            address = new Address(reader.GetInt32(ordID),
                                reader.GetString(ordStreet), reader.GetString(ordCity),
                                reader.GetString(ordState), reader.GetString(ordZip));
                        }
                    }
                }
            }
            return address;
        }

        /// <summary>
        /// Inserts an Address into the db
        /// </summary>
        /// <param name="address">The Address to insert</param>
        /// <returns>The id of the inserted Address, or null if it did not go through</returns>
        public static int? InsertAddress(Address address)
        {
            int? id = null;
            String insertStatement = @"INSERT INTO Address(street, city, state, zip)
                                        OUTPUT inserted.id
			                            VALUES (@street, @city, @state, @zip)";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {
                    command.Parameters.AddWithValue("@street", address.Street);
                    command.Parameters.AddWithValue("@city", address.City);
                    command.Parameters.AddWithValue("@state", address.State);
                    command.Parameters.AddWithValue("@zip", address.Zip);

                    id = (int?) command.ExecuteScalar();
                }
            }
            return id;
        }

        /// <summary>
        /// Updates an Address in the db
        /// </summary>
        /// <param name="address">The Address to update</param>
        /// <returns>Whether or not the update succeeded</returns>
        public static bool UpdateAddress(Address address)
        {
            int rowsUpdated;
            String updateStatement = @"UPDATE Address
			                            SET street = @street, city = @city, state = @state, zip = @zip
			                            WHERE id = @addressID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(updateStatement, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@addressID", address.ID);
                    command.Parameters.AddWithValue("@street", address.Street);
                    command.Parameters.AddWithValue("@city", address.City);
                    command.Parameters.AddWithValue("@state", address.State);
                    command.Parameters.AddWithValue("@zip", address.Zip);

                    rowsUpdated = command.ExecuteNonQuery();
                }
            }
            if (rowsUpdated < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
