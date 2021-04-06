using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using System;
using westga_emr.Model.DTO;

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
        public List<VisitDTO> GetVisitByAppointment(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException("appointment cannot be null");
            }
            return VisitDAL.GetVisitByAppointment(appointment);
        }

        /// <see cref="VisitDAL.GetVisitsByPatient(Patient)"/>
        public List<Visit> GetVisitsByPatient(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentNullException("patient cannot be null");
            }
            return VisitDAL.GetVisitsByPatient(patient);
        }

        /// <see cref="VisitDAL.UpdateVisit(Visit)"/>
        public bool UpdateVisit(Visit visit)
        {
            if (visit == null)
            {
                throw new ArgumentNullException("visit cannot be null");
            }
            return VisitDAL.UpdateVisit(visit);
        }

        /// <see cref="VisitDAL.CreateVisit(Visit)"/>
        public bool CreateVisit(Visit visit)
        {
            if (visit == null)
            {
                throw new ArgumentNullException("visit cannot be null");
            }
            return VisitDAL.CreateVisit(visit);
        }
    }
}
