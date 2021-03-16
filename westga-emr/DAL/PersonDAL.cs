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
                            persons.Add(new Person(reader.GetInt32(ordID), user, pass,
                                reader.GetString(ordFirstName), reader.GetString(ordLastName),
                                reader.GetDateTime(ordDateOfBirth), social, reader.GetString(ordGender),
                                reader.GetInt32(ordAddressID), reader.GetString(ordContactPhone)));
                        }
                    }
                }
            }
            return persons;
        }

        /// <summary>
        /// Finds a Person by their username and password. Returns null if user does not exist
        /// </summary>
        /// <param name="username">Username of Person to find</param>
        /// <param name="password">Password of Person to find</param>
        /// <returns></returns>
        public static Person GetPersonByUsernameAndPassword(string username, string password)
        {
            Person person = null;
            String selectStatement = @"SELECT id, username, password, firstName, lastName, dateOfBirth, ssn, gender, addressID, contactPhone
                                        FROM Person
                                        WHERE username = @username AND password = @password";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
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
                            person = new Person(reader.GetInt32(ordID), user, pass,
                                reader.GetString(ordFirstName), reader.GetString(ordLastName),
                                reader.GetDateTime(ordDateOfBirth), social, reader.GetString(ordGender),
                                reader.GetInt32(ordAddressID), reader.GetString(ordContactPhone));
                        }
                    }
                }
            }
            return person;
        }
    }
}
