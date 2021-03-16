using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages queries to the Patient table
    /// </summary>
    public class PatientDAL
    {
        /// <summary>
        /// Gets a list of all patients in the WestGA-EMR db
        /// </summary>
        /// <returns>List of all Patients</returns>
        public static List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            String selectStatement = @"SELECT id, personID, active
                                        FROM Patient";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("id");
                        int ordPersonID = reader.GetOrdinal("personID");
                        int ordActive = reader.GetOrdinal("active");
                        while (reader.Read())
                        {
                            patients.Add(new Patient(reader.GetInt32(ordID),
                                reader.GetInt32(ordPersonID), reader.GetBoolean(ordActive)));
                        }
                    }
                }
            }
            return patients;
        }
    }
}
