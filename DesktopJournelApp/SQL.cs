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
                MessageBox.Show("An error occurred while disconnecting from the database: " + ex.Message);
            }
        }

        public static int ValidateUser(string username, string password)
        {
            int id = -1;
            try
            {
                string storedPassword = "";
                string storedSalt = GetSalt(username);

                string hashedPassword = Security.HashPassword(password, storedSalt);
                string query = "SELECT Password, Id FROM UsersTable WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            storedPassword = reader["Password"].ToString();
                            if (hashedPassword == storedPassword)
                            {
                                id = Convert.ToInt32(reader["Id"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to validate: " + ex.Message);
            }
            return id;
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
                string query = "SELECT Salt FROM UsersTable WHERE UserName = @UserName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", name);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["Salt"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get salt: " + ex.Message);
            }
            return "";
        }

        public static void InsertWatchList(string name, string type, string director, string state, int rate, string comment, string genre)
        {
            try
            {
                string query = "INSERT INTO WatchTable (Name, Type, Director, State, Rate, Comment, Genre, Date, UserId) VALUES (@Name, @Type, @Director, @State, @Rate, @Comment, @Genre, @Date, @UserId)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Type", type);
                    command.Parameters.AddWithValue("@Director", director);
                    command.Parameters.AddWithValue("@State", state);
                    command.Parameters.AddWithValue("@Rate", rate == -1 ? (object)DBNull.Value : rate);
                    command.Parameters.AddWithValue("@Comment", comment);
                    command.Parameters.AddWithValue("@Genre", genre);
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
                    command.Parameters.AddWithValue("@UserId", MainAppForm._userId);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Inserted successfully to your watch list");
                    }
                    else
                    {
                        MessageBox.Show("Insertion failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public static void InsertJournalText(string journalText)
        {
            try
            {
                string queryCheck = "SELECT COUNT(*) FROM JournalTable WHERE CAST(Date AS DATE) = CAST(GETDATE() AS DATE) AND UserId = @UserId";
                using (SqlCommand commandCheck = new SqlCommand(queryCheck, connection))
                {
                    commandCheck.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                    int count = Convert.ToInt32(commandCheck.ExecuteScalar());

                    if (count > 0)
                    {
                        string queryUpdate = "UPDATE JournalTable SET JournalText = @JournalText WHERE CAST(Date AS DATE) = CAST(GETDATE() AS DATE) AND UserId = @UserId";
                        using (SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection))
                        {
                            commandUpdate.Parameters.AddWithValue("@JournalText", journalText);
                            commandUpdate.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                            int result = commandUpdate.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Journal text updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Update failed.");
                            }
                        }
                    }
                    else
                    {
                        string queryInsert = "INSERT INTO JournalTable (JournalText, Date, UserId) VALUES (@JournalText, @Date, @UserId)";
                        using (SqlCommand commandInsert = new SqlCommand(queryInsert, connection))
                        {
                            commandInsert.Parameters.AddWithValue("@JournalText", journalText);
                            commandInsert.Parameters.AddWithValue("@Date", DateTime.Now);
                            commandInsert.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                            int result = commandInsert.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Journal text inserted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Insertion failed.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public static DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return dataTable;
        }
        public static void BindToGrid(string query, DataGridView dataGridView, int userId)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        public static void SearchWatchListByName(string name, DataGridView dataGridView)
        {
            try
            {
                string query = "SELECT * FROM WatchTable WHERE Name LIKE @Name AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", "%" + name + "%");
                    command.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }
        }

        public static void DeleteWatchListItem(int id)
        {
            try
            {
                string query = "DELETE FROM WatchTable WHERE ID = @ID AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@UserId", MainAppForm._userId);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Deleted successfully from your watch list.");
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public static void UpdateWatchListItem(int id, string name, string type, string director, string state, int rate, string comment, string genre)
        {
            try
            {
                string queryUpdate = "UPDATE WatchTable SET Name = @Name, Type = @Type, Director = @Director, State = @State, Rate = @Rate, Comment = @Comment, Genre = @Genre WHERE ID = @ID AND UserId = @UserId";
                using (SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection))
                {
                    commandUpdate.Parameters.AddWithValue("@ID", id);
                    commandUpdate.Parameters.AddWithValue("@Name", name);
                    commandUpdate.Parameters.AddWithValue("@Type", type);
                    commandUpdate.Parameters.AddWithValue("@Director", director);
                    commandUpdate.Parameters.AddWithValue("@State", state);
                    commandUpdate.Parameters.AddWithValue("@Rate", rate == -1 ? (object)DBNull.Value : rate);
                    commandUpdate.Parameters.AddWithValue("@Comment", comment);
                    commandUpdate.Parameters.AddWithValue("@Genre", genre);
                    commandUpdate.Parameters.AddWithValue("@UserId", MainAppForm._userId);

                    int result = commandUpdate.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Updated successfully in your watch list.");
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public static string GetJournalTextByDate(DateTime date)
        {
            string journalText = "";
            try
            {
                string query = "SELECT JournalText FROM JournalTable WHERE CAST(Date AS DATE) = @Date AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            journalText = reader["JournalText"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the journal text: " + ex.Message);
            }
            return journalText;
        }


        public static void InsertTrackBehaviour(string mood, int waterCount, int pageCount, int work, int exercise, int watch, int sleep)
        {
            try
            {
                
                string checkQuery = "SELECT COUNT(*) FROM TrackBehaviour WHERE CAST(Date AS DATE) = @Date AND UserId = @UserId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                    checkCommand.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        
                        string updateQuery = "UPDATE TrackBehaviour SET Mood = @Mood, WaterCount = @WaterCount, PageCount = @PageCount, " +
                                             "MinutesOfWork = @MinutesOfWork, MinutesOfExercise = @MinutesOfExercise, " +
                                             "MinutesOfWatch = @MinutesOfWatch, HoursOfSleep = @HoursOfSleep " +
                                             "WHERE CAST(Date AS DATE) = @Date AND UserId = @UserId";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@Mood", mood);
                            updateCommand.Parameters.AddWithValue("@WaterCount", waterCount);
                            updateCommand.Parameters.AddWithValue("@PageCount", pageCount);
                            updateCommand.Parameters.AddWithValue("@MinutesOfWork", work);
                            updateCommand.Parameters.AddWithValue("@MinutesOfExercise", exercise);
                            updateCommand.Parameters.AddWithValue("@MinutesOfWatch", watch);
                            updateCommand.Parameters.AddWithValue("@HoursOfSleep", sleep);
                            updateCommand.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                            updateCommand.Parameters.AddWithValue("@UserId", MainAppForm._userId);

                            int result = updateCommand.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Track behaviour updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Update failed.");
                            }
                        }
                    }
                    else
                    {
                        
                        string insertQuery = "INSERT INTO TrackBehaviour (UserId, Date, Mood, WaterCount, PageCount, MinutesOfWork, MinutesOfExercise, MinutesOfWatch, HoursOfSleep) " +
                                             "VALUES (@UserId, @Date, @Mood, @WaterCount, @PageCount, @MinutesOfWork, @MinutesOfExercise, @MinutesOfWatch, @HoursOfSleep)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                            insertCommand.Parameters.AddWithValue("@Date", DateTime.Now);
                            insertCommand.Parameters.AddWithValue("@Mood", mood);
                            insertCommand.Parameters.AddWithValue("@WaterCount", waterCount);
                            insertCommand.Parameters.AddWithValue("@PageCount", pageCount);
                            insertCommand.Parameters.AddWithValue("@MinutesOfWork", work);
                            insertCommand.Parameters.AddWithValue("@MinutesOfExercise", exercise);
                            insertCommand.Parameters.AddWithValue("@MinutesOfWatch", watch);
                            insertCommand.Parameters.AddWithValue("@HoursOfSleep", sleep);

                            int result = insertCommand.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Track behaviour inserted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Insertion failed.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



    }
}
