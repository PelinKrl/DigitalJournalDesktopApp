using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DesktopJournelApp
{
    public partial class WatchListPageUserControl : UserControl
    {
        public WatchListPageUserControl()
        {
            InitializeComponent();
            LoadGenres();
        }

        public DataGridView WldataGridView;

        private void LoadGenres()
        {
            List<string> genres = SQL.GetMovieTvShowGenres();
            GenreComboBox.Items.Clear();
            GenresCheckedListBox.Items.Clear ();
            foreach (string genre in genres)
            {
                GenreComboBox.Items.Add(genre);
                GenresCheckedListBox.Items.Add(genre);
            }
        }

        private void WLSaveButton_Click(object sender, EventArgs e)
        {
            string name = WLNameTextBox.Text;
            string type = WLTypeComboBox.Text;
            string state = WLStateComboBox.Text;
            string Rate  =  WLRatingTextBox.Text;
            string director = WLDirectorTextBox.Text;
            string comment = WLCommentsRichTextBox.Text;
            string genre = GenreComboBox.Text;

            int rate = -1;

            if (Rate!= string.Empty) { rate = Convert.ToInt32(Rate); }
            if (rate < 11 && rate>-1) {
                if (name != string.Empty && type != string.Empty && state != string.Empty && genre != string.Empty)
                {

                    SQL.InsertWatchList(name, type, director, state, rate, comment, genre);

                    WLNameTextBox.Clear();
                    WLDirectorTextBox.Clear();
                    WLRatingTextBox.Clear();
                    WLCommentsRichTextBox.Clear();

                }
                else
                {
                    MessageBox.Show("You did not fill all the necessary fields.");
                }
            }
            else
            {
                MessageBox.Show("Rate must be in beetween 0 and 10");
            }


        }

        private void WLListMoviesButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM WatchTable WHERE Type = 'Movie' AND UserId=@UserId";
            SQL.BindToGrid(query, WLdataGridView, MainAppForm._userId);
        }

        private void WLListTvShowsButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM WatchTable WHERE Type = 'TV Show' AND UserId=@UserId";
            SQL.BindToGrid(query, WLdataGridView, MainAppForm._userId);
        }

        private void WLListAllButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM WatchTable WHERE UserId=@UserId";
            SQL.BindToGrid(query, WLdataGridView, MainAppForm._userId);
        }

        private void WLSearch_Click(object sender, EventArgs e)
        {
            string name = WLSearchTextBox.Text;
            string searchType = SearchComboBox.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(name))
            {
                SQL.SearchWatchListByName(searchType, name, WLdataGridView);
            }
            else
            {
                MessageBox.Show("Please enter a name to search.");
            }
        }

        private void WLDeleteButton_Click(object sender, EventArgs e)
        {
            if (WLdataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = WLdataGridView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                SQL.DeleteWatchListItem(id);
                string query = "SELECT * FROM WatchTable WHERE UserId=@UserId";
                SQL.BindToGrid(query, WLdataGridView, MainAppForm._userId);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void WLdataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            
            DataGridViewRow selectedRow = WLdataGridView.Rows[e.RowIndex];

            
            WLTypeComboBox.Text = selectedRow.Cells["Type"].Value.ToString();
            WLNameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
            WLDirectorTextBox.Text = selectedRow.Cells["Director"].Value.ToString();
            WLStateComboBox.Text = selectedRow.Cells["State"].Value.ToString();
            GenreComboBox.Text = selectedRow.Cells["Genre"].Value.ToString();
            WLRatingTextBox.Text = selectedRow.Cells["Rate"].Value != DBNull.Value ? selectedRow.Cells["Rate"].Value.ToString() : string.Empty;
            WLCommentsRichTextBox.Text = selectedRow.Cells["Comment"].Value.ToString();
        }

        private void WLUpdateButton_Click(object sender, EventArgs e)
        {
            if (WLdataGridView.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = WLdataGridView.SelectedRows[0];

                
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                string name = WLNameTextBox.Text;
                string type = WLTypeComboBox.Text;
                string state = WLStateComboBox.Text;
                string rate = WLRatingTextBox.Text;
                string director = WLDirectorTextBox.Text;
                string comment = WLCommentsRichTextBox.Text;
                string genre = GenreComboBox.Text;

                int rating = -1;
                if (!string.IsNullOrEmpty(rate))
                {
                    rating = Convert.ToInt32(rate);
                }

                if(rating < 11 && rating > -1)
                {
                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(state) && !string.IsNullOrEmpty(genre))
                    {
                        // Update the database
                        SQL.UpdateWatchListItem(id, name, type, director, state, rating, comment, genre);

                        // Refresh the DataGridView
                        string query = "SELECT * FROM WatchTable WHERE UserId=@UserId";
                        SQL.BindToGrid(query, WLdataGridView, MainAppForm._userId);
                    }
                    else
                    {
                        MessageBox.Show("You did not fill all the necessary fields.");
                    }
                }
                else
                {
                    MessageBox.Show("Rate must be in beetween 0 and 10");
                }

                
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void WLFilterByGenreButton_Click(object sender, EventArgs e)
        {
            List<string> selectedGenres = new List<string>();
            foreach (object item in GenresCheckedListBox.CheckedItems)
            {
                selectedGenres.Add(item.ToString());
            }

            if (selectedGenres.Count > 0)
            {
                
                string query = "SELECT * FROM WatchTable WHERE Genre IN ('" + string.Join("','", selectedGenres) + "') AND UserId=@UserId";
                SQL.BindToGrid(query, WLdataGridView, MainAppForm._userId);
            }
            else
            {
               
                string query = "SELECT * FROM WatchTable WHERE UserId=@UserId ";
                SQL.BindToGrid(query, WLdataGridView, MainAppForm._userId);
            }

            GenresCheckedListBox.Visible = false;

        }

        private void WLGenresButton_Click(object sender, EventArgs e)
        {
            if (GenresCheckedListBox.Visible == true)
            {
                GenresCheckedListBox.Visible = false;
            }
            else
            {
                GenresCheckedListBox.Visible = true;
            }
           
           

        }

        
        private void WLListStateButton_Click(object sender, EventArgs e)
        {
            string state = WLStateFilterComboBox.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(state))
            {
                SQL.FilterWatchListByState(state, WLdataGridView, MainAppForm._userId);
            }
            else
            {
                MessageBox.Show("Please select a state to filter.");
            }
        }

        private void SaveDataGridViewToCSV(DataGridView dataGridView, string fileName)
        {
            StringBuilder csvContent = new StringBuilder();

            // Add headers
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                csvContent.Append(dataGridView.Columns[i].HeaderText + ",");
            }
            csvContent.AppendLine();

            // Add rows
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    csvContent.Append(row.Cells[i].Value + ",");
                }
                csvContent.AppendLine();
            }

            // Save to file
            File.WriteAllText(fileName, csvContent.ToString());
            MessageBox.Show("Log saved to " + fileName);
        }

        private void WLLogButton_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = Path.Combine(desktopPath, "WatchingListLog.csv");
            SaveDataGridViewToCSV(WLdataGridView, fileName);
        }
    }
}
