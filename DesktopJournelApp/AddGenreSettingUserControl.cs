using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopJournelApp
{
    public partial class AddGenreSettingUserControl : UserControl
    {
        private const string placeholderText = "You can add multiple genres line by line.";
        public AddGenreSettingUserControl()
        {
            InitializeComponent();
            LoadMovieGenres();
            LoadBookGenres(); 
        }

        private void LoadMovieGenres()
        {
            List<string> genres = SQL.GetMovieTvShowGenres();
           
            GenreMCheckedListBox.Items.Clear();
            
            foreach (string genre in genres)
            {
                GenreMCheckedListBox.Items.Add(genre);
                
            }
        }
        private void LoadBookGenres()
        {
            List<string> genres = SQL.GetBookGenres();
            GenreBCheckedListBox.Items.Clear();
           
            foreach (string genre in genres)
            {
                
                GenreBCheckedListBox.Items.Add(genre);
            }
        }




        private void SMovieGenreRichTextBox_Enter(object sender, EventArgs e)
        {
            if (SMovieGenreRichTextBox.Text == placeholderText)
            {
                SMovieGenreRichTextBox.Text = "";
                SMovieGenreRichTextBox.ForeColor = Color.Black;
            }

        }

        private void SMovieGenreRichTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SMovieGenreRichTextBox.Text))
            {
                SMovieGenreRichTextBox.Text = placeholderText;
                SMovieGenreRichTextBox.ForeColor = Color.LightGray;
            }

        }

        private void SBookGenreRichTextBox_Enter(object sender, EventArgs e)
        {
            if (SBookGenreRichTextBox.Text == placeholderText)
            {
                SBookGenreRichTextBox.Text = "";
                SBookGenreRichTextBox.ForeColor = Color.Black;
            }
        }

        private void SBookGenreRichTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SBookGenreRichTextBox.Text))
            {
                SBookGenreRichTextBox.Text = placeholderText;
                SBookGenreRichTextBox.ForeColor = Color.LightGray;
            }
        }

        

        private void AddGenreMButton_Click(object sender, EventArgs e)
        {
            string genresText = SMovieGenreRichTextBox.Text;
            if (genresText == placeholderText || string.IsNullOrWhiteSpace(genresText))
            {
                MessageBox.Show("Please enter genres to add.");
                return;
            }

            string[] genres = genresText.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string genre in genres)
            {
                SQL.AddMovieGenre(genre.Trim());
            }
            LoadMovieGenres();
            SMovieGenreRichTextBox.Text = placeholderText;
            SMovieGenreRichTextBox.ForeColor = Color.LightGray;
        }

        private void AddGenreBButton_Click(object sender, EventArgs e)
        {
            string genresText = SBookGenreRichTextBox.Text;
            if (genresText == placeholderText || string.IsNullOrWhiteSpace(genresText))
            {
                MessageBox.Show("Please enter genres to add.");
                return;
            }

            string[] genres = genresText.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string genre in genres)
            {
                SQL.AddBookGenre(genre.Trim());
            }
            LoadBookGenres();
            SBookGenreRichTextBox.Text = placeholderText;
            SBookGenreRichTextBox.ForeColor = Color.LightGray;
        }

        private void DeleteGenreMButton_Click(object sender, EventArgs e)
        {
            foreach (string genre in GenreMCheckedListBox.CheckedItems)
            {
                SQL.DeleteMovieGenre(genre);
            }
            LoadMovieGenres();
        }

        private void DeleteGenreBButton_Click(object sender, EventArgs e)
        {
            foreach (string genre in GenreBCheckedListBox.CheckedItems)
            {
                SQL.DeleteBookGenre(genre);
            }
            LoadBookGenres();
        }
    }
}
