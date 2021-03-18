using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Specialty DAL and Model
    /// </summary>
    public class SpecialtyController
    {
        /// <see cref="SpecialtyDAL.GetSpecialties"/>
        public List<Specialty> GetSpecialties()
        {
            return SpecialtyDAL.GetSpecialties();
        }
    }
}
