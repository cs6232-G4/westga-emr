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
        /// Inserts a new Lab_Order into the db
        /// </summary>
        /// <param name="order">The order to insert</param>
        /// <returns>ID of the newly inserted Lab_order, or null if the insertion failed</returns>
        public static int? InsertLab_Order(Lab_Order order)
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
                    command.Parameters.AddWithValue("@visitID", order.VisitID);
                    command.Parameters.AddWithValue("@dateOrdered", order.DateOrdered);

                    id = (int?)command.ExecuteScalar();
                }
            }
            return id;
        }
    }
}
