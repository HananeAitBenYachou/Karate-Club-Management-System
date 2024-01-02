using System;
using System.Data;
using System.Data.SqlClient;

namespace KarateClubDataAccessLayer
{
    public class clsSubscriptionPeriodDataAccess
    {
        public static bool GetSubscriptionPeriodByID(int PeriodID, ref int MemberID, ref int? PaymentID, ref DateTime StartDate, ref DateTime EndDate, ref double Fees, ref bool Paid)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM SubscriptionPeriods WHERE PeriodID = @PeriodID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PeriodID", PeriodID);

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

                    if (reader["PaymentID"] != System.DBNull.Value)
                        PaymentID = (int)reader["PaymentID"];
                    else
                        PaymentID = null;

                    StartDate = (DateTime)reader["StartDate"];
                    EndDate = (DateTime)reader["EndDate"];
                    Fees = Convert.ToDouble(reader["Fees"]);
                    Paid = (bool)reader["Paid"];

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

        public static bool IsSubscriptionPeriodExist(int PeriodID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 FROM SubscriptionPeriods WHERE PeriodID = @PeriodID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PeriodID", PeriodID);

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

        public static bool IsSubscriptionPeriodPaid(int PeriodID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isPaid = 1 FROM SubscriptionPeriods WHERE Paid = 1 AND PeriodID = @PeriodID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PeriodID", PeriodID);

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

        public static int AddNewSubscriptionPeriod(int MemberID, int? PaymentID, DateTime StartDate, DateTime EndDate, double Fees, bool Paid)
        {
            int PeriodID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO SubscriptionPeriods (MemberID,PaymentID,StartDate,EndDate,Fees,Paid) 
                             VALUES (@MemberID,@PaymentID,@StartDate,@EndDate,@Fees,@Paid) 
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@StartDate", StartDate);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@Paid", Paid);

            if (PaymentID != null)
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
            else
                command.Parameters.AddWithValue("@PaymentID", System.DBNull.Value);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int insertedID))
                {
                    PeriodID = insertedID;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return PeriodID;
        }

        public static bool UpdateSubscriptionPeriod(int PeriodID, int MemberID, int? PaymentID, DateTime StartDate, DateTime EndDate, double Fees, bool Paid)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE SubscriptionPeriods
                            SET MemberID = @MemberID,
                            PaymentID = @PaymentID,
                            StartDate = @StartDate,
                            EndDate = @EndDate,
                            Fees = @Fees,
                            Paid = @Paid
                            WHERE PeriodID = @PeriodID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PeriodID", PeriodID);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@StartDate", StartDate);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@Paid", Paid);

            if (PaymentID != null)
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
            else
                command.Parameters.AddWithValue("@PaymentID", System.DBNull.Value);

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

        public static bool DeleteSubscriptionPeriod(int PeriodID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM SubscriptionPeriods WHERE PeriodID = @PeriodID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PeriodID", PeriodID);

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

        public static int GetSubscriptionPeriodsCount()
        {
            int SubscriptionPeriodsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) FROM SubscriptionPeriods";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int Count))
                {
                    SubscriptionPeriodsCount = Count;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return SubscriptionPeriodsCount;
        }

        public static DataTable GetAllSubscriptionPeriods()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT SubscriptionPeriods.PeriodID, MembersDetailedInfo.Name as MemberName,
                            SubscriptionPeriods.Fees, SubscriptionPeriods.Paid as IsPaid, 
                            SubscriptionPeriods.StartDate,SubscriptionPeriods.EndDate , SubscriptionPeriods.PaymentID
                            FROM SubscriptionPeriods 
                            INNER JOIN MembersDetailedInfo
                            ON SubscriptionPeriods.MemberID = MembersDetailedInfo.MemberID";

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
