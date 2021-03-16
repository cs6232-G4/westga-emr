using System;

namespace westga_emr.Model
{
	/// <summary>
	/// Models the relation Lab_Orders_have_Lab_Tests from the WestGA-EMR database
	/// </summary>
	public class Lab_Orders_have_Lab_Tests
	{
		public long LabOrderID { get; }
		public int LabTestCode { get; }
		public DateTime TestPerformed { get; }
		public string Results { get; }

		/// <summary>
		/// Constructs an instance of this relation according to the given parameters
		/// </summary>
		/// <param name="labOrderID_">Sql Server's id of the lab order in this relation</param>
		/// <param name="labTestCode_">The code of the lab test in this relation</param>
		/// <param name="testPerformed_">The date the test was performed</param>
		/// <param name="results_">The results of the lab tests</param>
		public Lab_Orders_have_Lab_Tests(long labOrderID_, int labTestCode_, DateTime testPerformed_, string results_)
		{
			if (labOrderID_ < 1 || labTestCode_ < 1)
            {
				throw new ArgumentException("labOrderID and labTestCode must be greater than zero");
            }
			if (testPerformed_ == null)
            {
				throw new ArgumentNullException("testPerformed cannot be null");
            }
			if (string.IsNullOrWhiteSpace(results_))
            {
				throw new ArgumentException("results cannot be null, empty, or consist only of white space");
            }
			this.LabOrderID = labOrderID_;
			this.LabTestCode = labTestCode_;
			this.TestPerformed = testPerformed_;
			this.Results = results_;
		}
	}
}
