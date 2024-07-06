using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopJournelApp
{
    internal class SQL
    {
        private static string connectionString = "Server=DESKTOP-TI7J3GP\\SQLEXPRESS;Database=pelinDatabase;User Id=pelinkrl;Password=pelin2002;";

        static SqlConnection connection = new SqlConnection(connectionString);
        public static void Connect()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
            }
        }
        public static void Disconnect()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while disconnecting to the database: " + ex.Message);
            }
        }

        public static bool ValidateUser(string username, string password)
        {
            bool isValid = false;
            try
            {
                string storedPassword = "";
                string storedSalt = GetSalt(username);

                string hashedPassword = Security.HashPassword(password, storedSalt);
                string query = "SELECT Password FROM UsersTable WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("username", username); 
                    
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) {
                            storedPassword = reader["Password"].ToString();
                            if (hashedPassword == storedPassword)
                            {
                                isValid=true; 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to validate: " + ex.Message);
            }
            return isValid;

        }

        public static bool InsertUser(string username, string password, string location)
        {
            try
            {
                string salt = Security.CreateNewRandomString();
                string encryptedPassword = Security.HashPassword(password, salt);


                string query = "INSERT INTO UsersTable (UserName, Password, Location, Salt) VALUES (@Username, @Password, @Location, @Salt)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", encryptedPassword);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@Salt", salt);



                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

        public static bool CheckUsernameExists(string username)
        {
            try
            {
                string query = "SELECT COUNT(1) FROM UsersTable WHERE UserName = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

        public static string GetSalt(string name)
        {
            try
            {
                string query = "SELECT salt FROM UsersTable WHERE UserName=@UserName"; 
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", name);
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        if (reader.Read()) {
                            string salt = reader["Salt"].ToString();
                            return salt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to validate: "+ ex.Message);
            }

            return ""; 


        }

    }
}
