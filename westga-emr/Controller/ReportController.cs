using System;
using System.Collections.Generic;
using westga_emr.DAL;
using westga_emr.Model;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Report DAL and Model
    /// </summary>
    public class ReportController
    {
        /// <see cref="ReportDAL.GetMostPerformedTestsDuringDates(DateTime, DateTime)"/>
        public List<Report> GetMostPerformedTestsDuringDates(DateTime startDate, DateTime endDate)
        {
            if (startDate == null || endDate == null)
            {
                throw new ArgumentNullException("startDate and endDate cannot be null");
            }
            if (DateTime.Compare(startDate, endDate) > 0)
            {
                throw new ArgumentException("endDate cannot be less than startDate");
            }
            return ReportDAL.GetMostPerformedTestsDuringDates(startDate, endDate);
        }
    }
}
