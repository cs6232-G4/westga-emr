using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using System;
using westga_emr.Model.DTO;

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
        public List<AppointmentDTO> GetPatientsAppointments(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentNullException("patient cannot be null");
            }
            return AppointmentDAL.GetPatientsAppointments(patient);
        }

        /// <see cref="AppointmentDAL.CreateAppointment(Appointment)"
        public bool CreateAppointment(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException("appointment cannot be null");
            }
            return AppointmentDAL.CreateAppointment(appointment);
        }

        /// <see cref="AppointmentDAL.UpdateAppointment(Appointment)"
        public bool UpdateAppointment(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException("appointment cannot be null");
            }
            return AppointmentDAL.UpdateAppointment(appointment);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public List<AppointmentDTO> GetAppointmentsInDateRange(DateTime start, DateTime end)
        {
            return AppointmentDAL.GetAppointmentInDateRange(start, end);
        }
    }
}
