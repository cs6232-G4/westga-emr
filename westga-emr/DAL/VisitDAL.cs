using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;

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
        public static Visit GetVisitByAppointment(Appointment appointment)
        {
            Visit visit = null;
            String selectStatement = @"SELECT id, appointmentID, nurseID, visitDateTime, 
	                                    initialDiagnosis, weight, systolicPressure, diastolicPressure, 
	                                    bodyTemperature, pulse, symptoms, finalDiagnosis
                                    FROM Visit
                                    WHERE appointmentID = @appointmentID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@appointmentID", appointment.ID);
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
                            new Visit(reader.GetInt32(ordID),
                                reader.GetInt32(ordApptID), reader.GetInt32(ordNurseID),
                                reader.GetDateTime(ordVisitDateTime), reader.GetString(ordInitialDiagnosis),
                                reader.GetDecimal(ordWeight), reader.GetInt32(ordSystolicPressure),
                                reader.GetInt32(ordDiastolicPressure), reader.GetDecimal(ordBodyTemperature),
                                reader.GetInt32(ordPulse), symptoms, final);
                        }
                    }
                }
            }
            return visit;
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
