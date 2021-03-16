using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

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
        public static List<Lab_Order> GetLab_Order()
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
    }
}
