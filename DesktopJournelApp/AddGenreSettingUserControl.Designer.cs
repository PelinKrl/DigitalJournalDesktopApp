namespace DesktopJournelApp
{
    partial class AddGenreSettingUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenreSettingPanel = new System.Windows.Forms.Panel();
            this.DeleteGenreBButton = new System.Windows.Forms.Button();
            this.DeleteGenreMButton = new System.Windows.Forms.Button();
            this.GenreBCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.GenreMCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddGenreMButton = new System.Windows.Forms.Button();
            this.AddGenreBButton = new System.Windows.Forms.Button();
            this.SBookGenreRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SMovieGenreRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BookGenreLabel = new System.Windows.Forms.Label();
            this.MovieGenreLabel = new System.Windows.Forms.Label();
            this.GenreSettingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenreSettingPanel
            // 
            this.GenreSettingPanel.BackColor = System.Drawing.Color.Transparent;
            this.GenreSettingPanel.Controls.Add(this.DeleteGenreBButton);
            this.GenreSettingPanel.Controls.Add(this.DeleteGenreMButton);
            this.GenreSettingPanel.Controls.Add(this.GenreBCheckedListBox);
            this.GenreSettingPanel.Controls.Add(this.GenreMCheckedListBox);
            this.GenreSettingPanel.Controls.Add(this.label2);
            this.GenreSettingPanel.Controls.Add(this.label1);
            this.GenreSettingPanel.Controls.Add(this.AddGenreMButton);
            this.GenreSettingPanel.Controls.Add(this.AddGenreBButton);
            this.GenreSettingPanel.Controls.Add(this.SBookGenreRichTextBox);
            this.GenreSettingPanel.Controls.Add(this.SMovieGenreRichTextBox);
            this.GenreSettingPanel.Controls.Add(this.BookGenreLabel);
            this.GenreSettingPanel.Controls.Add(this.MovieGenreLabel);
            this.GenreSettingPanel.Location = new System.Drawing.Point(3, 3);
            this.GenreSettingPanel.Name = "GenreSettingPanel";
            this.GenreSettingPanel.Size = new System.Drawing.Size(724, 522);
            this.GenreSettingPanel.TabIndex = 0;
            // 
            // DeleteGenreBButton
            // 
            this.DeleteGenreBButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteGenreBButton.Location = new System.Drawing.Point(515, 450);
            this.DeleteGenreBButton.Name = "DeleteGenreBButton";
            this.DeleteGenreBButton.Size = new System.Drawing.Size(146, 34);
            this.DeleteGenreBButton.TabIndex = 12;
            this.DeleteGenreBButton.Text = "Delete Genre";
            this.DeleteGenreBButton.UseVisualStyleBackColor = true;
            this.DeleteGenreBButton.Click += new System.EventHandler(this.DeleteGenreBButton_Click);
            // 
            // DeleteGenreMButton
            // 
            this.DeleteGenreMButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteGenreMButton.Location = new System.Drawing.Point(515, 218);
            this.DeleteGenreMButton.Name = "DeleteGenreMButton";
            this.DeleteGenreMButton.Size = new System.Drawing.Size(146, 33);
            this.DeleteGenreMButton.TabIndex = 11;
            this.DeleteGenreMButton.Text = "Delete Genre";
            this.DeleteGenreMButton.UseVisualStyleBackColor = true;
            this.DeleteGenreMButton.Click += new System.EventHandler(this.DeleteGenreMButton_Click);
            // 
            // GenreBCheckedListBox
            // 
            this.GenreBCheckedListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreBCheckedListBox.FormattingEnabled = true;
            this.GenreBCheckedListBox.Location = new System.Drawing.Point(414, 325);
            this.GenreBCheckedListBox.Name = "GenreBCheckedListBox";
            this.GenreBCheckedListBox.Size = new System.Drawing.Size(247, 118);
            this.GenreBCheckedListBox.TabIndex = 10;
            // 
            // GenreMCheckedListBox
            // 
            this.GenreMCheckedListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreMCheckedListBox.FormattingEnabled = true;
            this.GenreMCheckedListBox.Location = new System.Drawing.Point(414, 94);
            this.GenreMCheckedListBox.Name = "GenreMCheckedListBox";
            this.GenreMCheckedListBox.Size = new System.Drawing.Size(247, 118);
            this.GenreMCheckedListBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delete Genre \r\nFor Books";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delete Genre For \r\nMovies/Tv Shows";
            // 
            // AddGenreMButton
            // 
            this.AddGenreMButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGenreMButton.Location = new System.Drawing.Point(136, 218);
            this.AddGenreMButton.Name = "AddGenreMButton";
            this.AddGenreMButton.Size = new System.Drawing.Size(119, 34);
            this.AddGenreMButton.TabIndex = 6;
            this.AddGenreMButton.Text = "Add Genre";
            this.AddGenreMButton.UseVisualStyleBackColor = true;
            this.AddGenreMButton.Click += new System.EventHandler(this.AddGenreMButton_Click);
            // 
            // AddGenreBButton
            // 
            this.AddGenreBButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGenreBButton.Location = new System.Drawing.Point(135, 450);
            this.AddGenreBButton.Name = "AddGenreBButton";
            this.AddGenreBButton.Size = new System.Drawing.Size(119, 34);
            this.AddGenreBButton.TabIndex = 5;
            this.AddGenreBButton.Text = "Add Genre";
            this.AddGenreBButton.UseVisualStyleBackColor = true;
            this.AddGenreBButton.Click += new System.EventHandler(this.AddGenreBButton_Click);
            // 
            // SBookGenreRichTextBox
            // 
            this.SBookGenreRichTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBookGenreRichTextBox.ForeColor = System.Drawing.Color.Silver;
            this.SBookGenreRichTextBox.Location = new System.Drawing.Point(37, 325);
            this.SBookGenreRichTextBox.Name = "SBookGenreRichTextBox";
            this.SBookGenreRichTextBox.Size = new System.Drawing.Size(218, 119);
            this.SBookGenreRichTextBox.TabIndex = 3;
            this.SBookGenreRichTextBox.Text = "You can add multiple genres line by line.";
            this.SBookGenreRichTextBox.Enter += new System.EventHandler(this.SBookGenreRichTextBox_Enter);
            this.SBookGenreRichTextBox.Leave += new System.EventHandler(this.SBookGenreRichTextBox_Leave);
            // 
            // SMovieGenreRichTextBox
            // 
            this.SMovieGenreRichTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMovieGenreRichTextBox.ForeColor = System.Drawing.Color.Silver;
            this.SMovieGenreRichTextBox.Location = new System.Drawing.Point(38, 93);
            this.SMovieGenreRichTextBox.Name = "SMovieGenreRichTextBox";
            this.SMovieGenreRichTextBox.Size = new System.Drawing.Size(217, 119);
            this.SMovieGenreRichTextBox.TabIndex = 2;
            this.SMovieGenreRichTextBox.Text = "You can add multiple genres line by line.";
            this.SMovieGenreRichTextBox.Enter += new System.EventHandler(this.SMovieGenreRichTextBox_Enter);
            this.SMovieGenreRichTextBox.Leave += new System.EventHandler(this.SMovieGenreRichTextBox_Leave);
            // 
            // BookGenreLabel
            // 
            this.BookGenreLabel.AutoSize = true;
            this.BookGenreLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookGenreLabel.Location = new System.Drawing.Point(32, 297);
            this.BookGenreLabel.Name = "BookGenreLabel";
            this.BookGenreLabel.Size = new System.Drawing.Size(238, 23);
            this.BookGenreLabel.TabIndex = 1;
            this.BookGenreLabel.Text = "Add Genre For Books";
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieGenreLabel.Location = new System.Drawing.Point(33, 22);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(190, 46);
            this.MovieGenreLabel.TabIndex = 0;
            this.MovieGenreLabel.Text = "Add Genre For \r\nMovies/Tv Shows\r\n";
            // 
            // AddGenreSettingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenreSettingPanel);
            this.Name = "AddGenreSettingUserControl";
            this.Size = new System.Drawing.Size(730, 528);
            this.GenreSettingPanel.ResumeLayout(false);
            this.GenreSettingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GenreSettingPanel;
        private System.Windows.Forms.Label BookGenreLabel;
        private System.Windows.Forms.Label MovieGenreLabel;
        private System.Windows.Forms.RichTextBox SBookGenreRichTextBox;
        private System.Windows.Forms.RichTextBox SMovieGenreRichTextBox;
        private System.Windows.Forms.Button AddGenreBButton;
        private System.Windows.Forms.Button AddGenreMButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteGenreBButton;
        private System.Windows.Forms.Button DeleteGenreMButton;
        private System.Windows.Forms.CheckedListBox GenreBCheckedListBox;
        private System.Windows.Forms.CheckedListBox GenreMCheckedListBox;
    }
}
