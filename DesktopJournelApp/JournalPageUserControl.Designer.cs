namespace DesktopJournelApp
{
    partial class JournalPageUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalPageUserControl));
            this.DearDiaryLabel = new System.Windows.Forms.Label();
            this.JournalRichTextBox = new System.Windows.Forms.RichTextBox();
            this.JournalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.JournalSaveButton = new System.Windows.Forms.Button();
            this.TBPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DailyTracksPanel = new System.Windows.Forms.Panel();
            this.SleepTextBox = new System.Windows.Forms.TextBox();
            this.SleepLabel1 = new System.Windows.Forms.Label();
            this.TrackSaveButton = new System.Windows.Forms.Button();
            this.MovieTvSHowLabel2 = new System.Windows.Forms.Label();
            this.SportLabel2 = new System.Windows.Forms.Label();
            this.WorkLabels2 = new System.Windows.Forms.Label();
            this.BooksLabel2 = new System.Windows.Forms.Label();
            this.WaterLabel1 = new System.Windows.Forms.Label();
            this.MovieTextBox = new System.Windows.Forms.TextBox();
            this.SporTextBox = new System.Windows.Forms.TextBox();
            this.WorkTextBox = new System.Windows.Forms.TextBox();
            this.CupsOfWaterTextBox = new System.Windows.Forms.TextBox();
            this.BooksTextBox = new System.Windows.Forms.TextBox();
            this.MovieTvSHowLabel1 = new System.Windows.Forms.Label();
            this.BooksLabel1 = new System.Windows.Forms.Label();
            this.SportLabel1 = new System.Windows.Forms.Label();
            this.WaterLabel2 = new System.Windows.Forms.Label();
            this.WorkLabels1 = new System.Windows.Forms.Label();
            this.MoodscomboBox = new System.Windows.Forms.ComboBox();
            this.FeelsLabel = new System.Windows.Forms.Label();
            this.TBPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DailyTracksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DearDiaryLabel
            // 
            this.DearDiaryLabel.AutoSize = true;
            this.DearDiaryLabel.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DearDiaryLabel.Location = new System.Drawing.Point(32, 23);
            this.DearDiaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DearDiaryLabel.Name = "DearDiaryLabel";
            this.DearDiaryLabel.Size = new System.Drawing.Size(153, 22);
            this.DearDiaryLabel.TabIndex = 0;
            this.DearDiaryLabel.Text = "Dear Diary...";
            // 
            // JournalRichTextBox
            // 
            this.JournalRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.JournalRichTextBox.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalRichTextBox.Location = new System.Drawing.Point(35, 47);
            this.JournalRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JournalRichTextBox.Name = "JournalRichTextBox";
            this.JournalRichTextBox.Size = new System.Drawing.Size(840, 502);
            this.JournalRichTextBox.TabIndex = 1;
            this.JournalRichTextBox.Text = "";
            // 
            // JournalDateTimePicker
            // 
            this.JournalDateTimePicker.CalendarFont = new System.Drawing.Font("Footlight MT Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalDateTimePicker.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalDateTimePicker.Location = new System.Drawing.Point(633, 15);
            this.JournalDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JournalDateTimePicker.Name = "JournalDateTimePicker";
            this.JournalDateTimePicker.Size = new System.Drawing.Size(242, 28);
            this.JournalDateTimePicker.TabIndex = 2;
            this.JournalDateTimePicker.ValueChanged += new System.EventHandler(this.JournalDateTimePicker_ValueChanged);
            // 
            // JournalSaveButton
            // 
            this.JournalSaveButton.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalSaveButton.Location = new System.Drawing.Point(776, 553);
            this.JournalSaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JournalSaveButton.Name = "JournalSaveButton";
            this.JournalSaveButton.Size = new System.Drawing.Size(99, 39);
            this.JournalSaveButton.TabIndex = 4;
            this.JournalSaveButton.Text = "Save";
            this.JournalSaveButton.UseVisualStyleBackColor = true;
            this.JournalSaveButton.Click += new System.EventHandler(this.JournalSaveButton_Click);
            // 
            // TBPanel
            // 
            this.TBPanel.BackColor = System.Drawing.Color.Transparent;
            this.TBPanel.Controls.Add(this.pictureBox1);
            this.TBPanel.Controls.Add(this.label1);
            this.TBPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TBPanel.Location = new System.Drawing.Point(879, 17);
            this.TBPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPanel.Name = "TBPanel";
            this.TBPanel.Size = new System.Drawing.Size(140, 68);
            this.TBPanel.TabIndex = 11;
            this.TBPanel.BindingContextChanged += new System.EventHandler(this.TBPanel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.TBPanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Track Daily";
            this.label1.Click += new System.EventHandler(this.TBPanel_Click);
            // 
            // DailyTracksPanel
            // 
            this.DailyTracksPanel.BackColor = System.Drawing.Color.Transparent;
            this.DailyTracksPanel.Controls.Add(this.SleepTextBox);
            this.DailyTracksPanel.Controls.Add(this.SleepLabel1);
            this.DailyTracksPanel.Controls.Add(this.TrackSaveButton);
            this.DailyTracksPanel.Controls.Add(this.MovieTvSHowLabel2);
            this.DailyTracksPanel.Controls.Add(this.SportLabel2);
            this.DailyTracksPanel.Controls.Add(this.WorkLabels2);
            this.DailyTracksPanel.Controls.Add(this.BooksLabel2);
            this.DailyTracksPanel.Controls.Add(this.WaterLabel1);
            this.DailyTracksPanel.Controls.Add(this.MovieTextBox);
            this.DailyTracksPanel.Controls.Add(this.SporTextBox);
            this.DailyTracksPanel.Controls.Add(this.WorkTextBox);
            this.DailyTracksPanel.Controls.Add(this.CupsOfWaterTextBox);
            this.DailyTracksPanel.Controls.Add(this.BooksTextBox);
            this.DailyTracksPanel.Controls.Add(this.MovieTvSHowLabel1);
            this.DailyTracksPanel.Controls.Add(this.BooksLabel1);
            this.DailyTracksPanel.Controls.Add(this.SportLabel1);
            this.DailyTracksPanel.Controls.Add(this.WaterLabel2);
            this.DailyTracksPanel.Controls.Add(this.WorkLabels1);
            this.DailyTracksPanel.Controls.Add(this.MoodscomboBox);
            this.DailyTracksPanel.Controls.Add(this.FeelsLabel);
            this.DailyTracksPanel.Location = new System.Drawing.Point(879, 89);
            this.DailyTracksPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DailyTracksPanel.Name = "DailyTracksPanel";
            this.DailyTracksPanel.Size = new System.Drawing.Size(501, 295);
            this.DailyTracksPanel.TabIndex = 12;
            this.DailyTracksPanel.Visible = false;
            // 
            // SleepTextBox
            // 
            this.SleepTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SleepTextBox.Location = new System.Drawing.Point(100, 216);
            this.SleepTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SleepTextBox.Name = "SleepTextBox";
            this.SleepTextBox.Size = new System.Drawing.Size(94, 24);
            this.SleepTextBox.TabIndex = 15;
            // 
            // SleepLabel1
            // 
            this.SleepLabel1.AutoSize = true;
            this.SleepLabel1.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SleepLabel1.Location = new System.Drawing.Point(2, 216);
            this.SleepLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SleepLabel1.Name = "SleepLabel1";
            this.SleepLabel1.Size = new System.Drawing.Size(84, 20);
            this.SleepLabel1.TabIndex = 19;
            this.SleepLabel1.Text = "I slept for";
            // 
            // TrackSaveButton
            // 
            this.TrackSaveButton.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackSaveButton.Location = new System.Drawing.Point(371, 243);
            this.TrackSaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrackSaveButton.Name = "TrackSaveButton";
            this.TrackSaveButton.Size = new System.Drawing.Size(108, 36);
            this.TrackSaveButton.TabIndex = 15;
            this.TrackSaveButton.Text = "Save";
            this.TrackSaveButton.UseVisualStyleBackColor = true;
            this.TrackSaveButton.Click += new System.EventHandler(this.TrackSaveButton_Click);
            // 
            // MovieTvSHowLabel2
            // 
            this.MovieTvSHowLabel2.AutoSize = true;
            this.MovieTvSHowLabel2.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTvSHowLabel2.Location = new System.Drawing.Point(354, 151);
            this.MovieTvSHowLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieTvSHowLabel2.Name = "MovieTvSHowLabel2";
            this.MovieTvSHowLabel2.Size = new System.Drawing.Size(125, 20);
            this.MovieTvSHowLabel2.TabIndex = 18;
            this.MovieTvSHowLabel2.Text = "minutes today.";
            // 
            // SportLabel2
            // 
            this.SportLabel2.AutoSize = true;
            this.SportLabel2.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SportLabel2.Location = new System.Drawing.Point(198, 182);
            this.SportLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SportLabel2.Name = "SportLabel2";
            this.SportLabel2.Size = new System.Drawing.Size(125, 20);
            this.SportLabel2.TabIndex = 17;
            this.SportLabel2.Text = "minutes today.";
            // 
            // WorkLabels2
            // 
            this.WorkLabels2.AutoSize = true;
            this.WorkLabels2.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkLabels2.Location = new System.Drawing.Point(213, 80);
            this.WorkLabels2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WorkLabels2.Name = "WorkLabels2";
            this.WorkLabels2.Size = new System.Drawing.Size(108, 20);
            this.WorkLabels2.TabIndex = 3;
            this.WorkLabels2.Text = "hours today.";
            // 
            // BooksLabel2
            // 
            this.BooksLabel2.AutoSize = true;
            this.BooksLabel2.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksLabel2.Location = new System.Drawing.Point(173, 116);
            this.BooksLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BooksLabel2.Name = "BooksLabel2";
            this.BooksLabel2.Size = new System.Drawing.Size(169, 20);
            this.BooksLabel2.TabIndex = 16;
            this.BooksLabel2.Text = "pages of book today.";
            // 
            // WaterLabel1
            // 
            this.WaterLabel1.AutoSize = true;
            this.WaterLabel1.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterLabel1.Location = new System.Drawing.Point(2, 43);
            this.WaterLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WaterLabel1.Name = "WaterLabel1";
            this.WaterLabel1.Size = new System.Drawing.Size(68, 20);
            this.WaterLabel1.TabIndex = 15;
            this.WaterLabel1.Text = "I drank";
            // 
            // MovieTextBox
            // 
            this.MovieTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTextBox.Location = new System.Drawing.Point(263, 151);
            this.MovieTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MovieTextBox.Name = "MovieTextBox";
            this.MovieTextBox.Size = new System.Drawing.Size(87, 24);
            this.MovieTextBox.TabIndex = 14;
            // 
            // SporTextBox
            // 
            this.SporTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SporTextBox.Location = new System.Drawing.Point(100, 184);
            this.SporTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SporTextBox.Name = "SporTextBox";
            this.SporTextBox.Size = new System.Drawing.Size(94, 24);
            this.SporTextBox.TabIndex = 13;
            // 
            // WorkTextBox
            // 
            this.WorkTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkTextBox.Location = new System.Drawing.Point(90, 80);
            this.WorkTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkTextBox.Name = "WorkTextBox";
            this.WorkTextBox.Size = new System.Drawing.Size(100, 24);
            this.WorkTextBox.TabIndex = 12;
            // 
            // CupsOfWaterTextBox
            // 
            this.CupsOfWaterTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CupsOfWaterTextBox.Location = new System.Drawing.Point(90, 43);
            this.CupsOfWaterTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CupsOfWaterTextBox.Name = "CupsOfWaterTextBox";
            this.CupsOfWaterTextBox.Size = new System.Drawing.Size(67, 24);
            this.CupsOfWaterTextBox.TabIndex = 11;
            // 
            // BooksTextBox
            // 
            this.BooksTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksTextBox.Location = new System.Drawing.Point(71, 116);
            this.BooksTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BooksTextBox.Name = "BooksTextBox";
            this.BooksTextBox.Size = new System.Drawing.Size(91, 24);
            this.BooksTextBox.TabIndex = 7;
            // 
            // MovieTvSHowLabel1
            // 
            this.MovieTvSHowLabel1.AutoSize = true;
            this.MovieTvSHowLabel1.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTvSHowLabel1.Location = new System.Drawing.Point(2, 152);
            this.MovieTvSHowLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieTvSHowLabel1.Name = "MovieTvSHowLabel1";
            this.MovieTvSHowLabel1.Size = new System.Drawing.Size(257, 20);
            this.MovieTvSHowLabel1.TabIndex = 6;
            this.MovieTvSHowLabel1.Text = "I watched a movie/Tv Show for\r\n";
            // 
            // BooksLabel1
            // 
            this.BooksLabel1.AutoSize = true;
            this.BooksLabel1.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksLabel1.Location = new System.Drawing.Point(2, 116);
            this.BooksLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BooksLabel1.Name = "BooksLabel1";
            this.BooksLabel1.Size = new System.Drawing.Size(55, 20);
            this.BooksLabel1.TabIndex = 5;
            this.BooksLabel1.Text = "I read";
            // 
            // SportLabel1
            // 
            this.SportLabel1.AutoSize = true;
            this.SportLabel1.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SportLabel1.Location = new System.Drawing.Point(2, 184);
            this.SportLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SportLabel1.Name = "SportLabel1";
            this.SportLabel1.Size = new System.Drawing.Size(93, 20);
            this.SportLabel1.TabIndex = 4;
            this.SportLabel1.Text = "I exercised";
            // 
            // WaterLabel2
            // 
            this.WaterLabel2.AutoSize = true;
            this.WaterLabel2.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterLabel2.Location = new System.Drawing.Point(173, 43);
            this.WaterLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WaterLabel2.Name = "WaterLabel2";
            this.WaterLabel2.Size = new System.Drawing.Size(169, 20);
            this.WaterLabel2.TabIndex = 3;
            this.WaterLabel2.Text = "cups of water today.";
            // 
            // WorkLabels1
            // 
            this.WorkLabels1.AutoSize = true;
            this.WorkLabels1.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkLabels1.Location = new System.Drawing.Point(2, 82);
            this.WorkLabels1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WorkLabels1.Name = "WorkLabels1";
            this.WorkLabels1.Size = new System.Drawing.Size(84, 20);
            this.WorkLabels1.TabIndex = 2;
            this.WorkLabels1.Text = "I worked ";
            // 
            // MoodscomboBox
            // 
            this.MoodscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MoodscomboBox.FormattingEnabled = true;
            this.MoodscomboBox.Items.AddRange(new object[] {
            "!Magnificant!",
            "Very Happy!",
            "Happy",
            "Excited",
            "Motivated",
            "Normal",
            "Hardworking",
            "Moody",
            "Bored",
            "Angry",
            "Tired",
            "Sad",
            "Lonely",
            "Devistaded",
            "Stressed ",
            "Depressed",
            "Just Kill Me"});
            this.MoodscomboBox.Location = new System.Drawing.Point(198, 7);
            this.MoodscomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoodscomboBox.Name = "MoodscomboBox";
            this.MoodscomboBox.Size = new System.Drawing.Size(99, 21);
            this.MoodscomboBox.TabIndex = 1;
            // 
            // FeelsLabel
            // 
            this.FeelsLabel.AutoSize = true;
            this.FeelsLabel.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeelsLabel.Location = new System.Drawing.Point(2, 8);
            this.FeelsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FeelsLabel.Name = "FeelsLabel";
            this.FeelsLabel.Size = new System.Drawing.Size(192, 20);
            this.FeelsLabel.TabIndex = 0;
            this.FeelsLabel.Text = "How do you feel today?";
            // 
            // JournalPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.TBPanel);
            this.Controls.Add(this.DailyTracksPanel);
            this.Controls.Add(this.JournalSaveButton);
            this.Controls.Add(this.JournalDateTimePicker);
            this.Controls.Add(this.JournalRichTextBox);
            this.Controls.Add(this.DearDiaryLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "JournalPageUserControl";
            this.Size = new System.Drawing.Size(1470, 672);
            this.TBPanel.ResumeLayout(false);
            this.TBPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DailyTracksPanel.ResumeLayout(false);
            this.DailyTracksPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DearDiaryLabel;
        private System.Windows.Forms.RichTextBox JournalRichTextBox;
        private System.Windows.Forms.DateTimePicker JournalDateTimePicker;
        private System.Windows.Forms.Button JournalSaveButton;
        private System.Windows.Forms.Panel TBPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DailyTracksPanel;
        private System.Windows.Forms.TextBox SleepTextBox;
        private System.Windows.Forms.Label SleepLabel1;
        private System.Windows.Forms.Button TrackSaveButton;
        private System.Windows.Forms.Label MovieTvSHowLabel2;
        private System.Windows.Forms.Label SportLabel2;
        private System.Windows.Forms.Label WorkLabels2;
        private System.Windows.Forms.Label BooksLabel2;
        private System.Windows.Forms.Label WaterLabel1;
        private System.Windows.Forms.TextBox MovieTextBox;
        private System.Windows.Forms.TextBox SporTextBox;
        private System.Windows.Forms.TextBox WorkTextBox;
        private System.Windows.Forms.TextBox CupsOfWaterTextBox;
        private System.Windows.Forms.TextBox BooksTextBox;
        private System.Windows.Forms.Label MovieTvSHowLabel1;
        private System.Windows.Forms.Label BooksLabel1;
        private System.Windows.Forms.Label SportLabel1;
        private System.Windows.Forms.Label WaterLabel2;
        private System.Windows.Forms.Label WorkLabels1;
        private System.Windows.Forms.ComboBox MoodscomboBox;
        private System.Windows.Forms.Label FeelsLabel;
    }
}
