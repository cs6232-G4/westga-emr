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
            if (patient == null || patient.ID == null)
            {
                throw new ArgumentNullException("patient and patientID cannot be null");
            }
            return AppointmentDAL.GetPatientsAppointments(patient);
        }

        /// <see cref="AppointmentDAL.CreateAppointment(Appointment)"
        public bool CreateAppointment(Appointment appointment)
        {
            if (appointment == null || appointment.PatientID == null || appointment.DoctorID == null)
            {
                throw new ArgumentNullException("appointment, patientID, and doctorID cannot be null");
            }
            if (appointment.AppointmentDateTime == null)
            {
                throw new ArgumentNullException("please specify a time for the visit");
            }
            if (String.IsNullOrWhiteSpace(appointment.ReasonForVisit))
            {
                throw new ArgumentNullException("please give a reason for the visit");
            }
            return AppointmentDAL.CreateAppointment(appointment);
        }

        /// <see cref="AppointmentDAL.UpdateAppointment(Appointment)"
        public bool UpdateAppointment(Appointment appointment)
        {
            if (appointment == null || appointment.PatientID == null || appointment.DoctorID == null)
            {
                throw new ArgumentNullException("appointment, patientID, and doctorID cannot be null");
            }
            if (appointment.AppointmentDateTime == null)
            {
                throw new ArgumentNullException("please specify a time for the visit");
            }
            if (String.IsNullOrWhiteSpace(appointment.ReasonForVisit))
            {
                throw new ArgumentNullException("please give a reason for the visit");
            }
            return AppointmentDAL.UpdateAppointment(appointment);
        }

        /// <see cref="AppointmentDAL.GetAppointmentInDateRange(DateTime, DateTime)"/>
        public List<AppointmentDTO> GetAppointmentsInDateRange(DateTime startDate, DateTime endDate)
        {
            if (startDate == null || endDate == null)
            {
                throw new ArgumentNullException("startDate and endDate cannot be null");
            }
            return AppointmentDAL.GetAppointmentInDateRange(startDate, endDate.AddDays(1));
        }
    }
}
