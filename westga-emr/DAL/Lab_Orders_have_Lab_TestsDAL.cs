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
                                        where l.results is not null and o.visitID = @VisitID";
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
                            labTest.OrderId = (int)reader["labOrderID"];
                            labTest.OrderedDate = (DateTime) reader["dateOrdered"];
                            labTest.TestCode = (int)reader["labTestCode"];
                            labTest.TestName = reader["testName"].ToString();
                            labTest.TestResult = reader["results"].ToString();
                            labTest.TestDate = (DateTime)reader["testPerformed"];
                            labTest.VisitId = (int)reader["visitID"];
                            labTests.Add(labTest);
                        }
                    }
                }
            }
            return labTests;
        }
    }
}
