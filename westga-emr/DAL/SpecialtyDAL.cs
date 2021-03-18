using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages queries to the Specialty table
    /// </summary>
    public class SpecialtyDAL
    {
        /// <summary>
        /// Gets a list of all specialties in the db
        /// </summary>
        /// <returns>List of all Specialties in db</returns>
        public static List<Specialty> GetSpecialties()
        {
            List<Specialty> specialties = new List<Specialty>();
            String selectStatement = @"SELECT name FROM Specialty";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordName = reader.GetOrdinal("name");
                        while (reader.Read())
                        {
                            specialties.Add(new Specialty(reader.GetString(ordName)));
                        }
                    }
                }
            }
            return specialties;
        }
    }
}
