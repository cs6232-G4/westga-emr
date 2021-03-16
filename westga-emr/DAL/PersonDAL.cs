using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages Sql queries to the Person table
    /// </summary>
    public class PersonDAL
    {
        /// <summary>
        /// Gets a list of all persons in the db
        /// </summary>
        /// <returns>List of all Persons in db</returns>
        public static List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();
            String selectStatement = @"SELECT id, username, password, firstName, lastName, dateOfBirth, ssn, gender, addressID, contactPhone
                                        FROM Person";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("id");
                        int ordUsername = reader.GetOrdinal("username");
                        int ordPassword = reader.GetOrdinal("password");
                        int ordFirstName = reader.GetOrdinal("firstName");
                        int ordLastName = reader.GetOrdinal("lastName");
                        int ordDateOfBirth = reader.GetOrdinal("dateOfBirth");
                        int ordSSN = reader.GetOrdinal("ssn");
                        int ordGender = reader.GetOrdinal("gender");
                        int ordAddressID = reader.GetOrdinal("addressID");
                        int ordContactPhone = reader.GetOrdinal("contactPhone");
                        while (reader.Read())
                        {
                            string user = null;
                            if (!reader.IsDBNull(ordUsername))
                            {
                                user = reader.GetString(ordUsername);
                            }
                            string pass = null;
                            if (!reader.IsDBNull(ordPassword))
                            {
                                pass = reader.GetString(ordPassword);
                            }
                            string social = null;
                            if (!reader.IsDBNull(ordSSN))
                            {
                                social = reader.GetString(ordSSN);
                            }
                            persons.Add(new Person(reader.GetInt32(ordInt), user, pass,
                                reader.GetString(ordFirstName), reader.GetString(ordLastName),
                                reader.GetDateTime(ordDateOfBirth), social, reader.GetString(ordGender),
                                reader.GetInt32(ordAddressID), reader.GetString(ordContactPhone)));
                        }
                    }
                }
            }
            return persons;
        }
    }
}
