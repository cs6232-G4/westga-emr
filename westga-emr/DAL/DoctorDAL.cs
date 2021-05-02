using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;
using westga_emr.Model.DTO;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages queries to the Doctor table of the WestGA-EMR db
    /// </summary>
    public class DoctorDAL
    {
        /// <summary>
        /// Gets a list of all doctors in the WestGA-EMR db
        /// </summary>
        /// <returns>List of all Doctors</returns>
        public static List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            String selectStatement = @"SELECT id, personID, active
                                        FROM Doctor";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("id");
                        int ordPersonID = reader.GetOrdinal("personID");
                        int ordActive = reader.GetOrdinal("active");
                        while (reader.Read())
                        {
                            doctors.Add(new Doctor(reader.GetInt32(ordID),
                                reader.GetInt32(ordPersonID), reader.GetBoolean(ordActive)));
                        }
                    }
                }
            }
            return doctors;
        }

        public List<UserDTO> GetAvailableDoctorsForAppointmentDate(DateTime appointmentDateTime) 
        {
            var availableDoctors = new List<UserDTO>();
            string selectUserStatement = @"SELECT D.id as DoctorID
                                        FROM dbo.Person P
                                        inner join doctor D on  P.id = D.personID
                                        where D.active = 1
                                        EXCEPT 
                                        SELECT doctorID
                                        from dbo.Appointment
                                        where appointmentDateTime = @AppointmentDate";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectUserStatement, connection))
                {
                    if (appointmentDateTime == null)
                    {
                        selectCommand.Parameters.AddWithValue("@AppointmentDate", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@AppointmentDate", appointmentDateTime);
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserDTO doctor = new UserDTO();
                            doctor.DoctorId = (int)reader["DoctorID"];
                            availableDoctors.Add(doctor);
                        }

                    }
                }
            }

            return availableDoctors;
        }

        public List<UserDTO> GetActiveDoctors()
        {
            var doctors = new List<UserDTO>();
            string selectUserStatement = @"
                SELECT CONCAT(P.firstName,' ', P.lastName) AS FullName, D.id as DoctorID
                FROM Person P 
                inner join doctor D on  P.id = D.personID
                WHERE D.active = 1";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectUserStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserDTO doctor = new UserDTO();
                            doctor.FullName = reader["FullName"].ToString();
                            doctor.DoctorId = (int)reader["DoctorID"];
                            doctors.Add(doctor);
                        }

                    }
                }
            }

            return doctors;
        }

        public UserDTO GetDoctorById(int doctorId)
        {
            var doctor = new UserDTO();
            string selectUserStatement = @"
                SELECT CONCAT(P.firstName,' ', P.lastName) AS FullName, D.id as DoctorID
                FROM Person P 
                inner join doctor D on  P.id = D.personID
                WHERE D.active = 1 and D.id = @DoctorID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand selectCommand = new SqlCommand(selectUserStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@DoctorID", doctorId);
                    connection.Open();
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctor.FullName = reader["FullName"].ToString();
                            doctor.DoctorId = (int)reader["DoctorID"];
                        }

                    }
                }
            }

            return doctor;
        }

        /// <summary>
        /// Gets a list of all of a doctor's specialties
        /// </summary>
        /// <param name="doctor">Doctor in question</param>
        /// <returns>The doctor's specialties</returns>
        public static List<Specialty> GetDoctorsSpecialties(Doctor doctor)
        {
            List<Specialty> specialties = new List<Specialty>();
            String selectStatement = @"SELECT specialtyName FROM Doctor_has_Specialties WHERE doctorID = @doctorID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@doctorID", doctor.ID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordSpecialtyName = reader.GetOrdinal("specialtyName");
                        while (reader.Read())
                        {
                            specialties.Add(new Specialty(reader.GetString(ordSpecialtyName)));
                        }
                    }
                }
            }
            return specialties;
        }
    }
}
