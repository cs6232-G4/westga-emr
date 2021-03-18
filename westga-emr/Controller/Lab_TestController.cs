using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Lab_Test DAL and Model
    /// </summary>
    public class Lab_TestController
    {
        /// <see cref="Lab_TestDAL.GetLab_Tests"/>
        public List<Lab_Test> GetLab_Tests()
        {
            return Lab_TestDAL.GetLab_Tests();
        }
    }
}
