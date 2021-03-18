using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages SQL queries to the Lab_Test table
    /// </summary>
    public class Lab_TestDAL
    {
        /// <summary>
        /// Gets a list of all Lab Tests in the db
        /// </summary>
        /// <returns>List of all Lab_Tests in db</returns>
        public static List<Lab_Test> GetLab_Tests()
        {
            List<Lab_Test> tests = new List<Lab_Test>();
            String selectStatement = @"SELECT code, name
                                        FROM Lab_Test";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordCode = reader.GetOrdinal("code");
                        int ordName = reader.GetOrdinal("name");
                        while (reader.Read())
                        {
                            tests.Add(new Lab_Test(reader.GetInt32(ordCode), reader.GetString(ordName)));
                        }
                    }
                }
            }
            return tests;
        }
    }
}
