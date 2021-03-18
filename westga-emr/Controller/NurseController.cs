using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Nurse DAL and Model
    /// </summary>
    public class NurseController
    {
        /// <see cref="NurseDAL.GetNurses"/>
        public List<Nurse> GetNurses()
        {
            return NurseDAL.GetNurses();
        }
    }
}
