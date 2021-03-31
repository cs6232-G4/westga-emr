using System;

namespace westga_emr.Model
{
	/// <summary>
	/// Models a Clinical Administrator in the WestGA-EMR
	/// </summary>
	public class Clinical_Administrator
	{
		public int? ID { get; }
		public int? PersonID { get; }
		public bool Active { get; }

		/// <summary>
		/// Constructs a Clinical_Administrator according to the given data
		/// </summary>
		/// <param name="id_">Sql Server's id for the Clinical Admin</param>
		/// <param name="personID_">Sql Server's id for the person who is the Clinical Admin</param>
		/// <param name="active_">Whether or not the Clinical Admin is active or inactive</param>
		public Clinical_Administrator(int? id_, int? personID_, bool active_)
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
