﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using westga_emr.Model;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages SQL queries to the Appointment Table
    /// </summary>
    public class AppointmentDAL
    {
        /// <summary>
        /// Gets a list of all appointments in the WestGA-EMR db
        /// </summary>
        /// <returns>List of all Appointments</returns>
        public static List<Appointment> GetAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();
            String selectStatement = @"SELECT id, patientID, doctorID, appointmentDateTime, reasonForVisit
                                        FROM Appointment";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("id");
                        int ordPatientID = reader.GetOrdinal("patientID");
                        int ordDoctorID = reader.GetOrdinal("doctorID");
                        int ordApptDateTime = reader.GetOrdinal("appointmentDateTime");
                        int ordReason = reader.GetOrdinal("reasonForVisit");
                        while (reader.Read())
                        {
                            appointments.Add(new Appointment(reader.GetInt32(ordID),
                                reader.GetInt32(ordPatientID), reader.GetInt32(ordDoctorID),
                                reader.GetDateTime(ordApptDateTime), reader.GetString(ordReason)));
                        }
                    }
                }
            }
            return appointments;
        }

        /// <summary>
        /// Gets a list of all of a patient's Appointments; past, present, and future
        /// </summary>
        /// <param name="patient">Patient whose Appointments you desire</param>
        /// <returns>List of all Appointments for said patient</returns>
        public static List<Appointment> GetPatientsAppointments(Patient patient)
        {
            List<Appointment> appointments = new List<Appointment>();
            String selectStatement = @"SELECT id, patientID, doctorID, appointmentDateTime, reasonForVisit
                                        FROM Appointment
                                        WHERE patientID = @patientID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@patientID", patient.ID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("id");
                        int ordPatientID = reader.GetOrdinal("patientID");
                        int ordDoctorID = reader.GetOrdinal("doctorID");
                        int ordApptDateTime = reader.GetOrdinal("appointmentDateTime");
                        int ordReason = reader.GetOrdinal("reasonForVisit");
                        while (reader.Read())
                        {
                            appointments.Add(new Appointment(reader.GetInt32(ordID),
                                reader.GetInt32(ordPatientID), reader.GetInt32(ordDoctorID),
                                reader.GetDateTime(ordApptDateTime), reader.GetString(ordReason)));
                        }
                    }
                }
            }
            return appointments;
        }

        /// <summary>
        /// Creates a new Appointment for a patient.
        /// Does NOT check to avoid double booking. Do not use without first checking.
        /// </summary>
        /// <param name="appointment">The new Appointment to insert into the db</param>
        /// <returns>Whether or not the appointment was created</returns>
        public static bool CreateAppointment(Appointment appointment)
        {
            int retValue;
            String insertStatement = @"INSERT INTO Appointment (patientID, doctorID, appointmentDateTime, reasonForVisit)
	                                    VALUES (@patientID, @doctorID, @appointmentDateTime, @reasonForVisit)";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {

                    command.Parameters.AddWithValue("@patientID", appointment.PatientID);
                    command.Parameters.AddWithValue("@doctorID", appointment.DoctorID);
                    command.Parameters.AddWithValue("@appointmentDateTime", appointment.AppointmentDateTime);
                    command.Parameters.AddWithValue("@reasonForVisit", appointment.ReasonForVisit);

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

        public static bool UpdateAppointment(Appointment appointment)
        {
            int retValue;
            String updateStatement = @"UPDATE Appointment
	                                    SET patientID = @patientID, doctorID = @doctorID, 
		                                    appointmentDateTime = @appointmentDateTime,
		                                    reasonForVisit = @reasonForVisit
	                                    WHERE id = @id";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(updateStatement, connection))
                {

                    command.Parameters.AddWithValue("@patientID", appointment.PatientID);
                    command.Parameters.AddWithValue("@doctorID", appointment.DoctorID);
                    command.Parameters.AddWithValue("@appointmentDateTime", appointment.AppointmentDateTime);
                    command.Parameters.AddWithValue("@reasonForVisit", appointment.ReasonForVisit);

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
    }
}
