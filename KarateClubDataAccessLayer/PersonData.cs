using System;
using System.Data.SqlClient;


namespace KarateClubDataAccessLayer
{
    public class clsPersonDataAccess
    {
        public static bool GetPersonByID(int PersonID, ref string Name, ref string Address, ref string Phone,
            ref string Email, ref char Gender, ref DateTime DateOfBirth, ref string Password, ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Persons WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            SqlDataReader reader = null;

            bool isFound = false;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Name = (string)reader["Name"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Gender = ((string)reader["Gender"])[0];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Password = (string)reader["Password"];

                    if (reader["ImagePath"] != System.DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";
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

        public static bool GetPersonByIDAndPassword(int PersonID, ref string Name, ref string Address, ref string Phone,
          ref string Email, ref char Gender, ref DateTime DateOfBirth, string Password, ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Persons WHERE PersonID = @PersonID AND Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
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

                    Name = (string)reader["Name"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Gender = ((string)reader["Gender"])[0];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    if (reader["ImagePath"] != System.DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";
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

        public static bool IsPersonExist(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 FROM Persons WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static int AddNewPerson(string Name, string Address, string Phone,
             string Email, char Gender, DateTime DateOfBirth, string Password, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Persons(Name,Address,Phone,Email,Gender,DateOfBirth,Password,ImagePath) 
                             VALUES (@Name,@Address,@Phone,@Email,@Gender,@DateOfBirth,@Password,@ImagePath)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Password", Password);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            object reader = 0;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string Name, string Address, string Phone,
             string Email, char Gender, DateTime DateOfBirth, string Password, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Persons
                             SET Name = @Name ,
                             Address = @Address ,
                             Phone = @Phone ,
                             Email = @Email ,
                             Gender = @Gender ,
                             DateOfBirth = @DateOfBirth ,
                             Password = @Password ,
                             ImagePath = @ImagePath
                             WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Password", Password);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

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

        public static bool DeletePerson(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM Persons WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

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

    }
}
