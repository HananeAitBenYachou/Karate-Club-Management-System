using System;
using System.Data;
using System.Data.SqlClient;

namespace KarateClubDataAccessLayer
{
    public class clsMemberDataAccess
    {
        public static bool GetMemberByID(int MemberID, ref int PersonID, ref string EmergencyContact, ref int LastBeltRankID, ref bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Members WHERE MemberID = @MemberID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);

            SqlDataReader reader = null;

            bool isFound = false;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    EmergencyContact = (string)reader["EmergencyContact"];
                    LastBeltRankID = (int)reader["LastBeltRankID"];
                    IsActive = (bool)reader["IsActive"];
                }

                else
                    isFound = false;
            }

            catch (Exception ex)
            {
                isFound = false;
            }

            finally
            {
                reader.Close();
                connection.Close();
            }

            return isFound;
        }

        public static bool GetMemberByEmailAndPassword(string Email, string Password, ref int MemberID, ref int PersonID, ref string EmergencyContact, ref int LastBeltRankID, ref bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT* FROM MembersDetailedInfo
                             WHERE Email = @Email AND Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);

            SqlDataReader reader = null;

            bool isFound = false;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    MemberID = (int)reader["MemberID"];
                    EmergencyContact = (string)reader["EmergencyContact"];
                    LastBeltRankID = (int)reader["LastBeltRankID"];
                    IsActive = (bool)reader["IsActive"];
                }

                else
                    isFound = false;
            }

            catch (Exception ex)
            {
                isFound = false;
            }

            finally
            {
                reader.Close();
                connection.Close();
            }

            return isFound;
        }

        public static string GetMemberName(int MemberID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT MembersDetailedInfo.Name
                            FROM MembersDetailedInfo
                            WHERE MembersDetailedInfo.MemberID = @MemberID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);

            object reader = null;

            string MemberName = "";

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null)
                {
                    MemberName = reader.ToString();
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return MemberName;
        }

        public static int GetMemberIDByName(string MemberName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT MembersDetailedInfo.MemberID
                            FROM MembersDetailedInfo
                            WHERE MembersDetailedInfo.Name = @MemberName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberName", MemberName);

            object reader = null;

            int MemberID = -1;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int _MemberID))
                {
                    MemberID = _MemberID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return MemberID;
        }

        public static bool IsMemberExist(int MemberID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 FROM Members WHERE MemberID = @MemberID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);

            object reader = null;

            bool isFound = false;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null)
                    isFound = true;
                else
                    isFound = false;
            }

            catch (Exception ex)
            {
                isFound = false;
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool UpdateMemberBeltRank(int MemberID, int NewBeltRankID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Members
                            SET LastBeltRankID = @NewBeltRankID                           
                            WHERE MemberID = @MemberID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@NewBeltRankID", NewBeltRankID);
            int rowsAffected = 0;

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected != 0);
        }

        public static int AddNewMember(int PersonID, string EmergencyContact, int LastBeltRankID, bool IsActive)
        {
            int MemberID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Members(PersonID,EmergencyContact,LastBeltRankID,IsActive) 
                             VALUES (@PersonID,@EmergencyContact,@LastBeltRankID,@IsActive) 
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@EmergencyContact", EmergencyContact);
            command.Parameters.AddWithValue("@LastBeltRankID", LastBeltRankID);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int insertedID))
                {
                    MemberID = insertedID;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return MemberID;
        }

        public static bool UpdateMember(int MemberID, int PersonID, string EmergencyContact, int LastBeltRankID, bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Members
                            SET PersonID = @PersonID,
                            EmergencyContact = @EmergencyContact,
                            LastBeltRankID = @LastBeltRankID,
                            IsActive = @IsActive
                            WHERE MemberID = @MemberID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@EmergencyContact", EmergencyContact);
            command.Parameters.AddWithValue("@LastBeltRankID", LastBeltRankID);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            int rowsAffected = 0;

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected != 0);
        }

        public static bool DeleteMember(int MemberID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM Members WHERE MemberID = @MemberID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);

            int rowsAffected = 0;

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected != 0);
        }

        public static int GetMembersCount()
        {
            int MembersCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) FROM Members";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int Count))
                {
                    MembersCount = Count;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return MembersCount;
        }

        public static DataTable GetAllMembers()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Members.MemberID, Persons.Name , Persons.Password ,  BeltRanks.RankName as LastBeltRank, 
                            Persons.Gender, Persons.DateOfBirth , Persons.Address , Persons.Email ,
                            Persons.Phone, Members.EmergencyContact, Members.IsActive, Persons.ImagePath
                            FROM Members
                            INNER JOIN Persons
                            ON Members.PersonID = Persons.PersonID
                            INNER JOIN BeltRanks
                            ON BeltRanks.RankID = Members.LastBeltRankID;";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = null;

            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
    }
}
