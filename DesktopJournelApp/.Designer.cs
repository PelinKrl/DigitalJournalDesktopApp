namespace DesktopJournelApp
{
    partial class WatchListPageUserControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchListPageUserControl));
            this.WatchListPMPanel = new System.Windows.Forms.Panel();
            this.WLFilterByGenreButton = new System.Windows.Forms.Button();
            this.WLGenresButton = new System.Windows.Forms.Button();
            this.GenresCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WLListAllButton = new System.Windows.Forms.Button();
            this.WLdataGridView = new System.Windows.Forms.DataGridView();
            this.MyWatchListTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WLDeleteButton = new System.Windows.Forms.Button();
            this.WLUpdateButton = new System.Windows.Forms.Button();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WLSaveButton = new System.Windows.Forms.Button();
            this.WLCommentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WLRatingTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WLStateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WLSearchTextBox = new System.Windows.Forms.TextBox();
            this.WLSearch = new System.Windows.Forms.Button();
            this.WLDirectorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WLNameTextBox = new System.Windows.Forms.TextBox();
            this.WLTypeComboBox = new System.Windows.Forms.ComboBox();
            this.MovieTvSName = new System.Windows.Forms.Label();
            this.WLListMoviesButton = new System.Windows.Forms.Button();
            this.WLListTvShowsButton = new System.Windows.Forms.Button();
            this.watchTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelinDatabaseDataSet1 = new DesktopJournelApp.pelinDatabaseDataSet1();
            this.watchTableTableAdapter = new DesktopJournelApp.pelinDatabaseDataSet1TableAdapters.WatchTableTableAdapter();
            this.WatchListPMPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WLdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelinDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // WatchListPMPanel
            // 
            this.WatchListPMPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WatchListPMPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WatchListPMPanel.Controls.Add(this.WLFilterByGenreButton);
            this.WatchListPMPanel.Controls.Add(this.WLGenresButton);
            this.WatchListPMPanel.Controls.Add(this.GenresCheckedListBox);
            this.WatchListPMPanel.Controls.Add(this.pictureBox1);
            this.WatchListPMPanel.Controls.Add(this.WLListAllButton);
            this.WatchListPMPanel.Controls.Add(this.WLdataGridView);
            this.WatchListPMPanel.Controls.Add(this.MyWatchListTitleLabel);
            this.WatchListPMPanel.Controls.Add(this.panel1);
            this.WatchListPMPanel.Controls.Add(this.WLListMoviesButton);
            this.WatchListPMPanel.Controls.Add(this.WLListTvShowsButton);
            this.WatchListPMPanel.Location = new System.Drawing.Point(3, 3);
            this.WatchListPMPanel.Name = "WatchListPMPanel";
            this.WatchListPMPanel.Size = new System.Drawing.Size(1785, 682);
            this.WatchListPMPanel.TabIndex = 0;
            // 
            // WLFilterByGenreButton
            // 
            this.WLFilterByGenreButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.WLFilterByGenreButton.Location = new System.Drawing.Point(1496, 10);
            this.WLFilterByGenreButton.Name = "WLFilterByGenreButton";
            this.WLFilterByGenreButton.Size = new System.Drawing.Size(90, 39);
            this.WLFilterByGenreButton.TabIndex = 26;
            this.WLFilterByGenreButton.Text = "Filter";
            this.WLFilterByGenreButton.UseVisualStyleBackColor = true;
            this.WLFilterByGenreButton.Click += new System.EventHandler(this.WLFilterByGenreButton_Click);
            // 
            // WLGenresButton
            // 
            this.WLGenresButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.WLGenresButton.Location = new System.Drawing.Point(1592, 10);
            this.WLGenresButton.Name = "WLGenresButton";
            this.WLGenresButton.Size = new System.Drawing.Size(165, 39);
            this.WLGenresButton.TabIndex = 25;
            this.WLGenresButton.Text = "Genres";
            this.WLGenresButton.UseVisualStyleBackColor = true;
            this.WLGenresButton.Click += new System.EventHandler(this.WLGenresButton_Click);
            // 
            // GenresCheckedListBox
            // 
            this.GenresCheckedListBox.CheckOnClick = true;
            this.GenresCheckedListBox.FormattingEnabled = true;
            this.GenresCheckedListBox.Items.AddRange(new object[] {
            "Drama",
            "Comedy",
            "Action",
            "Thriller",
            "Science Fiction (Sci-Fi)",
            "Fantasy",
            "Mystery",
            "Romance",
            "Romantic Comedy",
            "Horror",
            "Documentary",
            "Crime",
            "Family",
            "Adventure",
            "Animated",
            "Historical",
            "Reality",
            "Talk Show",
            "Game Show",
            "Sitcom",
            "Musical",
            "War"});
            this.GenresCheckedListBox.Location = new System.Drawing.Point(1592, 55);
            this.GenresCheckedListBox.Name = "GenresCheckedListBox";
            this.GenresCheckedListBox.Size = new System.Drawing.Size(165, 378);
            this.GenresCheckedListBox.TabIndex = 24;
            this.GenresCheckedListBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1632, 534);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // WLListAllButton
            // 
            this.WLListAllButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.WLListAllButton.Location = new System.Drawing.Point(1082, 534);
            this.WLListAllButton.Name = "WLListAllButton";
            this.WLListAllButton.Size = new System.Drawing.Size(115, 55);
            this.WLListAllButton.TabIndex = 17;
            this.WLListAllButton.Text = "List All";
            this.WLListAllButton.UseVisualStyleBackColor = true;
            this.WLListAllButton.Click += new System.EventHandler(this.WLListAllButton_Click);
            // 
            // WLdataGridView
            // 
            this.WLdataGridView.AllowUserToAddRows = false;
            this.WLdataGridView.AllowUserToDeleteRows = false;
            this.WLdataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.WLdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WLdataGridView.Location = new System.Drawing.Point(789, 53);
            this.WLdataGridView.Name = "WLdataGridView";
            this.WLdataGridView.ReadOnly = true;
            this.WLdataGridView.RowHeadersWidth = 51;
            this.WLdataGridView.RowTemplate.Height = 24;
            this.WLdataGridView.Size = new System.Drawing.Size(968, 464);
            this.WLdataGridView.TabIndex = 2;
            this.WLdataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.WLdataGridView_RowHeaderMouseClick);
            // 
            // MyWatchListTitleLabel
            // 
            this.MyWatchListTitleLabel.AutoSize = true;
            this.MyWatchListTitleLabel.Font = new System.Drawing.Font("Footlight MT Light", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWatchListTitleLabel.Location = new System.Drawing.Point(22, 14);
            this.MyWatchListTitleLabel.Name = "MyWatchListTitleLabel";
            this.MyWatchListTitleLabel.Size = new System.Drawing.Size(211, 35);
            this.MyWatchListTitleLabel.TabIndex = 1;
            this.MyWatchListTitleLabel.Text = "My Watch List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WLDeleteButton);
            this.panel1.Controls.Add(this.WLUpdateButton);
            this.panel1.Controls.Add(this.GenreComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.WLSaveButton);
            this.panel1.Controls.Add(this.WLCommentsRichTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.WLRatingTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.WLStateComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.WLSearchTextBox);
            this.panel1.Controls.Add(this.WLSearch);
            this.panel1.Controls.Add(this.WLDirectorTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.WLNameTextBox);
            this.panel1.Controls.Add(this.WLTypeComboBox);
            this.panel1.Controls.Add(this.MovieTvSName);
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 567);
            this.panel1.TabIndex = 0;
            // 
            // WLDeleteButton
            // 
            this.WLDeleteButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.WLDeleteButton.Location = new System.Drawing.Point(475, 497);
            this.WLDeleteButton.Name = "WLDeleteButton";
            this.WLDeleteButton.Size = new System.Drawing.Size(124, 55);
            this.WLDeleteButton.TabIndex = 20;
            this.WLDeleteButton.Text = "Delete";
            this.WLDeleteButton.UseVisualStyleBackColor = true;
            this.WLDeleteButton.Click += new System.EventHandler(this.WLDeleteButton_Click);
            // 
            // WLUpdateButton
            // 
            this.WLUpdateButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.WLUpdateButton.Location = new System.Drawing.Point(331, 497);
            this.WLUpdateButton.Name = "WLUpdateButton";
            this.WLUpdateButton.Size = new System.Drawing.Size(124, 55);
            this.WLUpdateButton.TabIndex = 19;
            this.WLUpdateButton.Text = "Update";
            this.WLUpdateButton.UseVisualStyleBackColor = true;
            this.WLUpdateButton.Click += new System.EventHandler(this.WLUpdateButton_Click);
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.Font = new System.Drawing.Font("Footlight MT Light", 10.8F);
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Items.AddRange(new object[] {
            "Drama",
            "Comedy",
            "Action",
            "Thriller",
            "Science Fiction (Sci-Fi)",
            "Fantasy",
            "Mystery",
            "Romance",
            "Romantic Comedy",
            "Horror",
            "Documentary",
            "Crime",
            "Family",
            "Adventure",
            "Animated",
            "Historical",
            "Reality",
            "Talk Show",
            "Game Show",
            "Sitcom",
            "Musical",
            "War"});
            this.GenreComboBox.Location = new System.Drawing.Point(544, 199);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(133, 27);
            this.GenreComboBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Genre";
            // 
            // WLSaveButton
            // 
            this.WLSaveButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.WLSaveButton.Location = new System.Drawing.Point(617, 497);
            this.WLSaveButton.Name = "WLSaveButton";
            this.WLSaveButton.Size = new System.Drawing.Size(124, 55);
            this.WLSaveButton.TabIndex = 16;
            this.WLSaveButton.Text = "Save";
            this.WLSaveButton.UseVisualStyleBackColor = true;
            this.WLSaveButton.Click += new System.EventHandler(this.WLSaveButton_Click);
            // 
            // WLCommentsRichTextBox
            // 
            this.WLCommentsRichTextBox.Location = new System.Drawing.Point(165, 302);
            this.WLCommentsRichTextBox.Name = "WLCommentsRichTextBox";
            this.WLCommentsRichTextBox.Size = new System.Drawing.Size(586, 172);
            this.WLCommentsRichTextBox.TabIndex = 15;
            this.WLCommentsRichTextBox.Text = "";
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
            // WLRatingTextBox
            // 
            this.WLRatingTextBox.Font = new System.Drawing.Font("Footlight MT Light", 13.8F);
            this.WLRatingTextBox.Location = new System.Drawing.Point(138, 238);
            this.WLRatingTextBox.Name = "WLRatingTextBox";
            this.WLRatingTextBox.Size = new System.Drawing.Size(59, 32);
            this.WLRatingTextBox.TabIndex = 12;
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
            // WLStateComboBox
            // 
            this.WLStateComboBox.Font = new System.Drawing.Font("Footlight MT Light", 10.8F);
            this.WLStateComboBox.FormattingEnabled = true;
            this.WLStateComboBox.Items.AddRange(new object[] {
            "Want to watch",
            "Currently watching",
            "Watched"});
            this.WLStateComboBox.Location = new System.Drawing.Point(139, 197);
            this.WLStateComboBox.Name = "WLStateComboBox";
            this.WLStateComboBox.Size = new System.Drawing.Size(259, 27);
            this.WLStateComboBox.TabIndex = 10;
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
            // WLSearchTextBox
            // 
            this.WLSearchTextBox.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLSearchTextBox.Location = new System.Drawing.Point(11, 28);
            this.WLSearchTextBox.Name = "WLSearchTextBox";
            this.WLSearchTextBox.Size = new System.Drawing.Size(613, 32);
            this.WLSearchTextBox.TabIndex = 8;
            // 
            // WLSearch
            // 
            this.WLSearch.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.WLSearch.Location = new System.Drawing.Point(642, 25);
            this.WLSearch.Name = "WLSearch";
            this.WLSearch.Size = new System.Drawing.Size(105, 38);
            this.WLSearch.TabIndex = 7;
            this.WLSearch.Text = "Search";
            this.WLSearch.UseVisualStyleBackColor = true;
            this.WLSearch.Click += new System.EventHandler(this.WLSearch_Click);
            // 
            // WLDirectorTextBox
            // 
            this.WLDirectorTextBox.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLDirectorTextBox.Location = new System.Drawing.Point(143, 140);
            this.WLDirectorTextBox.Name = "WLDirectorTextBox";
            this.WLDirectorTextBox.Size = new System.Drawing.Size(602, 32);
            this.WLDirectorTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Director";
            // 
            // WLNameTextBox
            // 
            this.WLNameTextBox.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLNameTextBox.Location = new System.Drawing.Point(285, 87);
            this.WLNameTextBox.Name = "WLNameTextBox";
            this.WLNameTextBox.Size = new System.Drawing.Size(461, 32);
            this.WLNameTextBox.TabIndex = 2;
            // 
            // WLTypeComboBox
            // 
            this.WLTypeComboBox.Font = new System.Drawing.Font("Footlight MT Light", 10.8F);
            this.WLTypeComboBox.FormattingEnabled = true;
            this.WLTypeComboBox.Items.AddRange(new object[] {
            "Movie",
            "TV Show"});
            this.WLTypeComboBox.Location = new System.Drawing.Point(143, 90);
            this.WLTypeComboBox.Name = "WLTypeComboBox";
            this.WLTypeComboBox.Size = new System.Drawing.Size(133, 27);
            this.WLTypeComboBox.TabIndex = 1;
            // 
            // MovieTvSName
            // 
            this.MovieTvSName.AutoSize = true;
            this.MovieTvSName.Font = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTvSName.Location = new System.Drawing.Point(4, 94);
            this.MovieTvSName.Name = "MovieTvSName";
            this.MovieTvSName.Size = new System.Drawing.Size(131, 24);
            this.MovieTvSName.TabIndex = 0;
            this.MovieTvSName.Text = "Name of the ";
            // 
            // WLListMoviesButton
            // 
            this.WLListMoviesButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.WLListMoviesButton.Location = new System.Drawing.Point(789, 534);
            this.WLListMoviesButton.Name = "WLListMoviesButton";
            this.WLListMoviesButton.Size = new System.Drawing.Size(127, 55);
            this.WLListMoviesButton.TabIndex = 5;
            this.WLListMoviesButton.Text = "List Movies";
            this.WLListMoviesButton.UseVisualStyleBackColor = true;
            this.WLListMoviesButton.Click += new System.EventHandler(this.WLListMoviesButton_Click);
            // 
            // WLListTvShowsButton
            // 
            this.WLListTvShowsButton.Font = new System.Drawing.Font("Footlight MT Light", 11.8F);
            this.WLListTvShowsButton.Location = new System.Drawing.Point(937, 534);
            this.WLListTvShowsButton.Name = "WLListTvShowsButton";
            this.WLListTvShowsButton.Size = new System.Drawing.Size(128, 55);
            this.WLListTvShowsButton.TabIndex = 6;
            this.WLListTvShowsButton.Text = "List TV Shows";
            this.WLListTvShowsButton.UseVisualStyleBackColor = true;
            this.WLListTvShowsButton.Click += new System.EventHandler(this.WLListTvShowsButton_Click);
            // 
            // watchTableBindingSource
            // 
            this.watchTableBindingSource.DataMember = "WatchTable";
            this.watchTableBindingSource.DataSource = this.pelinDatabaseDataSet1;
            // 
            // pelinDatabaseDataSet1
            // 
            this.pelinDatabaseDataSet1.DataSetName = "pelinDatabaseDataSet1";
            this.pelinDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // watchTableTableAdapter
            // 
            this.watchTableTableAdapter.ClearBeforeFill = true;
            // 
            // WatchListPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WatchListPMPanel);
            this.Name = "WatchListPageUserControl";
            this.Size = new System.Drawing.Size(1846, 762);
            this.WatchListPMPanel.ResumeLayout(false);
            this.WatchListPMPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WLdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelinDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WatchListPMPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MovieTvSName;
        private System.Windows.Forms.TextBox WLNameTextBox;
        private System.Windows.Forms.ComboBox WLTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WLListTvShowsButton;
        private System.Windows.Forms.Button WLListMoviesButton;
        private System.Windows.Forms.TextBox WLDirectorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox WLStateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WLSearchTextBox;
        private System.Windows.Forms.Button WLSearch;
        private System.Windows.Forms.TextBox WLRatingTextBox;
        private System.Windows.Forms.Label MyWatchListTitleLabel;
        private System.Windows.Forms.Button WLSaveButton;
        private System.Windows.Forms.RichTextBox WLCommentsRichTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button WLListAllButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource watchTableBindingSource;
        private pelinDatabaseDataSet1 pelinDatabaseDataSet1;
        private pelinDatabaseDataSet1TableAdapters.WatchTableTableAdapter watchTableTableAdapter;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button WLUpdateButton;
        private System.Windows.Forms.Button WLDeleteButton;
        public System.Windows.Forms.DataGridView WLdataGridView;
        private System.Windows.Forms.CheckedListBox GenresCheckedListBox;
        private System.Windows.Forms.Button WLGenresButton;
        private System.Windows.Forms.Button WLFilterByGenreButton;
    }
}
