using System;

namespace westga_emr.Model
{
	/// <summary>
	/// Models a Visit in the WestGA-EMR database
	/// </summary>
	public class Visit
	{
		public long ID { get; }
		public long AppointmentID { get; }
		public int NurseID { get; }
		public DateTime VisitDateTime { get; }
		public string InitialDiagnosis { get; }
		public decimal Weight { get; }
		public int SystolicPressure { get; }
		public int DiastolicPressure { get; }
		public decimal BodyTemperature { get; }
		public int Pulse { get; }
		public string Symptoms { get; }
		public string FinalDiagnosis { get; }

		/// <summary>
		/// Creates a Visit according to the given data
		/// </summary>
		/// <param name="id_">Sql Server's id for the Visit</param>
		/// <param name="appointmentID_">Sql Server's id for the appointment associated with the Visit</param>
		/// <param name="nurseID_">Sql Server's id for the Nurse associated with the Visit</param>
		/// <param name="visitDateTime_">The date and time of the Visit</param>
		/// <param name="initialDiagnosis_">The initial diagnosis made on the Visit</param>
		/// <param name="weight_">Patient's weight measured during the Visit</param>
		/// <param name="systolicPressure_">Patient's systolic blood pressure measured during the Visit</param>
		/// <param name="diastolicPressure_">Patient's diastolic blood pressure measured during the Visit</param>
		/// <param name="bodyTemperature_">Patient's body temperature measured during the visit</param>
		/// <param name="pulse_">Patient's heart pulse measured during the Visit</param>
		/// <param name="symptoms_">Symptoms the patient exhibits during the Visit</param>
		/// <param name="finalDiagnosis_">The final diagnosis made during the Visit</param>
		public Visit(long id_, long appointmentID_, int nurseID_, DateTime visitDateTime_, string initialDiagnosis_, decimal weight_, int systolicPressure_, int diastolicPressure_, decimal bodyTemperature_, int pulse_, string symptoms_, string finalDiagnosis_)
		{
			if (id_ < 1 || appointmentID_ < 1 || nurseID_ < 1)
			{
				throw new ArgumentException("id, appointmentID, and nurseID must be greater than zero");
			}
			if (visitDateTime_ == null)
			{
				throw new ArgumentNullException("visitDateTime cannot be null");
			}
			if (string.IsNullOrWhiteSpace(initialDiagnosis_))
			{
				throw new ArgumentException("initial diagnosis cannot be null, empty, or consist only of white space");
			}
			if (systolicPressure_ < 1 || diastolicPressure_ < 1 || pulse_ < 1 || weight_ < 1 || bodyTemperature_ < 1)
			{
				throw new ArgumentException("pulse, systolic pressure, diastolic pressure, weight, and body temperature " +
					"must be greater than zero");
			}
			if (Decimal.Round(weight_, 2) != weight_ || weight_ >= 1000)
            {
				throw new ArgumentException("weight must have 3 digits before the decimal and 2 digits afterwards");
            }
			if (Decimal.Round(bodyTemperature_, 1) != bodyTemperature_ || bodyTemperature_ >= 1000)
            {
				throw new ArgumentException("body temperature must have 3 digits before the decimal and 2 digits afterwards");
            }
			this.ID = id_;
			this.AppointmentID = appointmentID_;
			this.NurseID = nurseID_;
			this.VisitDateTime = visitDateTime_;
			this.InitialDiagnosis = initialDiagnosis_;
			this.Weight = weight_;
			this.SystolicPressure = systolicPressure_;
			this.DiastolicPressure = diastolicPressure_;
			this.BodyTemperature = bodyTemperature_;
			this.Pulse = pulse_;
			this.Symptoms = symptoms_;
			this.FinalDiagnosis = finalDiagnosis_;
		}
	}
}
