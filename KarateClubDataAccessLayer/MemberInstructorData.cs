using System;
using System.Data;
using System.Data.SqlClient;

namespace KarateClubDataAccessLayer
{
    public class clsMemberInstructorDataAccess
    {
        public static bool GetMemberInstructorByID(int MemberInstructorID, ref int MemberID, ref int InstructorID, ref DateTime AssignDate)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM MemberInstructors WHERE MemberInstructorID = @MemberInstructorID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberInstructorID", MemberInstructorID);

            SqlDataReader reader = null;

            bool isFound = false;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    MemberID = (int)reader["MemberID"];
                    InstructorID = (int)reader["InstructorID"];
                    AssignDate = (DateTime)reader["AssignDate"];
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

        public static bool IsMemberInstructorExist(int MemberInstructorID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 FROM MemberInstructors WHERE MemberInstructorID = @MemberInstructorID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberInstructorID", MemberInstructorID);

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

        public static int AddNewMemberInstructor(int MemberID, int InstructorID, DateTime AssignDate)
        {
            int MemberInstructorID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO MemberInstructors(MemberID,InstructorID,AssignDate) 
                             VALUES (@MemberID,@InstructorID,@AssignDate)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@InstructorID", InstructorID);
            command.Parameters.AddWithValue("@AssignDate", AssignDate);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int insertedID))
                {
                    MemberInstructorID = insertedID;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return MemberInstructorID;
        }

        public static bool UpdateMemberInstructor(int MemberInstructorID, int MemberID, int InstructorID, DateTime AssignDate)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE MemberInstructors
                            SET InstructorID = @InstructorID,
                            MemberID = @MemberID,
                            AssignDate = @AssignDate 
                            WHERE MemberInstructorID = @MemberInstructorID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberInstructorID", MemberInstructorID);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@InstructorID", InstructorID);
            command.Parameters.AddWithValue("@AssignDate", AssignDate);

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

        public static bool DeleteMemberInstructor(int MemberInstructorID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM MemberInstructors WHERE MemberInstructorID = @MemberInstructorID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberInstructorID", MemberInstructorID);

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

        public static DataTable GetAllMemberInstructors()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT MemberInstructors.MemberInstructorID, MembersDetailedInfo.Name as MemberName, 
                            InstructorsDetailedInfo.Name as InstructorName , MemberInstructors.AssignDate 
                            FROM MemberInstructors 
                            INNER JOIN
                            MembersDetailedInfo
                            ON MemberInstructors.MemberID = MembersDetailedInfo.MemberID
                            INNER JOIN 
                            InstructorsDetailedInfo 
                            ON MemberInstructors.InstructorID =InstructorsDetailedInfo.InstructorID ;";

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
