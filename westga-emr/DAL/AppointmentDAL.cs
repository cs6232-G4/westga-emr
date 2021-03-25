using System;
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

       
    }
}
