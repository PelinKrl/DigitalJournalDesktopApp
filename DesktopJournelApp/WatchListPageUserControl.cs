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
        }

        public DataGridView WldataGridView;

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
            if (!string.IsNullOrEmpty(name))
            {
                SQL.SearchWatchListByName(name, WLdataGridView);
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

            // Get the selected row
            DataGridViewRow selectedRow = WLdataGridView.Rows[e.RowIndex];

            // Populate the text fields and combo boxes with the selected row's data
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
                // Get the selected row
                DataGridViewRow selectedRow = WLdataGridView.SelectedRows[0];

                // Assuming your primary key column is 'ID' and it's the first column in the DataGridView
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Get the updated values from the text fields and combo boxes
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

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(state) && !string.IsNullOrEmpty(genre))
                {
                    // Update the database
                    SQL.UpdateWatchListItem(id, name, type, director, state, rating, comment, genre);

                    // Refresh the DataGridView
                    string query = "SELECT * FROM WatchTable UserId=@UserId";
                    SQL.BindToGrid(query, WLdataGridView, MainAppForm._userId);
                }
                else
                {
                    MessageBox.Show("You did not fill all the necessary fields.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void WLFilterByGenreButton_Click(object sender, EventArgs e)
        {
            // Get the selected genres from the CheckedListBox
            List<string> selectedGenres = new List<string>();
            foreach (object item in GenresCheckedListBox.CheckedItems)
            {
                selectedGenres.Add(item.ToString());
            }

            if (selectedGenres.Count > 0)
            {
                // Build the query to filter by selected genres
                string query = "SELECT * FROM WatchTable WHERE Genre IN ('" + string.Join("','", selectedGenres) + "') AND UserId=@UserId";
                SQL.BindToGrid(query, WLdataGridView, MainAppForm._userId);
            }
            else
            {
                // If no genres are selected, show all entries
                string query = "SELECT * FROM WatchTable WHERE UserId=@UserId ";
                SQL.BindToGrid(query, WLdataGridView, MainAppForm._userId);
            }

            GenresCheckedListBox.Visible = false;

        }

        private void WLGenresButton_Click(object sender, EventArgs e)
        {
            GenresCheckedListBox.Visible = true; 
        }
    }
}
