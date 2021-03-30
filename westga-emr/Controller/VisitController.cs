using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using System;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Visit DAL and Model
    /// </summary>
    public class VisitController
    {
        /// <see cref="VisitDAL.GetVisits"/>
        public List<Visit> GetVisits()
        {
            return VisitDAL.GetVisits();
        }

        /// <see cref="VisitDAL.GetVisitByAppointment(Appointment)"/>
        public Visit GetVisitByAppointment(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException("appointment cannot be null");
            }
            return VisitDAL.GetVisitByAppointment(appointment);
        }
    }
}
