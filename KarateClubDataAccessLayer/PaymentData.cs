using System;
using System.Data;
using System.Data.SqlClient;

namespace KarateClubDataAccessLayer
{
    public class clsPaymentDataAccess
    {
        public static bool GetPaymentByID(int PaymentID, ref double Amount, ref DateTime Date, ref int MemberID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Payments WHERE PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            SqlDataReader reader = null;

            bool isFound = false;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Amount = Convert.ToDouble(reader["Amount"]);
                    Date = (DateTime)reader["Date"];
                    MemberID = (int)reader["MemberID"];
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

        public static bool IsPaymentExist(int PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 FROM Payments WHERE PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

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

        public static int AddNewPayment(double Amount, DateTime Date, int MemberID)
        {
            int PaymentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Payments (Amount,Date,MemberID) 
                             VALUES (@Amount,@Date,@MemberID) 
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@MemberID", MemberID);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int insertedID))
                {
                    PaymentID = insertedID;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return PaymentID;
        }

        public static bool UpdatePayment(int PaymentID, double Amount, DateTime Date, int MemberID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Payments
                            SET Amount = @Amount,
                            Date = @Date,
                            MemberID = @MemberID
                            WHERE PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Date", Date);
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

        public static bool DeletePayment(int PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM Payments WHERE PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

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

        public static int GetPaymentsCount()
        {
            int PaymentsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) FROM Payments";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int Count))
                {
                    PaymentsCount = Count;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return PaymentsCount;
        }

        public static DataTable GetAllPayments()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Payments.PaymentID  , MembersDetailedInfo.Name as MemberName, 
                            Payments.Date as PaymentDate , Payments.Amount as AmoutPaid
                            FROM Payments
                            INNER JOIN MembersDetailedInfo
                            ON Payments.MemberID = MembersDetailedInfo.MemberID";

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
