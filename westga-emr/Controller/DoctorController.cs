using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Doctor DAL and Model
    /// </summary>
    public class DoctorController
    {
        /// <see cref="DoctorDAL.GetDoctors"/>
        public List<Doctor> GetDoctors()
        {
            return DoctorDAL.GetDoctors();
        }
    }
}
