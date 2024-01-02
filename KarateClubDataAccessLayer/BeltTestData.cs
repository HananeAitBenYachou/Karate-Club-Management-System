using System;
using System.Data;
using System.Data.SqlClient;

namespace KarateClubDataAccessLayer
{
    public class clsBeltTestDataAccess
    {
        public static bool GetBeltTestByID(int TestID, ref int MemberID, ref int RankID, ref bool Result, ref DateTime Date, ref int TestedByInstructorID, ref int PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM BeltTests WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

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
                    RankID = (int)reader["RankID"];
                    Result = (bool)reader["Result"];
                    Date = (DateTime)reader["Date"];
                    TestedByInstructorID = (int)reader["TestedByInstructorID"];
                    PaymentID = (int)reader["PaymentID"];

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

        public static bool IsBeltTetsExist(int TestID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 FROM BeltTests WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

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

        public static int AddNewBeltTest(int MemberID, int RankID, bool Result, DateTime Date, int TestedByInstructorID, int PaymentID)
        {
            int TestID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO BeltTests (MemberID,RankID,Result,Date,TestedByInstructorID,PaymentID) 
                             VALUES (@MemberID,@RankID,@Result,@Date,@TestedByInstructorID,@PaymentID) 
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@RankID", RankID);
            command.Parameters.AddWithValue("@Result", Result);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@TestedByInstructorID", TestedByInstructorID);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int insertedID))
                {
                    TestID = insertedID;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return TestID;
        }

        public static bool UpdateBeltTest(int TestID, int MemberID, int RankID, bool Result, DateTime Date, int TestedByInstructorID, int PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE BeltTests
                            SET MemberID = @MemberID,
                            RankID = @RankID,
                            Result = @Result,
                            Date = @Date ,
                            TestedByInstructorID = @TestedByInstructorID,
                            PaymentID = @PaymentID
                            WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@RankID", RankID);
            command.Parameters.AddWithValue("@Result", Result);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@TestedByInstructorID", TestedByInstructorID);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);

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

        public static bool DeleteBeltTest(int TestID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM BeltTests WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

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

        public static int GetBeltTestsCount()
        {
            int BeltTestsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) FROM BeltTests";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int Count))
                {
                    BeltTestsCount = Count;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return BeltTestsCount;
        }

        public static DataTable GetAllBeltTests()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT BeltTests.TestID,MembersDetailedInfo.Name as MemberName,BeltRanks.RankName,BeltTests.Result,BeltTests.Date,
                            InstructorsDetailedInfo.Name as InstructorName,BeltTests.PaymentID
                            FROM BeltTests 
                            INNER JOIN MembersDetailedInfo ON MembersDetailedInfo.MemberID = BeltTests.MemberID 
                            INNER JOIN BeltRanks ON BeltRanks.RankID = BeltTests.RankID
                            INNER JOIN InstructorsDetailedInfo ON InstructorsDetailedInfo.InstructorID = BeltTests.TestedByInstructorID";

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
