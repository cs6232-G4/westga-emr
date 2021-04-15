using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using westga_emr.Model.DTO;
using System;
using System.Transactions;

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

        public List<LabOrderTestDTO>GetVisitTests(int visitId)
        {
            return Lab_Orders_have_Lab_TestsDAL.GetVisitTests(visitId);
        }


        /// <see cref="Lab_Orders_have_Lab_TestsDAL.UpdateLab_Orders_have_Lab_Tests(Lab_Orders_have_Lab_Tests)"/>
        public bool UpdateLabTestsForVisit(Lab_Orders_have_Lab_Tests[] relations)
        {
            if (relations == null)
            {
                throw new ArgumentNullException("relations cannot be nulled");
            }
            foreach (Lab_Orders_have_Lab_Tests relation in relations)
            {
                if (relation == null)
                {
                    throw new ArgumentNullException("relation inside relations cannot be null");
                }
            }

            using (TransactionScope scope = new TransactionScope())
            {
                foreach (Lab_Orders_have_Lab_Tests relation in relations)
                {
                    Lab_Orders_have_Lab_TestsDAL.UpdateLab_Orders_have_Lab_Tests(relation);
                }
                scope.Complete();
            }

            return true;
        }
    }
}
