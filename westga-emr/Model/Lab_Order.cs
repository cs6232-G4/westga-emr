using System;

namespace westga_emr.Model
{
	/// <summary>
	/// Models a Lab Order in the WestGA-EMR database
	/// </summary>
	public class Lab_Order
	{
		public long? ID { get; }
		public long VisitID { get; }
		public DateTime DateOrdered { get; }

		/// <summary>
		/// Constructs an instance of a Lab Order according to the given parameters
		/// </summary>
		/// <param name="id_">Sql Server's id for the Lab Order</param>
		/// <param name="visitID_">Sql Server's id for the visit associated with the Lab Order</param>
		/// <param name="dateOrdered_">The date the lab was ordered</param>
		public Lab_Order(long? id_, long visitID_, DateTime dateOrdered_)
		{
			if (id_ < 1 || visitID_ < 1)
            {
				throw new ArgumentException("id and visitID must be greater than zero");
            }
			if (dateOrdered_ == null)
            {
				throw new ArgumentNullException("dateOrdered cannot be null");
            }
			this.ID = id_;
			this.VisitID = visitID_;
			this.DateOrdered = dateOrdered_;
		}
	}
}
