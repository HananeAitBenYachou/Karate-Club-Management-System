using System;
using System.Data;
using System.Data.SqlClient;

namespace KarateClubDataAccessLayer
{
    public class clsBeltRankDataAccess
    {
        public static bool GetBeltRankByID(int RankID, ref string RankName, ref double TestFees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM BeltRanks WHERE RankID = @RankID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RankID", RankID);

            SqlDataReader reader = null;

            bool isFound = false;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    RankName = (string)reader["RankName"];
                    TestFees = Convert.ToDouble(reader["TestFees"]);
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

        public static bool GetBeltRankByName(string RankName, ref int RankID, ref double TestFees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM BeltRanks WHERE RankName = @RankName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RankName", RankName);

            SqlDataReader reader = null;

            bool isFound = false;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    RankID = (int)reader["RankID"];
                    TestFees = Convert.ToDouble(reader["TestFees"]);
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

        public static int GetBeltRankIDByName(string RankName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT RankID
                            FROM BeltRanks
                            WHERE RankName = @RankName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RankName", RankName);

            object reader = null;

            int RankID = -1;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int _RankID))
                {
                    RankID = _RankID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return RankID;
        }

        public static string GetBeltRankName(int RankID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT RankName
                            FROM BeltRanks
                            WHERE RankID = @RankID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RankID", RankID);

            object reader = null;

            string RankName = "";

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null)
                {
                    RankName = reader.ToString();
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return RankName;
        }

        public static bool IsBeltRankExist(int RankID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 FROM BeltRanks WHERE RankID = @RankID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RankID", RankID);

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

        public static bool IsBeltRankExist(string RankName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 FROM BeltRanks WHERE RankName = @RankName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RankName", RankName);

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

        public static double GetBeltRankTestFeesByID(int RankID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT TestFees FROM BeltRanks WHERE RankID = @RankID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RankID", RankID);

            object reader = null;

            double TestFees = 0;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null && double.TryParse(reader.ToString(), out double Fees))
                {
                    TestFees = Fees;
                }
            }

            catch (Exception ex)
            {
            }

            finally
            {
                connection.Close();
            }

            return TestFees;
        }

        public static int AddNewBeltRank(string RankName, double TestFees)
        {
            int RankID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO BeltRanks (RankName,TestFees) 
                             VALUES (@RankName,@TestFees)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RankName", RankName);
            command.Parameters.AddWithValue("@TestFees", TestFees);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int insertedID))
                {
                    RankID = insertedID;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return RankID;
        }

        public static bool UpdateBeltRank(int RankID, string RankName, double TestFees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE BeltRanks
                            SET RankName = @RankName,
                            TestFees = @TestFees
                            WHERE RankID = @RankID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RankName", RankName);
            command.Parameters.AddWithValue("@TestFees", TestFees);
            command.Parameters.AddWithValue("@RankID", RankID);

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

        public static bool DeleteBeltRank(int RankID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM BeltRanks WHERE RankID = @RankID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RankID", RankID);

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

        public static DataTable GetAllBeltRanks()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM BeltRanks";

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
