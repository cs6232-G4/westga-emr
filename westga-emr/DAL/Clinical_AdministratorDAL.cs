using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages queries to the Clinical_Administrator table
    /// </summary>
    public class Clinical_AdministratorDAL
    {
        /// <summary>
        /// Gets a list of all clinical admins in the WestGA-EMR db
        /// </summary>
        /// <returns>List of all Clinical_Administrators</returns>
        public static List<Clinical_Administrator> GetClinicalAdministrators()
        {
            List<Clinical_Administrator> admins = new List<Clinical_Administrator>();
            String selectStatement = @"SELECT id, personID, active
                                        FROM Clinical_Administrator";
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
                            admins.Add(new Clinical_Administrator(reader.GetInt32(ordID),
                                reader.GetInt32(ordPersonID), reader.GetBoolean(ordActive)));
                        }
                    }
                }
            }
            return admins;
        }
    }
}
