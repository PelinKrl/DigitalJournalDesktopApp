﻿using System;
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
        public static List<string> GetMovieTvShowGenres()
        {
            List<string> genres = new List<string>();
            try
            {
                string query = "SELECT MovieTvShowGenre FROM MovieTvShowGenreTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        genres.Add(reader["MovieTvShowGenre"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving genres: " + ex.Message);
            }
            return genres;
        }

        public static void InsertJournalText(DateTime date, string journalText)
        {
            try
            {
                string queryCheck = "SELECT COUNT(*) FROM JournalTable WHERE CAST(Date AS DATE) = @Date AND UserId = @UserId";
                using (SqlCommand commandCheck = new SqlCommand(queryCheck, connection))
                {
                    commandCheck.Parameters.AddWithValue("@Date", date);
                    commandCheck.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                    int count = Convert.ToInt32(commandCheck.ExecuteScalar());

                    if (count > 0)
                    {
                        string queryUpdate = "UPDATE JournalTable SET JournalText = @JournalText WHERE CAST(Date AS DATE) = @Date AND UserId = @UserId";
                        using (SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection))
                        {
                            commandUpdate.Parameters.AddWithValue("@JournalText", journalText);
                            commandUpdate.Parameters.AddWithValue("@Date", date);
                            commandUpdate.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                            int result = commandUpdate.ExecuteNonQuery();
                            if (result <= 0)
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
                            commandInsert.Parameters.AddWithValue("@Date", date);
                            commandInsert.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                            int result = commandInsert.ExecuteNonQuery();
                            if (result <= 0)
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

        //public static DataTable ExecuteQuery(string query)
        //{
        //    DataTable dataTable = new DataTable();
        //    try
        //    {
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            SqlDataAdapter adapter = new SqlDataAdapter(command);
        //            adapter.Fill(dataTable);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message);
        //    }
        //    return dataTable;
        //}
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
                if (dataGridView.Columns["Id"] != null)
                {
                    dataGridView.Columns["Id"].Visible = false;
                }
                if (dataGridView.Columns["UserId"] != null)
                {
                    dataGridView.Columns["UserId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        public static void SearchWatchListByName(string searchType, string name, DataGridView dataGridView)
        {
            try
            {
                string query = "";
                switch (searchType)
                {
                    case "Movie Name":
                        query = "SELECT * FROM WatchTable WHERE Type = 'Movie' AND Name LIKE @Name AND UserId = @UserId";
                        break;
                    case "Tv Show Name":
                        query = "SELECT * FROM WatchTable WHERE Type = 'TV Show' AND Name LIKE @Name AND UserId = @UserId";
                        break;
                    case "Director Name":
                        query = "SELECT * FROM WatchTable WHERE Director LIKE @Name AND UserId = @UserId";
                        break;
                    default:
                        MessageBox.Show("Invalid search type.");
                        return;
                }

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


        public static void FilterWatchListByState(string state, DataGridView dataGridView, int userId)
        {
            try
            {
                string query = "SELECT * FROM WatchTable WHERE State = @State AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@State", state);
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering by state: " + ex.Message);
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
        public static Dictionary<string, object> GetTrackBehaviorByDate(DateTime date)
        {
            Dictionary<string, object> trackBehavior = null;
            try
            {
                string query = "SELECT Mood, WaterCount, PageCount, HoursOfWork, MinutesOfExercise, MinutesOfWatch, HoursOfSleep FROM TrackBehaviour WHERE CAST(Date AS DATE) = @Date AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Date", date.Date);
                    command.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            trackBehavior = new Dictionary<string, object>
                    {
                        { "Mood", reader["Mood"].ToString() },
                        { "WaterCount", Convert.ToInt32(reader["WaterCount"]) },
                        { "PageCount", Convert.ToInt32(reader["PageCount"]) },
                        { "HoursOfWork", Convert.ToInt32(reader["HoursOfWork"]) },
                        { "MinutesOfExercise", Convert.ToInt32(reader["MinutesOfExercise"]) },
                        { "MinutesOfWatch", Convert.ToInt32(reader["MinutesOfWatch"]) },
                        { "HoursOfSleep", Convert.ToInt32(reader["HoursOfSleep"]) }
                    };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving track behavior: " + ex.Message);
            }
            return trackBehavior;
        }

        public static void InsertTrackBehaviour(DateTime date, string mood, int waterCount, int pageCount, int work, int exercise, int watch, int sleep)
        {
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM TrackBehaviour WHERE CAST(Date AS DATE) = @Date AND UserId = @UserId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Date", date.Date);
                    checkCommand.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        string updateQuery = "UPDATE TrackBehaviour SET Mood = @Mood, WaterCount = @WaterCount, PageCount = @PageCount, " +
                                             "HoursOfWork = @HoursOfWork, MinutesOfExercise = @MinutesOfExercise, " +
                                             "MinutesOfWatch = @MinutesOfWatch, HoursOfSleep = @HoursOfSleep " +
                                             "WHERE CAST(Date AS DATE) = @Date AND UserId = @UserId";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@Mood", mood);
                            updateCommand.Parameters.AddWithValue("@WaterCount", waterCount);
                            updateCommand.Parameters.AddWithValue("@PageCount", pageCount);
                            updateCommand.Parameters.AddWithValue("@HoursOfWork", work);
                            updateCommand.Parameters.AddWithValue("@MinutesOfExercise", exercise);
                            updateCommand.Parameters.AddWithValue("@MinutesOfWatch", watch);
                            updateCommand.Parameters.AddWithValue("@HoursOfSleep", sleep);
                            updateCommand.Parameters.AddWithValue("@Date", date.Date);
                            updateCommand.Parameters.AddWithValue("@UserId", MainAppForm._userId);

                            int result = updateCommand.ExecuteNonQuery();
                            if (result <= 0)
                            {
                                MessageBox.Show("Update failed.");
                            }
                        }
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO TrackBehaviour (UserId, Date, Mood, WaterCount, PageCount, HoursOfWork, MinutesOfExercise, MinutesOfWatch, HoursOfSleep) " +
                                             "VALUES (@UserId, @Date, @Mood, @WaterCount, @PageCount, @HoursOfWork, @MinutesOfExercise, @MinutesOfWatch, @HoursOfSleep)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                            insertCommand.Parameters.AddWithValue("@Date", date.Date);
                            insertCommand.Parameters.AddWithValue("@Mood", mood);
                            insertCommand.Parameters.AddWithValue("@WaterCount", waterCount);
                            insertCommand.Parameters.AddWithValue("@PageCount", pageCount);
                            insertCommand.Parameters.AddWithValue("@HoursOfWork", work);
                            insertCommand.Parameters.AddWithValue("@MinutesOfExercise", exercise);
                            insertCommand.Parameters.AddWithValue("@MinutesOfWatch", watch);
                            insertCommand.Parameters.AddWithValue("@HoursOfSleep", sleep);

                            int result = insertCommand.ExecuteNonQuery();
                            if (result <= 0)
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

        public static List<string> GetBookGenres()
        {
            List<string> genres = new List<string>();
            try
            {
                string query = "SELECT BookGenre FROM BookGenreTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        genres.Add(reader["BookGenre"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving book genres: " + ex.Message);
            }
            return genres;
        }

        public static void InsertReadingList(string name, string author, string state, int rate, string comment, string genre, int pageCount)
        {
            try
            {
                string query = "INSERT INTO BooksTable (BookName, Author, State, Rating, Comment, Genre, Date, UserId, Pagecount) VALUES (@BookName, @Author, @State, @Rating, @Comment, @Genre, @Date, @UserId, @PageCount)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookName", name);
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@State", state);
                    command.Parameters.AddWithValue("@Rating", rate == -1 ? (object)DBNull.Value : rate);
                    command.Parameters.AddWithValue("@Comment", comment);
                    command.Parameters.AddWithValue("@Genre", genre);
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
                    command.Parameters.AddWithValue("@PageCount", pageCount == -1 ? (object)DBNull.Value : pageCount);
                    command.Parameters.AddWithValue("@UserId", MainAppForm._userId);


                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        
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

        public static void UpdateReadingListItem(int id, string name, string author, string state, int rate, string comment, string genre, int pageCount)
        {
            try
            {
                string queryUpdate = "UPDATE BooksTable SET BookName = @BookName, Author = @Author, State = @State, Rating = @Rating, Comment = @Comment, Genre = @Genre, PageCount = @PageCount WHERE ID = @ID AND UserId = @UserId";
                using (SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection))
                {
                    commandUpdate.Parameters.AddWithValue("@ID", id);
                    commandUpdate.Parameters.AddWithValue("@BookName", name);
                    commandUpdate.Parameters.AddWithValue("@Author", author);
                    commandUpdate.Parameters.AddWithValue("@State", state);
                    commandUpdate.Parameters.AddWithValue("@Rating", rate == -1 ? (object)DBNull.Value : rate);
                    commandUpdate.Parameters.AddWithValue("@Comment", comment);
                    commandUpdate.Parameters.AddWithValue("@Genre", genre);
                    commandUpdate.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                    commandUpdate.Parameters.AddWithValue("@PageCount", pageCount == -1 ? (object)DBNull.Value : pageCount);

                    int result = commandUpdate.ExecuteNonQuery();
                    if (result > 0)
                    {
                        
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

        public static void DeleteReadingListItem(int id)
        {
            try
            {
                string query = "DELETE FROM BooksTable WHERE ID = @ID AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@UserId", MainAppForm._userId);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        
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

        public static void SearchReadingListByName(string name, DataGridView dataGridView)
        {
            try
            {
                string query = "SELECT * FROM BooksTable WHERE Name LIKE @BookName AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookName", "%" + name + "%");
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

        public static void InsertTask(string name, string description, DateTime deadline, string priority, string tag, bool state)
        {
            try
            {
                string query = "INSERT INTO TaskPlannerTable (Name, Description, Deadline, Priority, Tag, State, UserId, Date) " +
                               "VALUES (@Name, @Description, @Deadline, @Priority, @Tag, @State, @UserId, @Date)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Deadline", deadline);
                    command.Parameters.AddWithValue("@Priority", priority);
                    command.Parameters.AddWithValue("@Tag", tag);
                    command.Parameters.AddWithValue("@State", state ? "Done" : "Not Done"); // Assuming the state is either Completed or Pending
                    command.Parameters.AddWithValue("@UserId", MainAppForm._userId);
                    command.Parameters.AddWithValue("@Date", DateTime.Now); // Add the current date and time

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Task insertion failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        public static void UpdateTask(int id, string name, string description, DateTime deadline, string priority, string tag, bool state)
        {
            try
            {
                string query = "UPDATE TaskPlannerTable SET Name = @Name, Description = @Description, Deadline = @Deadline, " +
                               "Priority = @Priority, Tag = @Tag, State = @State, Date = @Date WHERE Id = @Id AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Deadline", deadline);
                    command.Parameters.AddWithValue("@Priority", priority);
                    command.Parameters.AddWithValue("@Tag", tag);
                    command.Parameters.AddWithValue("@State", state ? "Done" : "Not Done");
                    command.Parameters.AddWithValue("@Date", DateTime.Now); // Update the current date and time
                    command.Parameters.AddWithValue("@UserId", MainAppForm._userId);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Task update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public static void DeleteTask(int id)
        {
            try
            {
                string query = "DELETE FROM TaskPlannerTable WHERE Id = @Id AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@UserId", MainAppForm._userId);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Task deletion failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public static void SearchTaskByTagAndName(string tag, string name, DataGridView dataGridView, int userId)
        {
            try
            {
                string query = "SELECT Name, Description, Deadline, Priority, Tag, State, Date FROM TaskPlannerTable WHERE Tag LIKE @Tag AND Name LIKE @Name AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Tag", "%" + tag + "%");
                    command.Parameters.AddWithValue("@Name", "%" + name + "%");
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching by tag and name: " + ex.Message);
            }
        }


        public static void FilterTasksByDeadline(DateTime startDate, DateTime endDate, DataGridView dataGridView, int userId)
        {
            try
            {
                startDate = startDate.Date;
                endDate = endDate.Date.AddDays(1).AddTicks(-1); // End of the day
                string query = "SELECT * FROM TaskPlannerTable WHERE Deadline BETWEEN @StartDate AND @EndDate AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering tasks by deadline dates: " + ex.Message);
            }
        }


        public static void FilterTasksByState(string state, DataGridView dataGridView, int userId)
        {
            try
            {
                string query = "SELECT * FROM TaskPlannerTable WHERE State = @State AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@State", state);
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering tasks by state: " + ex.Message);
            }
        }


        public static void FilterTasksByPriorities(List<string> priorities, DataGridView dataGridView, int userId)
        {
            try
            {
                if (priorities.Count == 0)
                {
                    MessageBox.Show("Please select at least one priority to filter.");
                    return;
                }

                string query = "SELECT * FROM TaskPlannerTable WHERE Priority IN (" + string.Join(",", priorities.Select(p => "'" + p + "'")) + ") AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering tasks by priorities: " + ex.Message);
            }
        }

        public static DataTable GetTasksForToday(int userId, DateTime date)
        {
            DataTable dataTable = new DataTable();
            try
            {
                string query = "SELECT Name FROM TaskPlannerTable WHERE CAST(Deadline AS DATE) = @Date AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Date", date.Date);
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving tasks for the selected date: " + ex.Message);
            }
            return dataTable;
        }


        public static void UpdateUserName(int userId, string newUsername)
        {
            try
            {
                // Check if the new username is already taken
                if (CheckUsernameExists(newUsername))
                {
                    MessageBox.Show("The username is already taken. Please choose a different username.");
                    return;
                }

                string query = "UPDATE UsersTable SET UserName = @NewUsername WHERE Id = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewUsername", newUsername);
                    command.Parameters.AddWithValue("@UserId", userId);
                    int result = command.ExecuteNonQuery();
                    if (result <= 0)
                    {
                        MessageBox.Show("Failed to update username.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating username: " + ex.Message);
            }
        }

        public static void UpdateUserPassword(string username, string newPassword)
        {
            try
            {
                string salt = GetSalt(username); // Use GetSalt method with username
                string hashedPassword = Security.HashPassword(newPassword, salt);
                string query = "UPDATE UsersTable SET Password = @NewPassword WHERE UserName = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewPassword", hashedPassword);
                    command.Parameters.AddWithValue("@Username", username);
                    int result = command.ExecuteNonQuery();
                    if (result <= 0)
                    {
                        MessageBox.Show("Failed to update password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating password: " + ex.Message);
            }
        }

        public static void UpdateUserCity(int userId, string newCity)
        {
            try
            {
                string query = "UPDATE UsersTable SET Location = @NewCity WHERE Id = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewCity", newCity);
                    command.Parameters.AddWithValue("@UserId", userId);
                    int result = command.ExecuteNonQuery();
                    if (result <= 0)
                    {
                        MessageBox.Show("Failed to update city.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating city: " + ex.Message);
            }
        }
        public static void AddMovieGenre(string genre)
        {

            try
            {
                if (!CheckMovieGenreExists(genre))
                {
                    string query = "INSERT INTO MovieTvShowGenreTable (MovieTvShowGenre) VALUES (@Genre)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Genre", genre);
                        int result = command.ExecuteNonQuery();
                        if (result <= 0)
                        {
                            MessageBox.Show("Failed to insert genre.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Genre already exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting movie/tv show genre: " + ex.Message);
            }
        }

        private static bool CheckMovieGenreExists(string genre)
        {
            try
            {
                string query = "SELECT COUNT(1) FROM MovieTvShowGenreTable WHERE MovieTvShowGenre = @Genre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Genre", genre);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking if movie/tv show genre exists: " + ex.Message);
                return false;
            }
        }
        public static void AddBookGenre(string genre)
        {
            try
            {
                if (!CheckBookGenreExists(genre))
                {
                    string query = "INSERT INTO BookGenreTable (BookGenre) VALUES (@Genre)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Genre", genre);
                        int result = command.ExecuteNonQuery();
                        if (result <= 0)
                        {
                            MessageBox.Show("Failed to insert genre.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Genre already exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting book genre: " + ex.Message);
            }
        }
        private static bool CheckBookGenreExists(string genre)
        {
            try
            {
                string query = "SELECT COUNT(1) FROM BookGenreTable WHERE BookGenre = @Genre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Genre", genre);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking if book genre exists: " + ex.Message);
                return false;
            }
        }

        public static void DeleteMovieGenre(string genre)
        {
            try
            {
                string query = "DELETE FROM MovieTvShowGenreTable WHERE MovieTvShowGenre = @Genre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Genre", genre);
                    int result = command.ExecuteNonQuery();
                    if (result <= 0)
                    {
                        MessageBox.Show("Failed to delete genre.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting movie/tv show genre: " + ex.Message);
            }
        }

        public static void DeleteBookGenre(string genre)
        {
            try
            {
                string query = "DELETE FROM BookGenreTable WHERE BookGenre = @Genre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Genre", genre);
                    int result = command.ExecuteNonQuery();
                    if (result <= 0)
                    {
                        MessageBox.Show("Failed to delete genre.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting book genre: " + ex.Message);
            }
        }



        public static DataTable GetTrackBehaviourDataByDateRange(int userId, DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();
            try
            {
                string query = "SELECT Date, Mood, WaterCount, PageCount, HoursOfWork, MinutesOfExercise, MinutesOfWatch, HoursOfSleep " +
                               "FROM TrackBehaviour WHERE UserId = @UserId AND Date BETWEEN @StartDate AND @EndDate";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving track behavior data: " + ex.Message);
            }
            return dataTable;
        }

        public static void InsertToDoItem(int userId, string todo)
        {
            try
            {
                string query = "INSERT INTO ToDoListTable (UserId, ToDos) VALUES (@UserId, @ToDos)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@ToDos", todo);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting to-do item: " + ex.Message);
            }
        }

        public static void DeleteToDoItem(int userId, int id)
        {
            try
            {
                string query = "DELETE FROM ToDoListTable WHERE Id = @Id AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting to-do item: " + ex.Message);
            }
        }

        public static DataTable GetToDoItems(int userId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                string query = "SELECT * FROM ToDoListTable WHERE UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving to-do items: " + ex.Message);
            }
            return dataTable;
        }

        public static string GetUserCity(int userId)
        {
            string city = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Location FROM UsersTable WHERE Id = @UserId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        city = (string)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching city: " + ex.Message);
            }
            return city;
        }



    }

}
















