using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Clinical_Administrator DAL and Model
    /// </summary>
    public class Clinical_AdministratorController
    {
        /// <see cref="Clinical_AdministratorDAL.GetClinicalAdministrators"/>
        public List<Clinical_Administrator> GetClinicalAdministrators()
        {
            return Clinical_AdministratorDAL.GetClinicalAdministrators();
        }
    }
}
