using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages Sql queries to the Nurse table
    /// </summary>
    public class NurseDAL
    {
        /// <summary>
        /// Gets a list of all nurses in the WestGA-EMR db
        /// </summary>
        /// <returns>List of all Nurses</returns>
        public static List<Nurse> GetNurses()
        {
            List<Nurse> nurses = new List<Nurse>();
            String selectStatement = @"SELECT id, personID, active
                                        FROM Nurse";
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
                            nurses.Add(new Nurse(reader.GetInt32(ordID),
                                reader.GetInt32(ordPersonID), reader.GetBoolean(ordActive)));
                        }
                    }
                }
            }
            return nurses;
        }
    }
}
