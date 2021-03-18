using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;

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
    }
}
