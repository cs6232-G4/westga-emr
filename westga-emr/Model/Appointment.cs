using System;

namespace westga_emr.Model
{
	public class Appointment
	{
		public long ID { get; }
		public int PatientID { get; }
		public int DoctorID { get; }
		public DateTime AppointmentDateTime { get; }
		public string ReasonForVisit { get; }

		public Appointment(long id_, int patientID_, int doctorID_, DateTime appointmentDateTime_, string reasonForVisit_)
		{
			if (id_ < 1 || patientID_ < 1 || doctorID_ < 1)
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
