using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// Handles Sql queries to the Doctor_has_Specialties table
    /// </summary>
    public class Doctor_has_SpecialtiesDAL
    {
        /// <summary>
        /// Gets a list of all doctor_has_specialty relations in the db
        /// </summary>
        /// <returns>List of all Doctor_has_Specialties relations</returns>
        public static List<Doctor_has_Specialties> GetDoctor_has_Specialties()
        {
            List<Doctor_has_Specialties> relations = new List<Doctor_has_Specialties>();
            String selectStatement = @"SELECT doctorID, specialtyName
                                        FROM Doctor_has_Specialties";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordDoctorID = reader.GetOrdinal("doctorID");
                        int ordSpecialtyName = reader.GetOrdinal("specialtyName");
                        while (reader.Read())
                        {
                            relations.Add(new Doctor_has_Specialties(reader.GetInt32(ordDoctorID),
                                reader.GetString(ordSpecialtyName)));
                        }
                    }
                }
            }
            return relations;
        }
    }
}
