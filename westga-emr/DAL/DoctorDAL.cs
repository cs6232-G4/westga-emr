using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages queries to the Doctor table of the WestGA-EMR db
    /// </summary>
    public class DoctorDAL
    {
        /// <summary>
        /// Gets a list of all doctors in the WestGA-EMR db
        /// </summary>
        /// <returns>List of all Doctors</returns>
        public static List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            String selectStatement = @"SELECT id, personID, active
                                        FROM Doctor";
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
                            doctors.Add(new Doctor(reader.GetInt32(ordID),
                                reader.GetInt32(ordPersonID), reader.GetBoolean(ordActive)));
                        }
                    }
                }
            }
            return doctors;
        }
    }
}
