using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Lab_Orders_have_Lab_Tests DAL and Model
    /// </summary>
    public class Lab_Orders_have_Lab_TestsController
    {
        /// <see cref="Lab_Orders_have_Lab_TestsDAL.GetLab_Orders_have_Lab_Tests"/>
        public List<Lab_Orders_have_Lab_Tests> GetLab_Orders_have_Lab_Tests()
        {
            return Lab_Orders_have_Lab_TestsDAL.GetLab_Orders_have_Lab_Tests();
        }
    }
}
