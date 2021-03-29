using System;

namespace westga_emr.Model
{
	/// <summary>
	/// Models an Appointment in the WestGA-EMR
	/// </summary>
	public class Appointment
	{
		public long? ID { get; }
		public int PatientID { get; }
		public int DoctorID { get; }
		public DateTime AppointmentDateTime { get; }
		public string ReasonForVisit { get; }

		/// <summary>
		/// Constructs an Appointment according to the given data
		/// </summary>
		/// <param name="id_">Sql Server's id for the Appointment</param>
		/// <param name="patientID_">Sql Server's id for the patient associated with the Appointment</param>
		/// <param name="doctorID_">Sql Server's id for the doctor associated with the Appointment</param>
		/// <param name="appointmentDateTime_">The date and time of the Appointment</param>
		/// <param name="reasonForVisit_">The reason for the Appointment's visit</param>
		public Appointment(long? id_, int patientID_, int doctorID_, DateTime appointmentDateTime_, string reasonForVisit_)
		{
			if (patientID_ < 1 || doctorID_ < 1)
            {
				throw new ArgumentException("id, patientID, and doctorID must be greater than zero");
			}
			if (string.IsNullOrWhiteSpace(reasonForVisit_))
            {
				throw new ArgumentException("reason for visit cannot be null, empty, or consist only of white space");
			}
			if (appointmentDateTime_ == null)
            {
				throw new ArgumentNullException("appointmentDateTime cannot be null");
            }
			this.ID = id_;
			this.PatientID = patientID_;
			this.DoctorID = doctorID_;
			this.AppointmentDateTime = appointmentDateTime_;
			this.ReasonForVisit = reasonForVisit_;
		}
	}
}
