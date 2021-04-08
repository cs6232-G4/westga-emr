using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using System;

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

        /// <summary>
        /// Orders a new set of labs tests for a Visit
        /// </summary>
        /// <param name="order">The Lab_Order itself</param>
        /// <param name="relation">The relation of Lab_Orders_have_Lab_Tests</param>
        /// <returns>Whether or not the insertions succeeded</returns>
        public bool OrderLab(Lab_Order order, Lab_Test[] tests)
        {
            if (order == null || tests == null)
            {
                throw new ArgumentNullException("order and relation cannot be null");
            }
            foreach (Lab_Test test in tests)
            {
                if (test.Code == null)
                {
                    throw new ArgumentNullException("Lab_Tests must have non-null Codes");
                }
            }

            int? labOrderID = Lab_OrderDAL.InsertLab_Order(order);
            if (labOrderID == null)
            {
                return false;
            }
            foreach (Lab_Test test in tests)
            {
                Lab_Orders_have_Lab_TestsDAL.InsertLab_Orders_have_Lab_Tests(new Lab_Orders_have_Lab_Tests(labOrderID, test.Code, null, null));
            }
            return true;
        }
    }
}
