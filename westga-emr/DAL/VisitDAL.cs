﻿using System;
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
    }
}