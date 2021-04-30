using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;
using westga_emr.Model.DTO;
using westga_emr.Helpers;

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
            String selectStatement = @"SELECT id, username, firstName, lastName, dateOfBirth, ssn, gender, addressID, contactPhone
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
                            string social = null;
                            if (!reader.IsDBNull(ordSSN))
                            {
                                social = reader.GetString(ordSSN);
                            }
                            persons.Add(new Person(reader.GetInt32(ordID), user, null,
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
        /// Returns the Person of the Patient.
        /// 
        /// Returns password as null.
        /// </summary>
        /// <param name="patient">The Patient</param>
        /// <returns>Person of the Patient</returns>
        public static Person GetPersonByPatientID(Patient patient)
        {
            Person person = null;
            String selectStatement = @"SELECT Person.id, username, firstName, lastName, dateOfBirth, ssn, gender, addressID, contactPhone
                                        FROM Person
	                                        JOIN Patient on Person.id = Patient.personID
                                        WHERE Patient.id = @patientID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@patientID", patient.ID);
                    connection.Open();
                    person = GetPerson(command);
                }
            }
            return person;
        }

        /// <summary>
        /// Returns the Person of the Doctor.
        /// 
        /// Returns password as null.
        /// </summary>
        /// <param name="patient">The Doctor</param>
        /// <returns>Person of the Doctor</returns>
        public static Person GetPersonByDoctorID(Doctor doctor)
        {
            Person person = null;
            String selectStatement = @"SELECT Person.id, username, firstName, lastName, dateOfBirth, ssn, gender, addressID, contactPhone
                                        FROM Person
	                                        JOIN Doctor on Person.id = Doctor.personID
                                        WHERE Doctor.id = @doctorID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@doctorID", doctor.ID);
                    connection.Open();
                    person = GetPerson(command);
                }
            }
            return person;
        }

        /// <summary>
        /// Gets the Person of the Nurse by their id.
        /// 
        /// Returns password as null.
        /// </summary>
        /// <param name="nurse">Nurse whose Person is desired</param>
        /// <returns>Person of the Nurse</returns>
        public static Person GetPersonByNurseID(Nurse nurse)
        {
            Person person = null;
            String selectStatement = @"SELECT Person.id, username, firstName, lastName, dateOfBirth, ssn, gender, addressID, contactPhone
                                        FROM Person
	                                        JOIN Nurse on Person.id = Nurse.personID
                                        WHERE Nurse.id = @nurseID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@nurseID", nurse.ID);
                    connection.Open();
                    person = GetPerson(command);
                }
            }
            return person;
        }

        /// <summary>
        /// Gets the Person of the Clinical_Administor by their adminID.
        /// 
        /// Returns password as null.
        /// </summary>
        /// <param name="admin">Clinical_Administrator whose Person you desire</param>
        /// <returns>Person of the Clinical_Administrator</returns>
        public static Person GetPersonByClinicalAdministratorID(Clinical_Administrator admin)
        {
            Person person = null;
            String selectStatement = @"SELECT Person.id, username, firstName, lastName, dateOfBirth, ssn, gender, addressID, contactPhone
                                        FROM Person
	                                        JOIN Clinical_Administrator on Person.id = Clinical_Administrator.personID
                                        WHERE Clinical_Administrator.id = @adminID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@adminID", admin.ID);
                    connection.Open();
                    person = GetPerson(command);
                }
            }
            return person;
        }

        private static Person GetPerson(SqlCommand command)
        {
            Person person = null;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                int ordID = reader.GetOrdinal("id");
                int ordUsername = reader.GetOrdinal("username");
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
                    string social = null;
                    if (!reader.IsDBNull(ordSSN))
                    {
                        social = reader.GetString(ordSSN);
                    }
                    person = new Person(reader.GetInt32(ordID), user, null,
                        reader.GetString(ordFirstName), reader.GetString(ordLastName),
                        reader.GetDateTime(ordDateOfBirth), social, reader.GetString(ordGender),
                        reader.GetInt32(ordAddressID), reader.GetString(ordContactPhone));
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
            string hash = Helpers.PasswordHashSHA512.GenerateSHA512String(password);
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
                WHERE P.username = @Username and P.password = @Password";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectUserStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Username", username);
                    selectCommand.Parameters.AddWithValue("@Password", hash);
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
        public List<UserDTO> SearchPatient(string firstName, string lastName, DateTime? dateOfBirth)
        {
            var patients = new List<UserDTO>();
            string selectUserStatement = @"
                SELECT P.id as personId, username,firstName, CONCAT(firstName, ' ', lastName) as fullName,
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
                        selectCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.Value.Date);
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserDTO patient = new UserDTO();
                            patient.Id = (int)reader["personId"];
                            patient.FullName = reader["fullName"].ToString();
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
           
            return patients;
        }

        /// <summary>
        /// Checks to see if SSN exists in DB
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public bool SocialSecurityExist(string ssn)
        {
            bool ssnExist = false;
            string selectStatement = "SELECT id FROM Person WHERE ssn = @ssn";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@ssn", ssn);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine(reader);
                            ssnExist = true;
                        }
                    }
                }
            }
            return ssnExist;
        }

        /// <summary>
        /// Inserts a new Person into the db
        /// </summary>
        /// <param name="person">Person to insert</param>
        /// <returns>The id of the newly inserted Person, or null if the insert failed</returns>
        public static int? InsertPerson(Person person)
        {
            int? id = null;
            String insertStatement = @"INSERT INTO Person(username, password, firstName, lastName, dateOfBirth, ssn, gender, addressID, contactPhone)
                                        OUTPUT inserted.id
			                            VALUES (@username, @password, @firstName, @lastName, @dateOfBirth, @ssn, @gender, @addressID, @contactPhone)";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {
                    if (string.IsNullOrWhiteSpace(person.Username))
                    {
                        command.Parameters.AddWithValue("@username", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@username", person.Username);
                    }

                    if (string.IsNullOrWhiteSpace(person.Password))
                    {
                        command.Parameters.AddWithValue("@password", DBNull.Value);
                    } 
                    else
                    {
                        string hash = PasswordHashSHA512.GenerateSHA512String(person.Password);
                        command.Parameters.AddWithValue("@password", hash);
                    }

                    if (string.IsNullOrWhiteSpace(person.SSN))
                    {
                        command.Parameters.AddWithValue("@ssn", DBNull.Value);
                    } 
                    else
                    {
                        command.Parameters.AddWithValue("@ssn", person.SSN);
                    }
                    
                    command.Parameters.AddWithValue("@firstName", person.FirstName);
                    command.Parameters.AddWithValue("@lastName", person.LastName);
                    command.Parameters.AddWithValue("@dateOfBirth", person.DateOfBirth);
                    command.Parameters.AddWithValue("@gender", person.Gender);
                    command.Parameters.AddWithValue("@addressID", person.AddressID);
                    command.Parameters.AddWithValue("@contactPhone", person.ContactPhone);

                    id = (int?)command.ExecuteScalar();
                }
            }
            return id;
        }

        /// <summary>
        /// Updates a Person in the db
        /// </summary>
        /// <param name="person">Person to update</param>
        /// <returns>Whether or not the update succeeded</returns>
        public static bool UpdatePerson(Person person)
        {
            int rowsUpdated;
            String updateStatement = @"UPDATE Person
			                            SET username = @username, password = @password, firstName = @firstName, lastName = @lastName, dateOfBirth = @dateOfBirth,
				                            ssn = @ssn, gender = @gender, addressID = @addressID, contactPhone = @contactPhone
			                            WHERE id = @personID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(updateStatement, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@personID", person.ID);
                    if (string.IsNullOrWhiteSpace(person.Username))
                    {
                        command.Parameters.AddWithValue("@username", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@username", person.Username);
                    }

                    if (string.IsNullOrWhiteSpace(person.Password))
                    {
                        command.Parameters.AddWithValue("@password", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@password", Helpers.PasswordHashSHA512.GenerateSHA512String(person.Password));
                    }
                    if (string.IsNullOrWhiteSpace(person.SSN))
                    {
                        command.Parameters.AddWithValue("@ssn", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ssn", person.SSN);
                    }

                    command.Parameters.AddWithValue("@firstName", person.FirstName);
                    command.Parameters.AddWithValue("@lastName", person.LastName);
                    command.Parameters.AddWithValue("@dateOfBirth", person.DateOfBirth);
                    command.Parameters.AddWithValue("@gender", person.Gender);
                    command.Parameters.AddWithValue("@addressID", person.AddressID);
                    command.Parameters.AddWithValue("@contactPhone", person.ContactPhone);

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

        public static int HashDBPasswords()
        {
            int rowsUpdated = 0;
            string query = @"IF (SELECT COL_LENGTH('dbo.Person', 'password')) <> 64
                               BEGIN
                                ALTER TABLE db.Person
                                ALTER COLUMN password varchar(64) null;
                               END
                              update Person
                              set password = CONVERT(VARCHAR(64),HashBytes('SHA2_256', Person.password),2)
                              where LEN(password) <> 64";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    rowsUpdated = command.ExecuteNonQuery();
                }
            }
            return rowsUpdated;
        }
    }
}
