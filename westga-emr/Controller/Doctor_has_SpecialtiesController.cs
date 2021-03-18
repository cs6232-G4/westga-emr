using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;


namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Doctor_has_Specialties DAL and Model
    /// </summary>
    public class Doctor_has_SpecialtiesController
    {
        /// <see cref="Doctor_has_SpecialtiesDAL.GetDoctor_has_Specialties"/>
        public List<Doctor_has_Specialties> GetDoctor_has_Specialties()
        {
            return Doctor_has_SpecialtiesDAL.GetDoctor_has_Specialties();
        }
    }
}
