using System;
using System.Data;
using System.Data.SqlClient;


namespace KarateClubDataAccessLayer
{
    public class clsInstructorDataAccess
    {
        public static bool GetInstructorByID(int InstructorID, ref int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Instructors WHERE InstructorID = @InstructorID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InstructorID", InstructorID);

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

        public static int GetInstructorIDByName(string InstructorName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT InstructorsDetailedInfo.InstructorID
                            FROM InstructorsDetailedInfo
                            WHERE InstructorsDetailedInfo.Name = @InstructorName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InstructorName", InstructorName);

            object reader = null;

            int InstructorID = -1;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int _InstructorID))
                {
                    InstructorID = _InstructorID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return InstructorID;
        }

        public static string GetInstructorName(int InstructorID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT InstructorsDetailedInfo.Name
                            FROM InstructorsDetailedInfo
                            WHERE InstructorsDetailedInfo.InstructorID = @InstructorID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InstructorID", InstructorID);

            object reader = null;

            string InstructorName = "";

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null)
                {
                    InstructorName = reader.ToString();
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return InstructorName;
        }

        public static bool IsInstructorExist(int InstructorID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 FROM Instructors WHERE InstructorID = @InstructorID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InstructorID", InstructorID);

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

        public static int AddNewInstructor(int PersonID)
        {
            int InstructorID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Instructors(PersonID) 
                             VALUES (@PersonID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int insertedID))
                {
                    InstructorID = insertedID;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return InstructorID;
        }

        public static bool UpdateInstructor(int InstructorID, int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Instructors
                             SET PersonID = @PersonID 
                             WHERE InstructorID = @InstructorID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InstructorID", InstructorID);
            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool DeleteInstructor(int InstructorID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM Instructors WHERE InstructorID = @InstructorID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InstructorID", InstructorID);

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

        public static int GetInstructorsCount()
        {
            int InstructorsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) FROM Instructors";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int Count))
                {
                    InstructorsCount = Count;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return InstructorsCount;
        }

        public static DataTable GetAllInstructors()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Instructors.InstructorID, Persons.Name , Persons.Password , 
                            Persons.Gender, Persons.DateOfBirth , Persons.Address , Persons.Email ,
                            Persons.Phone, Persons.ImagePath
                            FROM Instructors
                            INNER JOIN Persons
                            ON Instructors.PersonID = Persons.PersonID;";

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

        public static DataTable GetInstructors(int MemberID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM InstructorsDetailedInfo
                             WHERE InstructorID NOT IN
                             (SELECT InstructorID FROM MemberInstructors WHERE MemberID = @MemberID);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);

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
