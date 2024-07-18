namespace DesktopJournelApp
{
    partial class ReadingListPageUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadingListPageUserControl));
            this.RListBooksButton = new System.Windows.Forms.Button();
            this.RLSaveButton = new System.Windows.Forms.Button();
            this.RLCommentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RLRatingTextBox = new System.Windows.Forms.TextBox();
            this.WatchListPMPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RLdataGridView = new System.Windows.Forms.DataGridView();
            this.booksTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelinDatabaseDataSet = new DesktopJournelApp.pelinDatabaseDataSet();
            this.MyReadingListTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.RLStateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RSearchTextBox = new System.Windows.Forms.TextBox();
            this.RLSearchButton = new System.Windows.Forms.Button();
            this.RLAuthorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RLNameTextBox = new System.Windows.Forms.TextBox();
            this.MovieTvSName = new System.Windows.Forms.Label();
            this.booksTableTableAdapter = new DesktopJournelApp.pelinDatabaseDataSetTableAdapters.BooksTableTableAdapter();
            this.WRUpdateButton = new System.Windows.Forms.Button();
            this.WRDeleteButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RLGenreComboBox = new System.Windows.Forms.ComboBox();
            this.WatchListPMPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelinDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RListBooksButton
            // 
            this.RListBooksButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.RListBooksButton.Location = new System.Drawing.Point(786, 533);
            this.RListBooksButton.Name = "RListBooksButton";
            this.RListBooksButton.Size = new System.Drawing.Size(129, 55);
            this.RListBooksButton.TabIndex = 5;
            this.RListBooksButton.Text = "List Books";
            this.RListBooksButton.UseVisualStyleBackColor = true;
            // 
            // RLSaveButton
            // 
            this.RLSaveButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.RLSaveButton.Location = new System.Drawing.Point(617, 497);
            this.RLSaveButton.Name = "RLSaveButton";
            this.RLSaveButton.Size = new System.Drawing.Size(124, 55);
            this.RLSaveButton.TabIndex = 16;
            this.RLSaveButton.Text = "Save";
            this.RLSaveButton.UseVisualStyleBackColor = true;
            // 
            // RLCommentsRichTextBox
            // 
            this.RLCommentsRichTextBox.Location = new System.Drawing.Point(166, 302);
            this.RLCommentsRichTextBox.Name = "RLCommentsRichTextBox";
            this.RLCommentsRichTextBox.Size = new System.Drawing.Size(586, 172);
            this.RLCommentsRichTextBox.TabIndex = 15;
            this.RLCommentsRichTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "My Comments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "/10";
            // 
            // RLRatingTextBox
            // 
            this.RLRatingTextBox.Font = new System.Drawing.Font("Footlight MT Light", 13.8F);
            this.RLRatingTextBox.Location = new System.Drawing.Point(138, 238);
            this.RLRatingTextBox.Name = "RLRatingTextBox";
            this.RLRatingTextBox.Size = new System.Drawing.Size(59, 32);
            this.RLRatingTextBox.TabIndex = 12;
            // 
            // WatchListPMPanel
            // 
            this.WatchListPMPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WatchListPMPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WatchListPMPanel.Controls.Add(this.pictureBox1);
            this.WatchListPMPanel.Controls.Add(this.RLdataGridView);
            this.WatchListPMPanel.Controls.Add(this.MyReadingListTitleLabel);
            this.WatchListPMPanel.Controls.Add(this.panel1);
            this.WatchListPMPanel.Controls.Add(this.RListBooksButton);
            this.WatchListPMPanel.Location = new System.Drawing.Point(3, 3);
            this.WatchListPMPanel.Name = "WatchListPMPanel";
            this.WatchListPMPanel.Size = new System.Drawing.Size(1834, 652);
            this.WatchListPMPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1653, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // RLdataGridView
            // 
            this.RLdataGridView.AutoGenerateColumns = false;
            this.RLdataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RLdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RLdataGridView.DataSource = this.booksTableBindingSource;
            this.RLdataGridView.Location = new System.Drawing.Point(786, 49);
            this.RLdataGridView.Name = "RLdataGridView";
            this.RLdataGridView.RowHeadersWidth = 51;
            this.RLdataGridView.RowTemplate.Height = 24;
            this.RLdataGridView.Size = new System.Drawing.Size(996, 464);
            this.RLdataGridView.TabIndex = 2;
            // 
            // booksTableBindingSource
            // 
            this.booksTableBindingSource.DataMember = "BooksTable";
            this.booksTableBindingSource.DataSource = this.pelinDatabaseDataSet;
            // 
            // pelinDatabaseDataSet
            // 
            this.pelinDatabaseDataSet.DataSetName = "pelinDatabaseDataSet";
            this.pelinDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MyReadingListTitleLabel
            // 
            this.MyReadingListTitleLabel.AutoSize = true;
            this.MyReadingListTitleLabel.Font = new System.Drawing.Font("Footlight MT Light", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyReadingListTitleLabel.Location = new System.Drawing.Point(21, 11);
            this.MyReadingListTitleLabel.Name = "MyReadingListTitleLabel";
            this.MyReadingListTitleLabel.Size = new System.Drawing.Size(229, 35);
            this.MyReadingListTitleLabel.TabIndex = 1;
            this.MyReadingListTitleLabel.Text = "My Reading List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RLGenreComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.WRDeleteButton);
            this.panel1.Controls.Add(this.WRUpdateButton);
            this.panel1.Controls.Add(this.RLSaveButton);
            this.panel1.Controls.Add(this.RLCommentsRichTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.RLRatingTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RLStateComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RSearchTextBox);
            this.panel1.Controls.Add(this.RLSearchButton);
            this.panel1.Controls.Add(this.RLAuthorTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RLNameTextBox);
            this.panel1.Controls.Add(this.MovieTvSName);
            this.panel1.Location = new System.Drawing.Point(5, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 571);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "My Rating";
            // 
            // RLStateComboBox
            // 
            this.RLStateComboBox.Font = new System.Drawing.Font("Footlight MT Light", 10.8F);
            this.RLStateComboBox.FormattingEnabled = true;
            this.RLStateComboBox.Items.AddRange(new object[] {
            "Want to start",
            "Currently reading",
            "Finished"});
            this.RLStateComboBox.Location = new System.Drawing.Point(139, 197);
            this.RLStateComboBox.Name = "RLStateComboBox";
            this.RLStateComboBox.Size = new System.Drawing.Size(259, 27);
            this.RLStateComboBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "State";
            // 
            // RSearchTextBox
            // 
            this.RSearchTextBox.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RSearchTextBox.Location = new System.Drawing.Point(9, 28);
            this.RSearchTextBox.Name = "RSearchTextBox";
            this.RSearchTextBox.Size = new System.Drawing.Size(604, 32);
            this.RSearchTextBox.TabIndex = 8;
            // 
            // RLSearchButton
            // 
            this.RLSearchButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.RLSearchButton.Location = new System.Drawing.Point(624, 25);
            this.RLSearchButton.Name = "RLSearchButton";
            this.RLSearchButton.Size = new System.Drawing.Size(128, 38);
            this.RLSearchButton.TabIndex = 7;
            this.RLSearchButton.Text = "Search";
            this.RLSearchButton.UseVisualStyleBackColor = true;
            // 
            // RLAuthorTextBox
            // 
            this.RLAuthorTextBox.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLAuthorTextBox.Location = new System.Drawing.Point(143, 140);
            this.RLAuthorTextBox.Name = "RLAuthorTextBox";
            this.RLAuthorTextBox.Size = new System.Drawing.Size(602, 32);
            this.RLAuthorTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Author";
            // 
            // RLNameTextBox
            // 
            this.RLNameTextBox.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLNameTextBox.Location = new System.Drawing.Point(198, 87);
            this.RLNameTextBox.Name = "RLNameTextBox";
            this.RLNameTextBox.Size = new System.Drawing.Size(548, 32);
            this.RLNameTextBox.TabIndex = 2;
            // 
            // MovieTvSName
            // 
            this.MovieTvSName.AutoSize = true;
            this.MovieTvSName.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTvSName.Location = new System.Drawing.Point(4, 94);
            this.MovieTvSName.Name = "MovieTvSName";
            this.MovieTvSName.Size = new System.Drawing.Size(177, 24);
            this.MovieTvSName.TabIndex = 0;
            this.MovieTvSName.Text = "Name of the book";
            // 
            // booksTableTableAdapter
            // 
            this.booksTableTableAdapter.ClearBeforeFill = true;
            // 
            // WRUpdateButton
            // 
            this.WRUpdateButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.WRUpdateButton.Location = new System.Drawing.Point(472, 497);
            this.WRUpdateButton.Name = "WRUpdateButton";
            this.WRUpdateButton.Size = new System.Drawing.Size(124, 55);
            this.WRUpdateButton.TabIndex = 20;
            this.WRUpdateButton.Text = "Update";
            this.WRUpdateButton.UseVisualStyleBackColor = true;
            // 
            // WRDeleteButton
            // 
            this.WRDeleteButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.WRDeleteButton.Location = new System.Drawing.Point(333, 497);
            this.WRDeleteButton.Name = "WRDeleteButton";
            this.WRDeleteButton.Size = new System.Drawing.Size(124, 55);
            this.WRDeleteButton.TabIndex = 21;
            this.WRDeleteButton.Text = "Delete";
            this.WRDeleteButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Genre";
            // 
            // RLGenreComboBox
            // 
            this.RLGenreComboBox.Font = new System.Drawing.Font("Footlight MT Light", 10.8F);
            this.RLGenreComboBox.FormattingEnabled = true;
            this.RLGenreComboBox.Items.AddRange(new object[] {
            "",
            "Fantasy",
            "",
            "Science Fiction",
            "",
            "Mystery",
            "",
            "Thriller",
            "",
            "Romance",
            "",
            "Historical Fiction",
            "",
            "Horror",
            "",
            "Young Adult",
            "",
            "Non-Fiction",
            "",
            "Biography",
            "",
            "Memoir",
            "",
            "Self-Help",
            "",
            "Graphic Novel",
            "",
            "Adventure",
            "",
            "Dystopian",
            "",
            "Crime",
            "",
            "Contemporary Fiction",
            "",
            "Paranormal",
            "",
            "Literary Fiction",
            "",
            "Children\'s Literature",
            "",
            "Classic Literature",
            "",
            "Poetry",
            "",
            "Anthology",
            "",
            "Short Stories"});
            this.RLGenreComboBox.Location = new System.Drawing.Point(583, 201);
            this.RLGenreComboBox.Name = "RLGenreComboBox";
            this.RLGenreComboBox.Size = new System.Drawing.Size(162, 27);
            this.RLGenreComboBox.TabIndex = 23;
            // 
            // ReadingListPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WatchListPMPanel);
            this.Name = "ReadingListPageUserControl";
            this.Size = new System.Drawing.Size(1873, 706);
            this.WatchListPMPanel.ResumeLayout(false);
            this.WatchListPMPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelinDatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RListBooksButton;
        private System.Windows.Forms.Button RLSaveButton;
        private System.Windows.Forms.RichTextBox RLCommentsRichTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RLRatingTextBox;
        private System.Windows.Forms.Panel WatchListPMPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView RLdataGridView;
        private System.Windows.Forms.Label MyReadingListTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RLStateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RSearchTextBox;
        private System.Windows.Forms.Button RLSearchButton;
        private System.Windows.Forms.TextBox RLAuthorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RLNameTextBox;
        private System.Windows.Forms.Label MovieTvSName;
        private System.Windows.Forms.BindingSource booksTableBindingSource;
        private pelinDatabaseDataSet pelinDatabaseDataSet;
        private pelinDatabaseDataSetTableAdapters.BooksTableTableAdapter booksTableTableAdapter;
        private System.Windows.Forms.Button WRUpdateButton;
        private System.Windows.Forms.Button WRDeleteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RLGenreComboBox;
    }
}
