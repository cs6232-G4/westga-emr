﻿using System;

namespace westga_emr.Model
{
	/// <summary>
	/// Models the relation Lab_Orders_have_Lab_Tests from the WestGA-EMR database
	/// </summary>
	public class Lab_Orders_have_Lab_Tests
	{
		public long? LabOrderID { get; }
		public int? LabTestCode { get; }
		public DateTime? TestPerformed { get; }
		public string Results { get; }
		public bool? IsNormal { get; }

		/// <summary>
		/// Constructs an instance of this relation according to the given parameters
		/// </summary>
		/// <param name="labOrderID_">Sql Server's id of the lab order in this relation</param>
		/// <param name="labTestCode_">The code of the lab test in this relation</param>
		/// <param name="testPerformed_">The date the test was performed</param>
		/// <param name="results_">The results of the lab tests</param>
		/// <param name="isNormal_">Whether or not the results are normal</param>
		public Lab_Orders_have_Lab_Tests(long? labOrderID_, int? labTestCode_, DateTime? testPerformed_, string results_, bool? isNormal_)
		{
			if (labOrderID_ < 1 || labTestCode_ < 1)
            {
				throw new ArgumentException("labOrderID and labTestCode must be greater than zero");
            }
			this.LabOrderID = labOrderID_;
			this.LabTestCode = labTestCode_;
			this.TestPerformed = testPerformed_;
			this.Results = results_;
			this.IsNormal = isNormal_;
		}
	}
}
