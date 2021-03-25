using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages queries about Patients
    /// </summary>
    public class PatientDAL
    {

        /// <summary>
        /// Gets a list of all active patients in the WestGA-EMR db.
        /// Returns patient's username and password as null.
        /// </summary>
        /// <returns>List of all active patients as Persons</returns>
        public static List<Person> GetAllActivePatients()
        {
            List<Person> patients = new List<Person>();
            String selectStatement = @"SELECT p.id, null as username, null as password, 
	                                    p.firstName, p.lastName, p.dateOfBirth, p.ssn, 
	                                    p.gender, p.addressID, p.contactPhone
                                    FROM Patient as pt
	                                    JOIN Person as p ON pt.personID = p.id
                                    WHERE pt.active = 1";
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
                            string social = null;
                            if (!reader.IsDBNull(ordSSN))
                            {
                                social = reader.GetString(ordSSN);
                            }
                            patients.Add(new Person(reader.GetInt32(ordID), null, null,
                                reader.GetString(ordFirstName), reader.GetString(ordLastName),
                                reader.GetDateTime(ordDateOfBirth), social, reader.GetString(ordGender),
                                reader.GetInt32(ordAddressID), reader.GetString(ordContactPhone)));
                        }
                    }
                }
            }
            return patients;
        }

        /// <summary>
        /// Gets a list of active patients in the db according to the given date of birth.
        /// Returns patient's username and password as null.
        /// </summary>
        /// <param name="dateOfBirth">Date of birth of patients to find</param>
        /// <returns>List of all matching patients as Persons</returns>
        public static List<Person> GetActivePatientsByDoB(DateTime dateOfBirth)
        {
            List<Person> patients = new List<Person>();
            String selectStatement = @"SELECT p.id, null as username, null as password, 
	                                    p.firstName, p.lastName, p.dateOfBirth, p.ssn, 
	                                    p.gender, p.addressID, p.contactPhone
                                    FROM Patient as pt
	                                    JOIN Person as p ON pt.personID = p.id
                                    WHERE pt.active = 1
	                                    AND p.dateOfBirth = @dateOfBirth";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
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
                            string social = null;
                            if (!reader.IsDBNull(ordSSN))
                            {
                                social = reader.GetString(ordSSN);
                            }
                            patients.Add(new Person(reader.GetInt32(ordID), null, null,
                                reader.GetString(ordFirstName), reader.GetString(ordLastName),
                                reader.GetDateTime(ordDateOfBirth), social, reader.GetString(ordGender),
                                reader.GetInt32(ordAddressID), reader.GetString(ordContactPhone)));
                        }
                    }
                }
            }
            return patients;
        }

        /// <summary>
        /// Gets a list of all active patients in the db according to the given parameters.
        /// Returns patient's username and password as null.
        /// </summary>
        /// <param name="lastName">Last Name of the patient</param>
        /// <param name="dateOfBirth">Date of Birth of the patient</param>
        /// <returns>List of all matching patients as Persons</returns>
        public static List<Person> GetActivePatientsByDoBAndLastName(string lastName, DateTime dateOfBirth)
        {
            List<Person> patients = new List<Person>();
            String selectStatement = @"SELECT p.id, null as username, null as password, 
	                                    p.firstName, p.lastName, p.dateOfBirth, p.ssn, 
	                                    p.gender, p.addressID, p.contactPhone
                                    FROM Patient as pt
	                                    JOIN Person as p ON pt.personID = p.id
                                    WHERE pt.active = 1
	                                    AND p.dateOfBirth = @dateOfBirth
	                                    AND p.lastName = @lastName";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@lastName", lastName);
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
                            string social = null;
                            if (!reader.IsDBNull(ordSSN))
                            {
                                social = reader.GetString(ordSSN);
                            }
                            patients.Add(new Person(reader.GetInt32(ordID), null, null,
                                reader.GetString(ordFirstName), reader.GetString(ordLastName),
                                reader.GetDateTime(ordDateOfBirth), social, reader.GetString(ordGender),
                                reader.GetInt32(ordAddressID), reader.GetString(ordContactPhone)));
                        }
                    }
                }
            }
            return patients;
        }

        /// <summary>
        /// Gets a list of all active patients in the db according to the given parameters.
        /// Returns patient's username and password as null.
        /// </summary>
        /// <param name="firstName">Patient's first name</param>
        /// <param name="lastName">Patient's last name</param>
        /// <returns>List of all matching patients as Persons</returns>
        public static List<Person> GetActivePatientsByFirstAndLastName(string firstName, string lastName)
        {
            List<Person> patients = new List<Person>();
            String selectStatement = @"SELECT p.id, null as username, null as password, 
	                                    p.firstName, p.lastName, p.dateOfBirth, p.ssn, 
	                                    p.gender, p.addressID, p.contactPhone
                                    FROM Patient as pt
	                                    JOIN Person as p ON pt.personID = p.id
                                    WHERE pt.active = 1
	                                    AND p.lastName = @lastName
	                                    AND p.firstName = @firstName";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
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
                            string social = null;
                            if (!reader.IsDBNull(ordSSN))
                            {
                                social = reader.GetString(ordSSN);
                            }
                            patients.Add(new Person(reader.GetInt32(ordID), null, null,
                                reader.GetString(ordFirstName), reader.GetString(ordLastName),
                                reader.GetDateTime(ordDateOfBirth), social, reader.GetString(ordGender),
                                reader.GetInt32(ordAddressID), reader.GetString(ordContactPhone)));
                        }
                    }
                }
            }
            return patients;
        }

        /// <summary>
        /// Creates a new patient in the database, including their address.
        /// Sets patient's username and password to null, regardless of given parameters.
        /// </summary>
        /// <param name="patient">The Person of the patient to insert into the db</param>
        /// <param name="address">Patient's Address to insert into the db</param>
        /// <returns>Whether or not the insert succeeded or not</returns>
        public static bool RegisterPatient(Person patient, Address address)
        {
            int retValue;
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("registerPatient", connection))
                {
                    
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@street", address.Street);
                    command.Parameters.AddWithValue("@city", address.City);
                    command.Parameters.AddWithValue("@state", address.State);
                    command.Parameters.AddWithValue("@zip", address.Zip);

                    command.Parameters.AddWithValue("@firstName", patient.FirstName);
                    command.Parameters.AddWithValue("@lastName", patient.LastName);
                    command.Parameters.AddWithValue("@dateOfBirth", patient.DateOfBirth);
                    command.Parameters.AddWithValue("@ssn", patient.SSN);
                    command.Parameters.AddWithValue("@gender", patient.Gender);
                    command.Parameters.AddWithValue("@contactPhone", patient.ContactPhone);

                    retValue = command.ExecuteNonQuery();
                }
            }
            if (retValue == -1)
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
