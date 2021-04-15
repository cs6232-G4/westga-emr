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
                            string results = null;
                            if (!reader.IsDBNull(ordResults))
                            {
                                results = reader.GetString(ordResults);
                            }
                            relations.Add(new Lab_Orders_have_Lab_Tests(reader.GetInt64(ordID),
                                reader.GetInt32(ordCode), reader.GetDateTime(ordPerformed), results));
                        }
                    }
                }
            }
            return relations;
        }

        /// <summary>
        /// Inserts a new Patient into the db
        /// </summary>
        /// <param name="patient">Patient to insert</param>
        /// <returns>ID of the newly inserted Patient, or null if the insertion failed</returns>
        public static int? InsertLab_Orders_have_Lab_Tests(Lab_Orders_have_Lab_Tests lab_Orders_have_Lab_Tests)
        {
            int? id = null;
            String insertStatement = @"INSERT INTO Lab_Orders_have_Lab_Tests (labOrderID, labTestCode, testPerformed,results)
                                        OUTPUT inserted.labOrderID
			                            VALUES (@labOrderID , @labTestCode, @testPerformed, @results)";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {
                    command.Parameters.AddWithValue("@labOrderID", lab_Orders_have_Lab_Tests.LabOrderID);
                    command.Parameters.AddWithValue("@labTestCode", lab_Orders_have_Lab_Tests.LabTestCode);
                    command.Parameters.AddWithValue("@testPerformed", lab_Orders_have_Lab_Tests.TestPerformed);
                    command.Parameters.AddWithValue("@results", lab_Orders_have_Lab_Tests.Results);

                    id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return id;
        }
    }
}
