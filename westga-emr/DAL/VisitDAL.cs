using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;
using westga_emr.Model.DTO;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages queries to the Visit table
    /// </summary>
    public class VisitDAL
    {
        /// <summary>
        /// Gets a list of all visits in the db
        /// </summary>
        /// <returns>List of all Visits in db</returns>
        public static List<Visit> GetVisits()
        {
            List<Visit> visits = new List<Visit>();
            String selectStatement = @"SELECT id, appointmentID, nurseID, visitDateTime, 
	                                    initialDiagnosis, weight, systolicPressure, diastolicPressure, 
	                                    bodyTemperature, pulse, symptoms, finalDiagnosis
                                    FROM Visit";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("id");
                        int ordApptID = reader.GetOrdinal("appointmentID");
                        int ordNurseID = reader.GetOrdinal("nurseID");
                        int ordVisitDateTime = reader.GetOrdinal("visitDateTime");
                        int ordInitialDiagnosis = reader.GetOrdinal("initialDiagnosis");
                        int ordWeight = reader.GetOrdinal("weight");
                        int ordSystolicPressure = reader.GetOrdinal("systolicPressure");
                        int ordDiastolicPressure = reader.GetOrdinal("diastolicPressure");
                        int ordBodyTemperature = reader.GetOrdinal("bodyTemperature");
                        int ordPulse = reader.GetOrdinal("pulse");
                        int ordSymptoms = reader.GetOrdinal("symptoms");
                        int ordFinalDiagnosis = reader.GetOrdinal("finalDiagnosis");
                        while (reader.Read())
                        {
                            string symptoms = null;
                            if (!reader.IsDBNull(ordSymptoms))
                            {
                                symptoms = reader.GetString(ordSymptoms);
                            }
                            string final = null;
                            if (!reader.IsDBNull(ordFinalDiagnosis))
                            {
                                final = reader.GetString(ordFinalDiagnosis);
                            }
                            visits.Add(new Visit(reader.GetInt32(ordID),
                                reader.GetInt32(ordApptID), reader.GetInt32(ordNurseID),
                                reader.GetDateTime(ordVisitDateTime), reader.GetString(ordInitialDiagnosis),
                                reader.GetDecimal(ordWeight), reader.GetInt32(ordSystolicPressure),
                                reader.GetInt32(ordDiastolicPressure), reader.GetDecimal(ordBodyTemperature),
                                reader.GetInt32(ordPulse), symptoms, final));
                        }
                    }
                }
            }
            return visits;
        }

        /// <summary>
        /// Gets a Visit by its Appointment
        /// </summary>
        /// <returns>The Visit</returns>
        public static List<VisitDTO> GetVisitByAppointment(Appointment appointment)
        {
            List<VisitDTO> visits = new List<VisitDTO>();
            String selectStatement = @"SELECT CAST( Visit.id as INT)  as visitID,   CAST(appointmentID AS INT) appointmentID,  PERSON.firstName +' ' + PERSON.lastName AS nurse , visitDateTime, 
	                                    initialDiagnosis, weight, systolicPressure, diastolicPressure, 
	                                    bodyTemperature, pulse, symptoms, finalDiagnosis
                                    FROM Visit
                                    JOIN NURSE ON VISIT.nurseID = NURSE.id
								    JOIN PERSON ON NURSE.personID = PERSON.ID
                                    WHERE appointmentID = @appointmentID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@appointmentID", appointment.ID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordVisitID = reader.GetOrdinal("visitID");
                        int ordApptID = reader.GetOrdinal("appointmentID");
                        int ordNurse = reader.GetOrdinal("nurse");
                        int ordVisitDateTime = reader.GetOrdinal("visitDateTime");
                        int ordInitialDiagnosis = reader.GetOrdinal("initialDiagnosis");
                        int ordWeight = reader.GetOrdinal("weight");
                        int ordSystolicPressure = reader.GetOrdinal("systolicPressure");
                        int ordDiastolicPressure = reader.GetOrdinal("diastolicPressure");
                        int ordBodyTemperature = reader.GetOrdinal("bodyTemperature");
                        int ordPulse = reader.GetOrdinal("pulse");
                        int ordSymptoms = reader.GetOrdinal("symptoms");
                        int ordFinalDiagnosis = reader.GetOrdinal("finalDiagnosis");
                        while (reader.Read())
                        {
                            string symptoms = null;
                            if (!reader.IsDBNull(ordSymptoms))
                            {
                                symptoms = reader.GetString(ordSymptoms);
                            }
                            string final = null;
                            if (!reader.IsDBNull(ordFinalDiagnosis))
                            {
                                final = reader.GetString(ordFinalDiagnosis);
                            }
                            VisitDTO visitDTO = new VisitDTO
                            {
                                ID = reader.GetInt32(ordVisitID),
                                AppointmentID = reader.GetInt32(ordApptID),
                                Nurse = reader.GetString(ordNurse),
                                VisitDateTime = reader.GetDateTime(ordVisitDateTime),
                                InitialDiagnosis = reader.GetString(ordInitialDiagnosis),
                                Weight = reader.GetDecimal(ordWeight),
                                SystolicPressure = reader.GetInt32(ordSystolicPressure),
                                DiastolicPressure = reader.GetInt32(ordDiastolicPressure),
                                BodyTemperature = reader.GetDecimal(ordBodyTemperature),
                                Pulse = reader.GetInt32(ordPulse),
                                Symptoms = symptoms,
                                FinalDiagnosis = final
                            };

                            visits.Add(visitDTO);
                        }
                    }
                }
            }
            return visits;
        }

        /// <summary>
        /// Gets a list of all the Visits of a particular Patient
        /// </summary>
        /// <param name="patient">Patient whose Visits are desired</param>
        /// <returns>List of Patient's Visits</returns>
        public static List<Visit> GetVisitsByPatient(Patient patient)
        {
            List<Visit> visits = new List<Visit>();
            String selectStatement = @"SELECT Visit.id, appointmentID, nurseID, visitDateTime, 
	                                    initialDiagnosis, weight, systolicPressure, diastolicPressure, 
	                                    bodyTemperature, pulse, symptoms, finalDiagnosis
                                    FROM Visit
	                                    JOIN Appointment ON Visit.appointmentID = Appointment.ID
	                                    JOIN Patient ON Appointment.patientID = Patient.id
                                    WHERE Patient.id = @patientID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@patientID", patient.ID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("id");
                        int ordApptID = reader.GetOrdinal("appointmentID");
                        int ordNurseID = reader.GetOrdinal("nurseID");
                        int ordVisitDateTime = reader.GetOrdinal("visitDateTime");
                        int ordInitialDiagnosis = reader.GetOrdinal("initialDiagnosis");
                        int ordWeight = reader.GetOrdinal("weight");
                        int ordSystolicPressure = reader.GetOrdinal("systolicPressure");
                        int ordDiastolicPressure = reader.GetOrdinal("diastolicPressure");
                        int ordBodyTemperature = reader.GetOrdinal("bodyTemperature");
                        int ordPulse = reader.GetOrdinal("pulse");
                        int ordSymptoms = reader.GetOrdinal("symptoms");
                        int ordFinalDiagnosis = reader.GetOrdinal("finalDiagnosis");
                        while (reader.Read())
                        {
                            string symptoms = null;
                            if (!reader.IsDBNull(ordSymptoms))
                            {
                                symptoms = reader.GetString(ordSymptoms);
                            }
                            string final = null;
                            if (!reader.IsDBNull(ordFinalDiagnosis))
                            {
                                final = reader.GetString(ordFinalDiagnosis);
                            }
                            visits.Add(new Visit(reader.GetInt32(ordID),
                                reader.GetInt32(ordApptID), reader.GetInt32(ordNurseID),
                                reader.GetDateTime(ordVisitDateTime), reader.GetString(ordInitialDiagnosis),
                                reader.GetDecimal(ordWeight), reader.GetInt32(ordSystolicPressure),
                                reader.GetInt32(ordDiastolicPressure), reader.GetDecimal(ordBodyTemperature),
                                reader.GetInt32(ordPulse), symptoms, final));
                        }
                    }
                }
            }
            return visits;
        }
    }
}
