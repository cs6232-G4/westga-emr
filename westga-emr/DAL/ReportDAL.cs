using System;
using System.Collections.Generic;
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
        public static List<Report> GetMostPerformedTestsDuringDates(DateTime startDate, DateTime endDate)
        {
            List <Report> reports = new List<Report>();
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
                        while (reader.Read())
                        {
                            int labCode = 0;
                            if (!reader.IsDBNull(ordLabCode))
                            {
                                labCode = reader.GetInt32(ordLabCode);
                            }
                            string LabName = null;
                            if (!reader.IsDBNull(ordLabName))
                            {
                                LabName = reader.GetString(ordLabName);
                            }
                            int NumberOfTests = 0;
                            if (!reader.IsDBNull(ordNumberOfTests))
                            {
                                NumberOfTests = reader.GetInt32(ordNumberOfTests);
                            }
                            int TotalTests = 0;
                            if (!reader.IsDBNull(ordTotalTests))
                            {
                                TotalTests = Convert.ToInt32(reader.GetDouble(ordTotalTests));
                            }
                            decimal PercentageOfTotal = 0;
                            if (!reader.IsDBNull(ordPercentageOfTotal))
                            {
                                PercentageOfTotal = Convert.ToDecimal(reader.GetDouble(ordPercentageOfTotal));
                            }
                            int NumberOfNormalResults = 0;
                            if (!reader.IsDBNull(ordNormalResults))
                            {
                                NumberOfNormalResults = reader.GetInt32(ordNormalResults);
                            }
                            int NumberOfAbnormalResults = 0;
                            if (!reader.IsDBNull(ordAbnormalResults))
                            {
                                NumberOfAbnormalResults = reader.GetInt32(ordAbnormalResults);
                            }
                            decimal PercentageDoneOnTwentyYearOldsDuringThisTime = 0;
                            if (!reader.IsDBNull(ordPercentageTwenty))
                            {
                                PercentageDoneOnTwentyYearOldsDuringThisTime = Convert.ToDecimal(reader.GetDouble(ordPercentageTwenty));
                            }
                            decimal PercentageDoneOnThirtyYearOldsDuringThisTime = 0;
                            if (!reader.IsDBNull(ordPercentageThirty))
                            {
                                PercentageDoneOnThirtyYearOldsDuringThisTime = Convert.ToDecimal(reader.GetDouble(ordPercentageThirty));
                            }
                            decimal PercentageDoneOnOtherAgesOldsDuringThisTime = 0;
                            if (!reader.IsDBNull(ordPercentageOtherAge))
                            {
                                PercentageDoneOnOtherAgesOldsDuringThisTime = Convert.ToDecimal(reader.GetDouble(ordPercentageOtherAge));
                            }
                            var report = new Report(labCode, LabName, NumberOfTests, TotalTests, PercentageOfTotal, NumberOfNormalResults, NumberOfAbnormalResults,
                            PercentageDoneOnTwentyYearOldsDuringThisTime, PercentageDoneOnThirtyYearOldsDuringThisTime, PercentageDoneOnOtherAgesOldsDuringThisTime);
                            reports.Add(report);
                        }
                       
                    }
                }
            }
            return reports;
        }
    }
}
