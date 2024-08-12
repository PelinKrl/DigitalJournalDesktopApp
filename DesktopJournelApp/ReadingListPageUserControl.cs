using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace DesktopJournelApp
{
    public partial class ReadingListPageUserControl : UserControl
    {
        public ReadingListPageUserControl()
        {
            InitializeComponent();
            LoadBookGenres();
        }

        public DataGridView RldataGridView;

        private void LoadBookGenres()
        {
            List<string> genres = SQL.GetBookGenres();
            RLGenreComboBox.Items.Clear();
            RLGenresCheckedListBox.Items.Clear();
            foreach (string genre in genres)
            {
                RLGenreComboBox.Items.Add(genre);
                RLGenresCheckedListBox.Items.Add(genre);
            }
        }

        private void RLSaveButton_Click(object sender, EventArgs e)
        {
            string name = RLNameTextBox.Text;
            string author = RLAuthorTextBox.Text;
            string state = RLStateComboBox.Text;
            string rate = RLRatingTextBox.Text;
            string comment = RLCommentsRichTextBox.Text;
            string genre = RLGenreComboBox.Text;
            int pageCount = Convert.ToInt32(RLPageCountTextBox.Text);


            int rating = -1;

            if (!string.IsNullOrEmpty(rate))
            {
                rating = Convert.ToInt32(rate);
            }
            if (rating < 11 && rating > -1)
            {
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(author) && !string.IsNullOrEmpty(state) && !string.IsNullOrEmpty(genre))
                {
                    SQL.InsertReadingList(name, author, state, rating, comment, genre, pageCount);

                    RLNameTextBox.Clear();
                    RLAuthorTextBox.Clear();
                    RLRatingTextBox.Clear();
                    RLCommentsRichTextBox.Clear();
                    RLPageCountTextBox.Clear();
                    RLStateComboBox.SelectedIndex = -1;
                    RLGenreComboBox.SelectedIndex = -1;
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

        private void RListBooksButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BooksTable WHERE UserId=@UserId";
            SQL.BindToGrid(query, RLdataGridView, MainAppForm._userId);
        }

        private void RLSearchButton_Click(object sender, EventArgs e)
        {
            string name = RSearchTextBox.Text;
            if (!string.IsNullOrEmpty(name))
            {
                SQL.SearchReadingListByName(name, RLdataGridView);
            }
            else
            {
                MessageBox.Show("Please enter a book name to search.");
            }
        }

        private void RLDeleteButton_Click(object sender, EventArgs e)
        {
            if (RLdataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = RLdataGridView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                SQL.DeleteReadingListItem(id);
                string query = "SELECT * FROM BooksTable WHERE UserId=@UserId";
                SQL.BindToGrid(query, RLdataGridView, MainAppForm._userId);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void RLdataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = RLdataGridView.Rows[e.RowIndex];

            RLNameTextBox.Text = selectedRow.Cells["BookName"].Value.ToString();
            RLAuthorTextBox.Text = selectedRow.Cells["Author"].Value.ToString();
            RLStateComboBox.Text = selectedRow.Cells["State"].Value.ToString();
            RLGenreComboBox.Text = selectedRow.Cells["Genre"].Value.ToString();
            RLRatingTextBox.Text = selectedRow.Cells["Rating"].Value != DBNull.Value ? selectedRow.Cells["Rating"].Value.ToString() : string.Empty;
            RLCommentsRichTextBox.Text = selectedRow.Cells["Comment"].Value.ToString();
            RLPageCountTextBox.Text = selectedRow.Cells["PageCount"].Value.ToString();
        }

        private void RLUpdateButton_Click(object sender, EventArgs e)
        {
            if (RLdataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = RLdataGridView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                string name = RLNameTextBox.Text;
                string author = RLAuthorTextBox.Text;
                string state = RLStateComboBox.Text;
                string rate = RLRatingTextBox.Text;
                string comment = RLCommentsRichTextBox.Text;
                string genre = RLGenreComboBox.Text;
                int pageCount = Convert.ToInt32(RLPageCountTextBox.Text);

                int rating = -1;
                if (!string.IsNullOrEmpty(rate))
                {
                    rating = Convert.ToInt32(rate);
                }

                if (rating < 11 && rating > -1)
                {
                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(author) && !string.IsNullOrEmpty(state) && !string.IsNullOrEmpty(genre))
                    {
                        SQL.UpdateReadingListItem(id, name, author, state, rating, comment, genre, pageCount);

                        string query = "SELECT * FROM BooksTable WHERE UserId=@UserId";
                        SQL.BindToGrid(query, RLdataGridView, MainAppForm._userId);
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

        private void RLGenresButton_Click(object sender, EventArgs e)
        {
            if(RLGenresCheckedListBox.Visible == true)
            {
                RLGenresCheckedListBox.Visible = false;
            }
            else
            {
                RLGenresCheckedListBox.Visible = true;
            }
           
        }

        private void RLFilterByGenreButton_Click(object sender, EventArgs e)
        {
            List<string> selectedGenres = new List<string>();
            foreach (object item in RLGenresCheckedListBox.CheckedItems)
            {
                selectedGenres.Add(item.ToString());
            }

            if (selectedGenres.Count > 0)
            {
                string query = "SELECT * FROM BooksTable WHERE Genre IN ('" + string.Join("','", selectedGenres) + "') AND UserId=@UserId";
                SQL.BindToGrid(query, RLdataGridView, MainAppForm._userId);
            }
            else
            {
                string query = "SELECT * FROM BooksTable WHERE UserId=@UserId";
                SQL.BindToGrid(query, RLdataGridView, MainAppForm._userId);
            }

            RLGenresCheckedListBox.Visible = false;
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

        private void RLLogButton_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = Path.Combine(desktopPath, "ReadingListLog.csv");
            SaveDataGridViewToCSV(RLdataGridView, fileName);
        }
    }



}
