using System;

namespace westga_emr.Model
{
	/// <summary>
	/// Models a Patient in the WestGA-EMR database
	/// </summary>
	public class Patient
	{
		public int? ID { get; }
		public int? PersonID { get; }
		public bool Active { get; }

		/// <summary>
		/// Constructs a Patient according to the given data
		/// </summary>
		/// <param name="id_">Sql Server's id for the Patient</param>
		/// <param name="personID_">Sql Server's id for the person of the Patient</param>
		/// <param name="active_">Whether or not the Patient is active or inactive</param>
		public Patient(int? id_, int? personID_, bool active_)
		{
			if (id_ < 1 || personID_ < 1)
            {
				throw new ArgumentException("id and personID must be greater than zero");
            }
			this.ID = id_;
			this.PersonID = personID_;
			this.Active = active_;
		}
	}
}
