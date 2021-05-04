using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace westga_emr.Model.DTO
{
	public class VisitDTO
	{
		public long? ID { get; set; }
		public long? AppointmentID { get; set; }
		public string Doctor { get; set; }
		public string Nurse { get; set; }
		public DateTime VisitDateTime { get; set; }
		public string InitialDiagnosis { get; set; }
		public decimal Weight { get; set; }
		public int SystolicPressure { get; set; }
		public int DiastolicPressure { get; set; }
		public decimal BodyTemperature { get; set; }
		public int Pulse { get; set; }
		public string Symptoms { get; set; }
		public string FinalDiagnosis { get; set; }
		public DateTime AppointmentDateTime { get; set; }
		public string VisitReason { get; set; }

	}
}
