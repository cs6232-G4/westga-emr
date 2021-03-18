using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Lab_Order DAL and Model
    /// </summary>
    public class Lab_OrderController
    {
        /// <see cref="Lab_OrderDAL.GetLab_Orders"/>
        public List<Lab_Order> GetLab_Orders()
        {
            return Lab_OrderDAL.GetLab_Orders();
        }
    }
}
