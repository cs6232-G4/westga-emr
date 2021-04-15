using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;
using westga_emr.Model.DTO;

namespace westga_emr.DAL
{
    /// <summary>
    /// Handles Sql queries to the Lab_Order table
    /// </summary>
    public class Lab_OrderDAL
    {
        /// <summary>
        /// Gets a list of all lab orders in the db
        /// </summary>
        /// <returns>List of all Lab_Orders in db</returns>
        public static List<Lab_Order> GetLab_Orders()
        {
            List<Lab_Order> orders = new List<Lab_Order>();
            String selectStatement = @"SELECT id, visitID, dateOrdered
                                        FROM Lab_Order";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("id");
                        int ordVisitID = reader.GetOrdinal("visitID");
                        int ordDateOrdered = reader.GetOrdinal("dateOrdered");
                        while (reader.Read())
                        {
                            orders.Add(new Lab_Order(reader.GetInt32(ordID),
                                reader.GetInt32(ordVisitID), reader.GetDateTime(ordDateOrdered)));
                        }
                    }
                }
            }
            return orders;
        }

        /// <summary>
        /// Gets a list of all lab orders in the db for a visit
        /// </summary>
        /// <returns>List of all Lab_Orders in db</returns>
        public static List<LabOrderDTO> GetLab_Orders_For_Visit(int visitID)
        {
            List<LabOrderDTO> orders = new List<LabOrderDTO>();
            String selectStatement = @"select Visit.id as id , name ,dateOrdered , testPerformed , 
                     results from Visit
                     join Lab_Order  on visit.id = Lab_Order.visitID
                     join Lab_Orders_have_Lab_Tests on Lab_Orders_have_Lab_Tests.labOrderID = Lab_Order.id
                     join Lab_Test on Lab_Test.code = Lab_Orders_have_Lab_Tests.labTestCode
                     where Visit.id = @visitID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("id");
                        int ordName = reader.GetOrdinal("name");
                        int ordDateOrdered = reader.GetOrdinal("dateOrdered");
                        int ordTestPerformed = reader.GetOrdinal("testPerformed");
                        int ordResults = reader.GetOrdinal("results");
                        while (reader.Read())
                        {
                            LabOrderDTO labOrderDTO = new LabOrderDTO();
                            labOrderDTO.ID = reader.GetInt32(ordID);
                            labOrderDTO.Name = reader.GetString(ordName);
                            labOrderDTO.DateOrdered = reader.GetDateTime(ordDateOrdered);
                            labOrderDTO.TestPerformed = reader.GetDateTime(ordTestPerformed);
                            labOrderDTO.Results = reader.GetString(ordResults);
                            orders.Add(labOrderDTO);

                        }
                    }
                }
            }
            return orders;
        }

        /// <summary>
        /// Inserts a new Patient into the db
        /// </summary>
        /// <param name="patient">Patient to insert</param>
        /// <returns>ID of the newly inserted Patient, or null if the insertion failed</returns>
        public static int? InsertLab_Order(Lab_Order labOrder)
        {
            int? id = null;
            String insertStatement = @"INSERT INTO Lab_Order (visitID, dateOrdered)
                                        OUTPUT inserted.id
			                            VALUES (@visitID, @dateOrdered)";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {
                    command.Parameters.AddWithValue("@visitID", labOrder.VisitID);
                    command.Parameters.AddWithValue("@dateOrdered", labOrder.DateOrdered);

                    id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return id;
        }

    }
}
