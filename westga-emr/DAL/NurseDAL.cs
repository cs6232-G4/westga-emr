using System;
using System.Collections.Generic;
using westga_emr.Model;
using System.Data.SqlClient;
using westga_emr.Model.DTO;

namespace westga_emr.DAL
{
    /// <summary>
    /// Manages Sql queries to the Nurse table
    /// </summary>
    public class NurseDAL
    {
        /// <summary>
        /// Gets a list of all nurses in the WestGA-EMR db
        /// </summary>
        /// <returns>List of all Nurses</returns>
        public static List<Nurse> GetNurses()
        {
            List<Nurse> nurses = new List<Nurse>();
            String selectStatement = @"SELECT id, personID, active
                                        FROM Nurse";
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
                            nurses.Add(new Nurse(reader.GetInt32(ordID),
                                reader.GetInt32(ordPersonID), reader.GetBoolean(ordActive)));
                        }
                    }
                }
            }
            return nurses;
        }
        
        /// <summary>
        /// Gets all nurse
        /// </summary>
        /// <returns></returns>
        public static List<UserDTO> GetAllNurse()
        {
            var nurses = new List<UserDTO>();
            string selectUserStatement = @"
                SELECT P.id as personId, username,firstName, password,
                        lastName, dateOfBirth, ssn, gender,
                        addressID, contactPhone, n.id as nurseId, n.active,
                        street, city, state, zip
                FROM Person P 
                INNER JOIN Nurse n ON P.id = n.personID
	            INNER JOIN Address A ON P.addressID = A.id
                ORDER BY lastName ";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectUserStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserDTO nurse = new UserDTO();
                            nurse.Id = (int)reader["personId"];
                            nurse.Username = reader["username"].ToString();
                            nurse.FirstName = reader["firstName"].ToString();
                            nurse.LastName = reader["lastName"].ToString();
                            nurse.SSN = reader["ssn"].ToString();
                            nurse.Gender = reader["gender"].ToString();
                            nurse.ContactPhone = reader["contactPhone"].ToString();
                            nurse.Street = reader["street"].ToString();
                            nurse.State = reader["state"].ToString();
                            nurse.City = reader["city"].ToString();
                            nurse.Zip = reader["zip"].ToString();
                            nurse.AddressId = reader["addressID"] != DBNull.Value ? (int)reader["addressID"] : 0;
                            nurse.NurseId = reader["nurseId"] != DBNull.Value ? (int)reader["nurseId"] : 0;
                            nurse.DateOfBirth = reader["dateOfBirth"] != DBNull.Value ? (DateTime)reader["dateOfBirth"] : (DateTime?)null;
                            nurse.IsActiveNurse = (bool)reader["active"];
                            nurses.Add(nurse);
                        }

                    }
                }
            }

            return nurses;
        }

    }
}
