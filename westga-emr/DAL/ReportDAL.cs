using System;
using System.Data.SqlClient;
using westga_emr.Model;

namespace westga_emr.DAL
{
    /// <summary>
    /// Handles queries for SQL reports
    /// </summary>
    public class ReportDAL
    {
        /// <summary>
        /// Returns the report 'getMostPerformedTestsDuringDates' as a Report
        /// </summary>
        /// <param name="startDate">Starting date for report</param>
        /// <param name="endDate">Ending date for report</param>
        /// <returns>Report of 'getMostPerformedTestsDuringDates'</returns>
        public static Report GetMostPerformedTestsDuringDates(DateTime startDate, DateTime endDate)
        {
            Report report = null;
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("getMostPerformedTestsDuringDates", connection))
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@startDate", startDate.Date);
                    command.Parameters.AddWithValue("@endDate", endDate.Date);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordLabCode = reader.GetOrdinal("labCode");
                        int ordLabName = reader.GetOrdinal("labName");

                        int ordNumberOfTests = reader.GetOrdinal("numberOfTests");
                        int ordTotalTests = reader.GetOrdinal("totalTests");
                        int ordPercentageOfTotal = reader.GetOrdinal("percentageOfTotal");

                        int ordNormalResults = reader.GetOrdinal("numberOfNormalResults");
                        int ordAbnormalResults = reader.GetOrdinal("numberOfAbnormalResults");

                        int ordPercentageTwenty = reader.GetOrdinal("percentageDoneOnTwentyYearOldsDuringThisTime");
                        int ordPercentageThirty = reader.GetOrdinal("percentageDoneOnThirtyYearOldsDuringThisTime");
                        int ordPercentageOtherAge = reader.GetOrdinal("percentageDoneOnOtherAgesDuringThisTime");

                        report = new Report(reader.GetInt32(ordLabCode), reader.GetString(ordLabName),
                            reader.GetInt32(ordNumberOfTests), reader.GetInt32(ordTotalTests),
                            reader.GetDecimal(ordPercentageOfTotal),
                            reader.GetInt32(ordNormalResults), reader.GetInt32(ordAbnormalResults),
                            reader.GetDecimal(ordPercentageTwenty), reader.GetDecimal(ordPercentageThirty),
                            reader.GetDecimal(ordPercentageOtherAge));
                    }
                }
            }
            return report;
        }
    }
}
