using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;
using westga_emr.Model.DTO;

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
        /// Inserts a new Patient into the db
        /// </summary>
        /// <param name="patient">Patient to insert</param>
        /// <returns>ID of the newly inserted Patient, or null if the insertion failed</returns>
        public static int? InsertPatient(Patient patient)
        {
            int? id = null;
            String insertStatement = @"INSERT INTO Patient (personID, active)
                                        OUTPUT inserted.id
			                            VALUES (@personID, @active)";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {
                    command.Parameters.AddWithValue("@personID", patient.PersonID);
                    command.Parameters.AddWithValue("@active", patient.Active);

                    id = (int?)command.ExecuteScalar();
                }
            }
            return id;
        }

        /// <summary>
        /// Updates a patient in the db
        /// </summary>
        /// <param name="patient">Patient to update</param>
        /// <returns>Whether or not the update succeeded</returns>
        public static bool UpdatePatient(Patient patient)
        {
            int rowsUpdated;
            String updateStatement = @"UPDATE Patient
			                            SET active = @active, personID = @personID
			                            WHERE id = @patientID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(updateStatement, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@patientID", patient.ID);
                    command.Parameters.AddWithValue("@personID", patient.PersonID);
                    command.Parameters.AddWithValue("@active", patient.Active);

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

        /// <summary>
        /// Method to check if patient already has appointment for particular time
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="appointmentTime"></param>
        /// <returns></returns>
        public bool PatietHasAppointment(int patientId, DateTime appointmentTime)
        {
            bool appointmentExist = false;
            string selectStatement = @"SELECT id FROM Appointment where patientID = @PatientId and appointmentDateTime = @AppointmentDateTime";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientId", patientId);
                    selectCommand.Parameters.AddWithValue("@AppointmentDateTime", appointmentTime);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            appointmentExist = true;
                        }
                    }
                }
            }
            return appointmentExist;
        }

        /// <summary>
        /// Gets a patient information by patient id
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        public static UserDTO GetPatientById(int patientId)
        {
            UserDTO patient = new UserDTO();
            string selectStatement = @"SELECT p.id as personId, firstName, lastName, dateOfBirth, ssn, gender, addressID, contactPhone, pt.id as patientId
                                    FROM Patient as pt
	                                    JOIN Person as p ON pt.personID = p.id
                                    WHERE pt.active = 1
	                                    AND pt.id = @PatientId";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientId", patientId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            patient.Id = (int)reader["personId"];
                            patient.FirstName = reader["firstName"].ToString();
                            patient.LastName = reader["lastName"].ToString();
                            patient.SSN = reader["ssn"].ToString();
                            patient.Gender = reader["gender"].ToString();
                            patient.ContactPhone = reader["contactPhone"].ToString();
                            patient.AddressId = reader["addressID"] != DBNull.Value ? (int)reader["addressID"] : 0;
                            patient.DateOfBirth = reader["dateOfBirth"] != DBNull.Value ? (DateTime)reader["dateOfBirth"] : (DateTime?)null;
                            patient.PatientId = (int)reader["patientId"];
                            patient.IsActivePatient = true;

                        };
                    }
                }
            }
            return patient;
        }

        /// <summary>
        /// Deletes the given Patient from the db
        /// </summary>
        /// <param name="patient">Patient to delete from the db</param>
        /// <returns>Whether or not the Patient was deleted</returns>
        public static bool DeletePatient(Patient patient)
        {
            bool wasDeleted = false;
            String deleteStatement = @"DELETE FROM Patient WHERE Patient.id = @patientID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(deleteStatement, connection))
                {
                    command.Parameters.AddWithValue("@patientID", patient.ID);

                    wasDeleted = command.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            return wasDeleted;
        }
    }
}
