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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.WLListStateButton = new System.Windows.Forms.Button();
            this.WLStateFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WLFilterByGenreButton = new System.Windows.Forms.Button();
            this.WLGenresButton = new System.Windows.Forms.Button();
            this.GenresCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.WLListAllButton = new System.Windows.Forms.Button();
            this.WLdataGridView = new System.Windows.Forms.DataGridView();
            this.MyWatchListTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.watchTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelinDatabaseDataSet1 = new DesktopJournelApp.pelinDatabaseDataSet1();
            this.watchTableTableAdapter = new DesktopJournelApp.pelinDatabaseDataSet1TableAdapters.WatchTableTableAdapter();
            this.WatchListPMPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WLdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelinDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // WatchListPMPanel
            // 
            this.WatchListPMPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WatchListPMPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WatchListPMPanel.Controls.Add(this.pictureBox2);
            this.WatchListPMPanel.Controls.Add(this.WLListStateButton);
            this.WatchListPMPanel.Controls.Add(this.WLStateFilterComboBox);
            this.WatchListPMPanel.Controls.Add(this.label7);
            this.WatchListPMPanel.Controls.Add(this.WLFilterByGenreButton);
            this.WatchListPMPanel.Controls.Add(this.WLGenresButton);
            this.WatchListPMPanel.Controls.Add(this.GenresCheckedListBox);
            this.WatchListPMPanel.Controls.Add(this.WLListAllButton);
            this.WatchListPMPanel.Controls.Add(this.WLdataGridView);
            this.WatchListPMPanel.Controls.Add(this.MyWatchListTitleLabel);
            this.WatchListPMPanel.Controls.Add(this.panel1);
            this.WatchListPMPanel.Controls.Add(this.WLListMoviesButton);
            this.WatchListPMPanel.Controls.Add(this.WLListTvShowsButton);
            this.WatchListPMPanel.Controls.Add(this.pictureBox1);
            this.WatchListPMPanel.Location = new System.Drawing.Point(3, 2);
            this.WatchListPMPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WatchListPMPanel.Name = "WatchListPMPanel";
            this.WatchListPMPanel.Size = new System.Drawing.Size(1824, 682);
            this.WatchListPMPanel.TabIndex = 0;
            this.WatchListPMPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WatchListPMPanel_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1767, 633);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 25);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // WLListStateButton
            // 
            this.WLListStateButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLListStateButton.Location = new System.Drawing.Point(1120, 14);
            this.WLListStateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLListStateButton.Name = "WLListStateButton";
            this.WLListStateButton.Size = new System.Drawing.Size(115, 31);
            this.WLListStateButton.TabIndex = 29;
            this.WLListStateButton.Text = "List State";
            this.WLListStateButton.UseVisualStyleBackColor = true;
            this.WLListStateButton.Click += new System.EventHandler(this.WLListStateButton_Click);
            // 
            // WLStateFilterComboBox
            // 
            this.WLStateFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WLStateFilterComboBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLStateFilterComboBox.FormattingEnabled = true;
            this.WLStateFilterComboBox.Items.AddRange(new object[] {
            "Want to watch",
            "Currently watching",
            "Watched"});
            this.WLStateFilterComboBox.Location = new System.Drawing.Point(937, 16);
            this.WLStateFilterComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLStateFilterComboBox.Name = "WLStateFilterComboBox";
            this.WLStateFilterComboBox.Size = new System.Drawing.Size(165, 28);
            this.WLStateFilterComboBox.TabIndex = 28;
            this.WLStateFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.WLStateFilterComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(762, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Choose State";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // WLFilterByGenreButton
            // 
            this.WLFilterByGenreButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLFilterByGenreButton.Location = new System.Drawing.Point(1465, 9);
            this.WLFilterByGenreButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLFilterByGenreButton.Name = "WLFilterByGenreButton";
            this.WLFilterByGenreButton.Size = new System.Drawing.Size(91, 39);
            this.WLFilterByGenreButton.TabIndex = 26;
            this.WLFilterByGenreButton.Text = "Filter";
            this.WLFilterByGenreButton.UseVisualStyleBackColor = true;
            this.WLFilterByGenreButton.Click += new System.EventHandler(this.WLFilterByGenreButton_Click);
            // 
            // WLGenresButton
            // 
            this.WLGenresButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLGenresButton.Location = new System.Drawing.Point(1562, 9);
            this.WLGenresButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLGenresButton.Name = "WLGenresButton";
            this.WLGenresButton.Size = new System.Drawing.Size(239, 39);
            this.WLGenresButton.TabIndex = 25;
            this.WLGenresButton.Text = "Genres";
            this.WLGenresButton.UseVisualStyleBackColor = true;
            this.WLGenresButton.Click += new System.EventHandler(this.WLGenresButton_Click);
            // 
            // GenresCheckedListBox
            // 
            this.GenresCheckedListBox.CheckOnClick = true;
            this.GenresCheckedListBox.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.GenresCheckedListBox.Location = new System.Drawing.Point(1562, 55);
            this.GenresCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenresCheckedListBox.Name = "GenresCheckedListBox";
            this.GenresCheckedListBox.Size = new System.Drawing.Size(238, 361);
            this.GenresCheckedListBox.TabIndex = 24;
            this.GenresCheckedListBox.Visible = false;
            this.GenresCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.GenresCheckedListBox_SelectedIndexChanged);
            // 
            // WLListAllButton
            // 
            this.WLListAllButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLListAllButton.Location = new System.Drawing.Point(1083, 534);
            this.WLListAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.WLdataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLdataGridView.Name = "WLdataGridView";
            this.WLdataGridView.ReadOnly = true;
            this.WLdataGridView.RowHeadersWidth = 51;
            this.WLdataGridView.RowTemplate.Height = 24;
            this.WLdataGridView.Size = new System.Drawing.Size(1013, 464);
            this.WLdataGridView.TabIndex = 2;
            this.WLdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WLdataGridView_CellContentClick);
            this.WLdataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.WLdataGridView_RowHeaderMouseClick);
            // 
            // MyWatchListTitleLabel
            // 
            this.MyWatchListTitleLabel.AutoSize = true;
            this.MyWatchListTitleLabel.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWatchListTitleLabel.Location = new System.Drawing.Point(9, 14);
            this.MyWatchListTitleLabel.Name = "MyWatchListTitleLabel";
            this.MyWatchListTitleLabel.Size = new System.Drawing.Size(277, 37);
            this.MyWatchListTitleLabel.TabIndex = 1;
            this.MyWatchListTitleLabel.Text = "My Watch List";
            this.MyWatchListTitleLabel.Click += new System.EventHandler(this.MyWatchListTitleLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchComboBox);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 567);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchComboBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            "Movie Name",
            "Tv Show Name",
            "Director Name"});
            this.SearchComboBox.Location = new System.Drawing.Point(9, 28);
            this.SearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(173, 30);
            this.SearchComboBox.TabIndex = 21;
            this.SearchComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchComboBox_SelectedIndexChanged);
            // 
            // WLDeleteButton
            // 
            this.WLDeleteButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLDeleteButton.Location = new System.Drawing.Point(370, 497);
            this.WLDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLDeleteButton.Name = "WLDeleteButton";
            this.WLDeleteButton.Size = new System.Drawing.Size(124, 55);
            this.WLDeleteButton.TabIndex = 20;
            this.WLDeleteButton.Text = "Delete";
            this.WLDeleteButton.UseVisualStyleBackColor = true;
            this.WLDeleteButton.Click += new System.EventHandler(this.WLDeleteButton_Click);
            // 
            // WLUpdateButton
            // 
            this.WLUpdateButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLUpdateButton.Location = new System.Drawing.Point(500, 497);
            this.WLUpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLUpdateButton.Name = "WLUpdateButton";
            this.WLUpdateButton.Size = new System.Drawing.Size(124, 55);
            this.WLUpdateButton.TabIndex = 19;
            this.WLUpdateButton.Text = "Update";
            this.WLUpdateButton.UseVisualStyleBackColor = true;
            this.WLUpdateButton.Click += new System.EventHandler(this.WLUpdateButton_Click);
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(585, 197);
            this.GenreComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(166, 28);
            this.GenreComboBox.TabIndex = 18;
            this.GenreComboBox.SelectedIndexChanged += new System.EventHandler(this.GenreComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Genre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // WLSaveButton
            // 
            this.WLSaveButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLSaveButton.Location = new System.Drawing.Point(631, 497);
            this.WLSaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLSaveButton.Name = "WLSaveButton";
            this.WLSaveButton.Size = new System.Drawing.Size(124, 55);
            this.WLSaveButton.TabIndex = 16;
            this.WLSaveButton.Text = "Save";
            this.WLSaveButton.UseVisualStyleBackColor = true;
            this.WLSaveButton.Click += new System.EventHandler(this.WLSaveButton_Click);
            // 
            // WLCommentsRichTextBox
            // 
            this.WLCommentsRichTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLCommentsRichTextBox.Location = new System.Drawing.Point(178, 302);
            this.WLCommentsRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLCommentsRichTextBox.Name = "WLCommentsRichTextBox";
            this.WLCommentsRichTextBox.Size = new System.Drawing.Size(579, 171);
            this.WLCommentsRichTextBox.TabIndex = 15;
            this.WLCommentsRichTextBox.Text = "";
            this.WLCommentsRichTextBox.TextChanged += new System.EventHandler(this.WLCommentsRichTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "My Comments";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "/10";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // WLRatingTextBox
            // 
            this.WLRatingTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLRatingTextBox.Location = new System.Drawing.Point(162, 242);
            this.WLRatingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLRatingTextBox.Name = "WLRatingTextBox";
            this.WLRatingTextBox.Size = new System.Drawing.Size(53, 30);
            this.WLRatingTextBox.TabIndex = 12;
            this.WLRatingTextBox.TextChanged += new System.EventHandler(this.WLRatingTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "My Rating";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // WLStateComboBox
            // 
            this.WLStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WLStateComboBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLStateComboBox.FormattingEnabled = true;
            this.WLStateComboBox.Items.AddRange(new object[] {
            "Want to watch",
            "Currently watching",
            "Watched"});
            this.WLStateComboBox.Location = new System.Drawing.Point(162, 196);
            this.WLStateComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLStateComboBox.Name = "WLStateComboBox";
            this.WLStateComboBox.Size = new System.Drawing.Size(253, 30);
            this.WLStateComboBox.TabIndex = 10;
            this.WLStateComboBox.SelectedIndexChanged += new System.EventHandler(this.WLStateComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "State";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // WLSearchTextBox
            // 
            this.WLSearchTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLSearchTextBox.Location = new System.Drawing.Point(206, 28);
            this.WLSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLSearchTextBox.Name = "WLSearchTextBox";
            this.WLSearchTextBox.Size = new System.Drawing.Size(418, 30);
            this.WLSearchTextBox.TabIndex = 8;
            this.WLSearchTextBox.TextChanged += new System.EventHandler(this.WLSearchTextBox_TextChanged);
            // 
            // WLSearch
            // 
            this.WLSearch.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLSearch.Location = new System.Drawing.Point(643, 25);
            this.WLSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLSearch.Name = "WLSearch";
            this.WLSearch.Size = new System.Drawing.Size(105, 38);
            this.WLSearch.TabIndex = 7;
            this.WLSearch.Text = "Search";
            this.WLSearch.UseVisualStyleBackColor = true;
            this.WLSearch.Click += new System.EventHandler(this.WLSearch_Click);
            // 
            // WLDirectorTextBox
            // 
            this.WLDirectorTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLDirectorTextBox.Location = new System.Drawing.Point(165, 140);
            this.WLDirectorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLDirectorTextBox.Name = "WLDirectorTextBox";
            this.WLDirectorTextBox.Size = new System.Drawing.Size(586, 30);
            this.WLDirectorTextBox.TabIndex = 4;
            this.WLDirectorTextBox.TextChanged += new System.EventHandler(this.WLDirectorTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Director";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // WLNameTextBox
            // 
            this.WLNameTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLNameTextBox.Location = new System.Drawing.Point(300, 87);
            this.WLNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLNameTextBox.Name = "WLNameTextBox";
            this.WLNameTextBox.Size = new System.Drawing.Size(455, 30);
            this.WLNameTextBox.TabIndex = 2;
            this.WLNameTextBox.TextChanged += new System.EventHandler(this.WLNameTextBox_TextChanged);
            // 
            // WLTypeComboBox
            // 
            this.WLTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WLTypeComboBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLTypeComboBox.FormattingEnabled = true;
            this.WLTypeComboBox.Items.AddRange(new object[] {
            "Movie",
            "TV Show"});
            this.WLTypeComboBox.Location = new System.Drawing.Point(164, 87);
            this.WLTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLTypeComboBox.Name = "WLTypeComboBox";
            this.WLTypeComboBox.Size = new System.Drawing.Size(127, 28);
            this.WLTypeComboBox.TabIndex = 1;
            this.WLTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.WLTypeComboBox_SelectedIndexChanged);
            // 
            // MovieTvSName
            // 
            this.MovieTvSName.AutoSize = true;
            this.MovieTvSName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTvSName.Location = new System.Drawing.Point(4, 94);
            this.MovieTvSName.Name = "MovieTvSName";
            this.MovieTvSName.Size = new System.Drawing.Size(154, 22);
            this.MovieTvSName.TabIndex = 0;
            this.MovieTvSName.Text = "Name of the ";
            this.MovieTvSName.Click += new System.EventHandler(this.MovieTvSName_Click);
            // 
            // WLListMoviesButton
            // 
            this.WLListMoviesButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLListMoviesButton.Location = new System.Drawing.Point(789, 534);
            this.WLListMoviesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLListMoviesButton.Name = "WLListMoviesButton";
            this.WLListMoviesButton.Size = new System.Drawing.Size(127, 55);
            this.WLListMoviesButton.TabIndex = 5;
            this.WLListMoviesButton.Text = "List Movies";
            this.WLListMoviesButton.UseVisualStyleBackColor = true;
            this.WLListMoviesButton.Click += new System.EventHandler(this.WLListMoviesButton_Click);
            // 
            // WLListTvShowsButton
            // 
            this.WLListTvShowsButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLListTvShowsButton.Location = new System.Drawing.Point(937, 534);
            this.WLListTvShowsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WLListTvShowsButton.Name = "WLListTvShowsButton";
            this.WLListTvShowsButton.Size = new System.Drawing.Size(128, 55);
            this.WLListTvShowsButton.TabIndex = 6;
            this.WLListTvShowsButton.Text = "List TV Shows";
            this.WLListTvShowsButton.UseVisualStyleBackColor = true;
            this.WLListTvShowsButton.Click += new System.EventHandler(this.WLListTvShowsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1603, 498);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // watchTableBindingSource
            // 
            this.watchTableBindingSource.DataMember = "WatchTable";
            this.watchTableBindingSource.DataSource = this.pelinDatabaseDataSet1;
            this.watchTableBindingSource.CurrentChanged += new System.EventHandler(this.watchTableBindingSource_CurrentChanged);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WatchListPageUserControl";
            this.Size = new System.Drawing.Size(1831, 660);
            this.WatchListPMPanel.ResumeLayout(false);
            this.WatchListPMPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WLdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.Button WLListStateButton;
        private System.Windows.Forms.ComboBox WLStateFilterComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
