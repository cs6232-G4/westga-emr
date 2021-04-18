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
        public static List<UserDTO> GetAllNurse(UserDTO currentUser)
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
                WHERE P.id <> @CurrentUserId
                ORDER BY lastName ";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectUserStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@CurrentUserId", currentUser.Id);

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
                            nurse.Password = reader["password"].ToString();
                            nurses.Add(nurse);
                        }

                    }
                }
            }

            return nurses;
        }

        /// <summary>
        /// Inserts a new Nurse into the db
        /// </summary>
        /// <param name="nurse">Nurse to insert</param>
        /// <returns>ID of the newly inserted Nurse, or null if the insertion failed</returns>
        public static int? InsertNurse(Nurse nurse)
        {
            int? id = null;
            String insertStatement = @"INSERT INTO Nurse (personID, active)
                                        OUTPUT inserted.id
			                            VALUES (@personID, @active)";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {
                    command.Parameters.AddWithValue("@personID", nurse.PersonID);
                    command.Parameters.AddWithValue("@active", nurse.Active);

                    id = (int?)command.ExecuteScalar();
                }
            }
            return id;
        }

        /// <summary>
        /// Updates a Nurse in the db
        /// </summary>
        /// <param name="nurse">Nurse to update</param>
        /// <returns>Whether or not the update succeeded</returns>
        public static bool UpdateNurse(Nurse nurse)
        {
            int rowsUpdated;
            String updateStatement = @"UPDATE Nurse
			                            SET active = @active, personID = @personID
			                            WHERE id = @nurseID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(updateStatement, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@nurseID", nurse.ID);
                    command.Parameters.AddWithValue("@personID", nurse.PersonID);
                    command.Parameters.AddWithValue("@active", nurse.Active);

                    rowsUpdated = command.ExecuteNonQuery();
                }
            }
            if (rowsUpdated < 1)
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
