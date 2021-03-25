using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using System;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Appointment DAL and Model
    /// </summary>
    public class AppointmentController
    {
        /// <see cref="AppointmentDAL.GetAppointments"/>
        public List<Appointment> GetAppointments()
        {
            return AppointmentDAL.GetAppointments();
        }

        /// <see cref="AppointmentDAL.GetPatientsAppointments(Patient)"/>
        public List<Appointment> GetPatientsAppointments(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentNullException("patient cannot be null");
            }
            return AppointmentDAL.GetPatientsAppointments(patient);
        }
    }
}
