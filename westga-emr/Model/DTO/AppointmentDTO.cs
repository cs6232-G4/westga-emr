using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace westga_emr.Model.DTO
{
    /// <summary>
    /// DTO class for UI Data
    /// </summary>
    public class AppointmentDTO
    {
        public int? PatientID { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string ReasonForVisit { get; set; }

    }
}
