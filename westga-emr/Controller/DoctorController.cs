using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using westga_emr.Model.DTO;
using System;
using System.Linq;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Doctor DAL and Model
    /// </summary>
    public class DoctorController
    {
        
        private DoctorDAL doctorDBSource;
        private List<UserDTO> activeDoctors;

        public DoctorController()
        {
            this.doctorDBSource = new DoctorDAL();
            this.activeDoctors = new List<UserDTO>();
        }

       /// <summary>
       /// Gets list of active doctors
       /// </summary>
       /// <returns></returns>
        public List<UserDTO> GetDoctors()
        {
            this.activeDoctors = doctorDBSource.GetActiveDoctors();
            return activeDoctors;
        }

        /// <summary>
        /// Get list of available doctors on a particular date and time
        /// </summary>
        /// <param name="appointmentDate"></param>
        /// <returns></returns>
        public List<UserDTO> GetAvailableDoctorsOnDate(DateTime appointmentDate)
        {

            var availableDoctorsId = doctorDBSource.GetAvailableDoctorsForAppointmentDate(appointmentDate);
            if (activeDoctors.Count <= 0)
            {
                activeDoctors = GetDoctors();
            }
            var doctorHashSet = new HashSet<int>(availableDoctorsId.Select(x => x.DoctorId));

            return activeDoctors.FindAll(x => doctorHashSet.Contains(x.DoctorId));
        }

        /// <summary>
        /// Gets a doctor by id from the database
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        public UserDTO GetDoctorById(int doctorId)
        {
            return doctorDBSource.GetDoctorById(doctorId);
        }
    }
}
