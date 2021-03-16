using System;

namespace westga_emr.Model
{
	/// <summary>
	/// Models the relation between Doctor and Specialties in the WestGA-EMR
	/// </summary>
	public class Doctor_has_Specialties
	{
		public int DoctorID { get; }
		public string SpecialtyName { get; }

		/// <summary>
		/// Constructs an instance of this relation according to the given data
		/// </summary>
		/// <param name="doctorID_"></param>
		/// <param name="specialtyName_"></param>
		public Doctor_has_Specialties(int doctorID_, string specialtyName_)
		{
			if (doctorID_ < 1)
            {
				throw new ArgumentException("doctorID must be greater than zero");
            }
			if (string.IsNullOrWhiteSpace(specialtyName_))
            {
				throw new ArgumentException("specialtyName cannot be null, empty, or consist only of white space");
            }
			this.DoctorID = doctorID_;
			this.SpecialtyName = specialtyName_;
		}
	}
}
