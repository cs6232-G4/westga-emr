using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages queries to the Lab_Orders_have_Lab_Tests table
    /// </summary>
    public class Lab_Orders_have_Lab_TestsDAL
    {
        /// <summary>
        /// Gets a list of all Lab_Orders_have_Lab_Tests relations in the db
        /// </summary>
        /// <returns>List of all said relations in db</returns>
        public static List<Lab_Orders_have_Lab_Tests> GetLab_Orders_have_Lab_Tests()
        {
            List<Lab_Orders_have_Lab_Tests> relations = new List<Lab_Orders_have_Lab_Tests>();
            String selectStatement = @"SELECT labOrderID, labTestCode, testPerformed, results
                                        FROM Lab_Orders_have_Lab_Tests";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("labOrderID");
                        int ordCode = reader.GetOrdinal("labTestCode");
                        int ordPerformed = reader.GetOrdinal("testPerformed");
                        int ordResults = reader.GetOrdinal("results");
                        while (reader.Read())
                        {
                            DateTime? testPerformed = null;
                            if (!reader.IsDBNull(ordPerformed))
                            {
                                testPerformed = reader.GetDateTime(ordPerformed);
                            }
                            string results = null;
                            if (!reader.IsDBNull(ordResults))
                            {
                                results = reader.GetString(ordResults);
                            }
                            relations.Add(new Lab_Orders_have_Lab_Tests(reader.GetInt64(ordID),
                                reader.GetInt32(ordCode), testPerformed, results));
                        }
                    }
                }
            }
            return relations;
        }

        /// <summary>
        /// Insert a new Lab_Orders_have_Lab_Tests relation into the db
        /// </summary>
        /// <param name="relation">The Lab_Orders_have_Lab_Tests to insert</param>
        /// <returns>ID of the newly inserted Lab_Orders_have_Lab_Tests, or null if the insertion failed</returns>
        public static int? InsertLab_Orders_have_Lab_Tests(Lab_Orders_have_Lab_Tests relation)
        {
            int? id = null;
            String insertStatement = @"INSERT INTO Lab_Order (labOrderID, labTestCode, testPerformed, results)
                                        OUTPUT inserted.id
			                            VALUES (@labOrderID, @labTestCode, @testPerformed, @results)";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {
                    command.Parameters.AddWithValue("@labOrderID", relation.LabOrderID);
                    command.Parameters.AddWithValue("@labTestCode", relation.LabTestCode);
                    command.Parameters.AddWithValue("@testPerformed", relation.TestPerformed);
                    command.Parameters.AddWithValue("@results", relation.Results);

                    id = (int?)command.ExecuteScalar();
                }
            }
            return id;
        }
    }
}
