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
        /// Returns the Person of the Patient
        /// </summary>
        /// <param name="patient">The Patient</param>
        /// <returns>Person of the Patient</returns>
        public static Person GetPersonByPatientID(Patient patient)
        {
            Person person = null;
            String selectStatement = @"SELECT Person.id, username, password, firstName, lastName, dateOfBirth, ssn, gender, addressID, contactPhone
                                        FROM Person
	                                        JOIN Patient on Person.id = Patient.personID
                                        WHERE Patient.id = @patientID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@patientID", patient.ID);
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
        /// Returns the Person of the Doctor
        /// </summary>
        /// <param name="patient">The Doctor</param>
        /// <returns>Person of the Doctor</returns>
        public static Person GetPersonByDoctorID(Doctor doctor)
        {
            Person person = null;
            String selectStatement = @"SELECT Person.id, username, password, firstName, lastName, dateOfBirth, ssn, gender, addressID, contactPhone
                                        FROM Person
	                                        JOIN Doctor on Person.id = Doctor.personID
                                        WHERE Doctor.id = @doctorID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@doctorID", doctor.ID);
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
                        N.active as IsActiveNurse, C.active as IsActiveAdmin,
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
                            currentUser.State = reader["state"].ToString();
                            currentUser.City = reader["city"].ToString();
                            currentUser.Zip = reader["zip"].ToString();
                            currentUser.AddressId = reader["addressID"] != DBNull.Value ? (int)reader["addressID"] : 0;
                            currentUser.AdminId = reader["AdminId"] != DBNull.Value ? (int)reader["AdminId"] : 0;
                            currentUser.NurseId = reader["NurseId"] != DBNull.Value ? (int)reader["NurseId"] : 0;
                            currentUser.DateOfBirth = reader["dateOfBirth"] != DBNull.Value ? (DateTime)reader["dateOfBirth"] : (DateTime?)null;
                            currentUser.IsActiveNurse = reader["IsActiveNurse"] != DBNull.Value ? (bool)reader["IsActiveNurse"] : false;
                            currentUser.IsActiveAdmin = reader["IsActiveAdmin"] != DBNull.Value ? (bool)reader["IsActiveAdmin"] : false;

                        } else
                        {
                            throw new Exception("Incorrect username or password");
                        }
                    }
                }
            }
            return currentUser;
        }

        /// <summary>
        /// Search for a user in the database
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <returns>A user that matches the search criteria</returns>
        public UserDTO SearchPatient(string firstName, string lastName, DateTime dateOfBirth)
        {
            var patients = new List<UserDTO>();
            UserDTO patient = null;
            string selectUserStatement = @"
                SELECT P.id as personId, username,firstName, 
                        lastName, dateOfBirth, ssn, gender,
                        addressID, contactPhone, U.id as PatientId,
                        street, city, state, zip
                FROM Person P 
                INNER JOIN Patient U ON P.id = U.personID
	            INNER JOIN Address A ON P.addressID = A.id
                WHERE (P.firstName = @FirstName AND P.lastname = @LastName) OR 
                    (CAST(P.dateOfBirth AS date) = @DateOfBirth) OR
                    (CAST(P.dateOfBirth AS date) = @DateOfBirth and P.lastName = @LastName) ";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectUserStatement, connection))
                {
                    if (String.IsNullOrWhiteSpace(firstName))
                    {
                        selectCommand.Parameters.AddWithValue("@FirstName", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@FirstName", firstName);
                    }
                    if (String.IsNullOrWhiteSpace(lastName))
                    {
                        selectCommand.Parameters.AddWithValue("@LastName", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@LastName", lastName);
                    }
                    if (dateOfBirth == null)
                    {
                        selectCommand.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.Date);
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patient = new UserDTO();
                            patient.Id = (int)reader["personId"];
                            patient.Username = reader["username"].ToString();
                            patient.FirstName = reader["firstName"].ToString();
                            patient.LastName = reader["lastName"].ToString();
                            patient.SSN = reader["ssn"].ToString();
                            patient.Gender = reader["gender"].ToString();
                            patient.ContactPhone = reader["contactPhone"].ToString();
                            patient.Street = reader["street"].ToString();
                            patient.State = reader["state"].ToString();
                            patient.City = reader["city"].ToString();
                            patient.Zip = reader["zip"].ToString();
                            patient.AddressId = reader["addressID"] != DBNull.Value ? (int)reader["addressID"] : 0;
                            patient.PatientId = reader["PatientId"] != DBNull.Value ? (int)reader["PatientId"] : 0;
                            patient.DateOfBirth = reader["dateOfBirth"] != DBNull.Value ? (DateTime)reader["dateOfBirth"] : (DateTime?)null;
                            patients.Add(patient);
                        }
                        
                    }
                }
            }
            if (patients.Count <= 0)
            {
                return patient;

            }
            else if (patients.Count > 1)
            {
                throw new Exception("The search result returned multiple patients.Please search again");
            }
            return patients[0];
        }
    }
}
