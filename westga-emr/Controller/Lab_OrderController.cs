using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using westga_emr.Model.DTO;

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

        public List<LabOrderDTO> GetLab_Orders_For_Visit(int visitID)
        {
            return Lab_OrderDAL.GetLab_Orders_For_Visit(visitID);
        }

        public int? InsertLab_Order(Lab_Order labOrder)
        {
            return Lab_OrderDAL.InsertLab_Order(labOrder);
        }
        
    }
}
