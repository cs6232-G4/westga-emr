using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;
using westga_emr.Model.DTO;

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

        /// <summary>
        /// Method to check if User exists
        /// </summary>
        /// <param name="username"></param>
        /// <returns>true if username exists and false if user does not exist</returns>
        public bool UserExist(string username)
        {
            bool userExist = false;
            string selectStatement = "SELECT id FROM Person WHERE username = @Username";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine(reader);
                            userExist = true;
                        }
                    }
                }
            }
            return userExist;
        }

        /// <summary>
        /// Method to Sign In User
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>The current user</returns>
        public UserDTO SignIn( string username, string password)
        {
            UserDTO currentUser = new UserDTO();
            string selectUserStatement = @"
                SELECT P.id as personId, username,firstName, 
                        lastName, dateOfBirth, ssn, gender,
                        addressID, contactPhone, N.id as NurseId, C.id as AdminId, 
                        street, city, state, zip
                FROM Person P 
                FULL OUTER JOIN Nurse N ON P.id = N.personID
	            FULL OUTER JOIN Clinical_Administrator C ON P.id = C.personID
	            FULL OUTER JOIN Address A ON P.addressID = A.id
                WHERE P.username = @Username AND P.password = @Password";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectUserStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Username", username);
                    selectCommand.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentUser = new UserDTO();
                            currentUser.Id = (int)reader["personId"];
                            currentUser.Username = reader["username"].ToString();
                            currentUser.FirstName = reader["firstName"].ToString();
                            currentUser.LastName = reader["lastName"].ToString();
                            currentUser.SSN = reader["ssn"].ToString();
                            currentUser.Gender = reader["gender"].ToString();
                            currentUser.ContactPhone = reader["contactPhone"].ToString();
                            currentUser.Street = reader["street"].ToString();
                            currentUser.State = reader["city"].ToString();
                            currentUser.City = reader["state"].ToString();
                            currentUser.Zip = reader["zip"].ToString();
                            currentUser.AddressId = reader["addressID"] != DBNull.Value ? (int)reader["addressID"] : 0;
                            currentUser.AdminId = reader["AdminId"] != DBNull.Value ? (int)reader["AdminId"] : 0;
                            currentUser.NurseId = reader["NurseId"] != DBNull.Value ? (int)reader["NurseId"] : 0;
                            currentUser.DateOfBirth = reader["dateOfBirth"] != DBNull.Value ? (DateTime)reader["dateOfBirth"] : (DateTime?)null;

                        } else
                        {
                            throw new Exception("Incorrect username or password");
                        }
                    }
                }
            }
            return currentUser;
        }

    }
}
