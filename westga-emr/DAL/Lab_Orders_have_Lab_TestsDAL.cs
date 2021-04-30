using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;
using westga_emr.Model.DTO;

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
            String selectStatement = @"SELECT labOrderID, labTestCode, testPerformed, results, isNormal
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
                        int ordIsNormal = reader.GetOrdinal("isNormal");
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
                            bool ? isNormal = null;
                            if (!reader.IsDBNull(ordResults))
                            {
                                isNormal = reader.GetBoolean(ordResults);
                            }
                            relations.Add(new Lab_Orders_have_Lab_Tests(reader.GetInt64(ordID),
                                reader.GetInt32(ordCode), testPerformed, results, isNormal));
                        }
                    }
                }
            }
            return relations;
        }

        /// 
        /// </summary>
        /// <param name="visitId"></param>
        /// <returns></returns>
        public static List<LabOrderTestDTO> GetVisitTests(int visitId)
        {
            List<LabOrderTestDTO> labTests = new List<LabOrderTestDTO>();
            string selectStatement = @"select l.labOrderID, l.labTestCode, l.testPerformed, l.results,
		                                o.visitID, o.dateOrdered,
		                                t.name as testName
                                        from Lab_Orders_have_Lab_Tests l
                                        inner join Lab_Order o on l.labOrderID = o.id
                                        inner join Lab_Test t on l.labTestCode = t.code
                                        where o.visitID = @VisitID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@VisitID", visitId);
                   
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LabOrderTestDTO labTest = new LabOrderTestDTO();
                            labTest.OrderId = Convert.ToInt32(reader["labOrderID"].ToString());
                            labTest.OrderedDate = (DateTime) reader["dateOrdered"];
                            labTest.TestCode = (int)reader["labTestCode"];
                            labTest.TestName = reader["testName"].ToString();
                            labTest.TestResult = reader["results"].ToString();

                            if (!reader.IsDBNull(reader.GetOrdinal("testPerformed")))
                            {
                                labTest.TestDate = (DateTime)reader["testPerformed"];
                            }
                            
                            labTest.VisitId = Convert.ToInt32(reader["visitID"].ToString());
                            labTests.Add(labTest);
                        }
                    }
                }
            }
            return labTests;

        }

        /// <summary>
        /// Insert a new Lab_Orders_have_Lab_Tests relation into the db
        /// </summary>
        /// <param name="relation">The Lab_Orders_have_Lab_Tests to insert</param>
        /// <returns>Whether or not the insert succeeded</returns>
        public static bool InsertLab_Orders_have_Lab_Tests(Lab_Orders_have_Lab_Tests relation)
        {
            Object obj = null;
            String insertStatement = @"INSERT INTO Lab_Orders_have_Lab_Tests (labOrderID, labTestCode, testPerformed, results)
			                            VALUES (@labOrderID, @labTestCode, @testPerformed, @results)";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {
                    if (relation.LabOrderID == null)
                    {
                        command.Parameters.AddWithValue("@labOrderID", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@labOrderID", relation.LabOrderID);
                    }

                    if (relation.LabTestCode == null)
                    {
                        command.Parameters.AddWithValue("@labTestCode", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@labTestCode", relation.LabTestCode);
                    }

                    
                    if (relation.TestPerformed == null)
                    {
                        command.Parameters.AddWithValue("@testPerformed", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@testPerformed", relation.TestPerformed);
                    }

                    if (relation.Results == null)
                    {
                        command.Parameters.AddWithValue("@results", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@results", relation.Results);
                    }

                    obj = command.ExecuteScalar();
                }
            }
            if (obj == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Updates the given relation of Lab_Orders_have_Lab_Tests
        /// </summary>
        /// <param name="relation">The Lab_Orders_have_Lab_Tests to update</param>
        /// <returns>Whether or not the update succeeded</returns>
        public static bool UpdateLab_Orders_have_Lab_Tests(Lab_Orders_have_Lab_Tests relation)
        {
            int rowsUpdated;
            String updateStatement = @"UPDATE Lab_Orders_have_Lab_Tests
			                            SET testPerformed = @testPerformed, results = @results
			                            WHERE labOrderID = @labOrderID AND labTestCode = @labTestCode";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(updateStatement, connection))
                {
                    connection.Open();
                    if (relation.LabOrderID == null)
                    {
                        command.Parameters.AddWithValue("@labOrderID", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@labOrderID", relation.LabOrderID);
                    }

                    if (relation.LabTestCode == null)
                    {
                        command.Parameters.AddWithValue("@labTestCode", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@labTestCode", relation.LabTestCode);
                    }

                    command.Parameters.AddWithValue("@testPerformed", relation.TestPerformed);
                    command.Parameters.AddWithValue("@results", relation.Results);

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
    }
}
