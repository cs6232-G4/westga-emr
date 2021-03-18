using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Visit DAL and Model
    /// </summary>
    public class VisitController
    {
        /// <see cref="VisitDAL.GetVisits"/>
        public List<Visit> GetVisits()
        {
            return VisitDAL.GetVisits();
        }
    }
}
