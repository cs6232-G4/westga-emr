using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;
using westga_emr.Model.DTO;
using System.Data;

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
        /// Create a Visits to the data source.
        /// </summary>
        /// <param name="visit"></param>
        public static bool CreateVisit(Visit visit)
        {
            int retValue;
            String insertStatement = @" INSERT INTO VISIT 
                     (appointmentID , nurseID , visitDateTime , initialDiagnosis ,weight , systolicPressure , diastolicPressure ,
	                    bodyTemperature , pulse , symptoms , finalDiagnosis)
                    VALUES
                    ( @appointmentID , @nurseID , @visitDateTime , @initialDiagnosis , @weight , @systolicPressure, @diastolicPressure,
	                    @bodyTemperature , @pulse , @symptoms , @finalDiagnosis)";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {
                    command.Parameters.AddWithValue("@appointmentID", visit.AppointmentID);
                    command.Parameters.AddWithValue("@nurseID", visit.NurseID);
                    command.Parameters.AddWithValue("@visitDateTime", visit.VisitDateTime);
                    command.Parameters.AddWithValue("@initialDiagnosis", visit.InitialDiagnosis);
                    command.Parameters.AddWithValue("@weight", visit.Weight);
                    command.Parameters.AddWithValue("@systolicPressure", visit.SystolicPressure);
                    command.Parameters.AddWithValue("@diastolicPressure", visit.DiastolicPressure);
                    command.Parameters.AddWithValue("@bodyTemperature", visit.BodyTemperature);
                    command.Parameters.AddWithValue("@pulse", visit.Pulse);
                    command.Parameters.AddWithValue("@symptoms", visit.Symptoms);
                    command.Parameters.AddWithValue("@finalDiagnosis", visit.FinalDiagnosis);

                    retValue = command.ExecuteNonQuery();
                }
            }
            if (retValue < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Update a Visits to the data source.
        /// </summary>
        /// <param name="visit"></param>
        public static bool UpdateVisit(Visit visit)
        {
            bool isUpdateSuccesful = false;
            string selectStatement = " Update Visit set initialDiagnosis = @initialDiagnosis , " +
            "weight = @weight,    systolicPressure = @systolicPressure,    diastolicPressure = @diastolicPressure , " +
            "bodyTemperature = @bodyTemperature,  pulse = @pulse , symptoms = @symptoms, finalDiagnosis = @finalDiagnosis  "+
            " where appointmentID = @appointmentID ";

            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@appointmentID", SqlDbType.Int);
                    selectCommand.Parameters["@appointmentID"].Value = visit.AppointmentID;

                    selectCommand.Parameters.Add("@initialDiagnosis", SqlDbType.VarChar);
                    selectCommand.Parameters["@initialDiagnosis"].Value = visit.InitialDiagnosis;

                    selectCommand.Parameters.Add("@weight", SqlDbType.Decimal);
                    selectCommand.Parameters["@weight"].Value = visit.Weight;

                    selectCommand.Parameters.Add("@systolicPressure", SqlDbType.Int);
                    selectCommand.Parameters["@systolicPressure"].Value = visit.SystolicPressure;

                    selectCommand.Parameters.Add("@diastolicPressure", SqlDbType.Int);
                    selectCommand.Parameters["@diastolicPressure"].Value = visit.DiastolicPressure;

                    selectCommand.Parameters.Add("@bodyTemperature", SqlDbType.Decimal);
                    selectCommand.Parameters["@bodyTemperature"].Value = visit.BodyTemperature;

                    selectCommand.Parameters.Add("@pulse", SqlDbType.Int);
                    selectCommand.Parameters["@pulse"].Value = visit.Pulse;

                    selectCommand.Parameters.Add("@symptoms", SqlDbType.VarChar);
                    selectCommand.Parameters["@symptoms"].Value = visit.Symptoms;

                    selectCommand.Parameters.Add("@finalDiagnosis", SqlDbType.VarChar);
                    selectCommand.Parameters["@finalDiagnosis"].Value = visit.FinalDiagnosis;
                    

                    int rowsAffected = selectCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        isUpdateSuccesful = true;
                    }
                }

                return isUpdateSuccesful;
            }

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

        public static List<VisitDTO> GetPatientsVisits(int patientId)
        {
            List<VisitDTO> visits = new List<VisitDTO>();
            string selectStatement = @"SELECT a.reasonForVisit, a.appointmentDateTime, a.id as appointmentID,
                                        CONCAT(p.firstName, ' ', p.lastName) as nurse,
                                        v.bodyTemperature, v.diastolicPressure, v.id as visitID,
                                        v.initialDiagnosis, v.pulse, v.symptoms, 
                                        v.systolicPressure, v.visitDateTime, v.weight, v.finalDiagnosis
                                        FROM Appointment a
                                        inner JOIN Visit v on a.id = v.appointmentID
                                        INNER JOIN NURSE n ON v.nurseID = n.id
                                        INNER JOIN PERSON p ON n.personID = p.ID
                                        where a.patientID = @PatientId";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@PatientId", patientId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VisitDTO visitDTO = new VisitDTO();
                            visitDTO.AppointmentID = (long)reader["appointmentID"];
                            visitDTO.AppointmentDateTime = (DateTime)reader["appointmentDateTime"];
                            visitDTO.BodyTemperature = (decimal)reader["bodyTemperature"];
                            visitDTO.DiastolicPressure = (int)reader["diastolicPressure"];
                            visitDTO.FinalDiagnosis = (String)reader["finalDiagnosis"];
                            visitDTO.ID = (long)reader["visitID"];
                            visitDTO.InitialDiagnosis = reader["initialDiagnosis"].ToString();
                            visitDTO.Nurse = reader["nurse"].ToString();
                            visitDTO.Pulse = (int)reader["pulse"];
                            visitDTO.Symptoms = reader["symptoms"].ToString();
                            visitDTO.SystolicPressure = (int)reader["systolicPressure"];
                            visitDTO.VisitDateTime = (DateTime)reader["visitDateTime"];
                            visitDTO.VisitReason = reader["reasonForVisit"].ToString();
                            visitDTO.Weight = (decimal)reader["weight"];
                            visits.Add(visitDTO);
                        }
                    }
                }
            }
            return visits;
        }
    }
}
