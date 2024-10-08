﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopJournelApp
{
    public partial class JournalPageUserControl : UserControl
    {
        public JournalPageUserControl()
        {
            InitializeComponent();
        }

        

        private void JournalSaveButton_Click(object sender, EventArgs e)
        {
            string text = JournalRichTextBox.Text;
            DateTime selectedDate = JournalDateTimePicker.Value.Date;

            if (!string.IsNullOrEmpty(text))
            {
                SQL.InsertJournalText(selectedDate, text);
                MessageBox.Show("Journal entry saved successfully.");
            }
            else
            {
                MessageBox.Show("You did not write anything yet.");
            }



        }

        private void JournalDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = JournalDateTimePicker.Value.Date;

            string journalText = SQL.GetJournalTextByDate(selectedDate);
            JournalRichTextBox.Text = journalText;

            Dictionary<string, object> trackBehavior = SQL.GetTrackBehaviorByDate(selectedDate);

            if (trackBehavior != null)
            {
                MoodscomboBox.Text = trackBehavior["Mood"].ToString();
                CupsOfWaterTextBox.Text = trackBehavior["WaterCount"].ToString();
                BooksTextBox.Text = trackBehavior["PageCount"].ToString();
                SleepTextBox.Text = trackBehavior["HoursOfSleep"].ToString();
                WorkTextBox.Text = trackBehavior["HoursOfWork"].ToString();
                MovieTextBox.Text = trackBehavior["MinutesOfWatch"].ToString();
                SporTextBox.Text = trackBehavior["MinutesOfExercise"].ToString();
            }
            else
            {
                MoodscomboBox.Text = string.Empty;
                CupsOfWaterTextBox.Text = string.Empty;
                BooksTextBox.Text = string.Empty;
                SleepTextBox.Text = string.Empty;
                WorkTextBox.Text = string.Empty;
                MovieTextBox.Text = string.Empty;
                SporTextBox.Text = string.Empty;
            }
        }

        private void TrackSaveButton_Click(object sender, EventArgs e)
        {
            string mood = MoodscomboBox.Text;
            int water = Convert.ToInt32(CupsOfWaterTextBox.Text);
            int pages = Convert.ToInt32(BooksTextBox.Text);
            int sleep = Convert.ToInt32(SleepTextBox.Text);
            int work = Convert.ToInt32(WorkTextBox.Text);
            int watch = Convert.ToInt32(MovieTextBox.Text);
            int spor = Convert.ToInt32(SporTextBox.Text);

            DateTime selectedDate = JournalDateTimePicker.Value.Date;

            SQL.InsertTrackBehaviour(selectedDate, mood, water, pages, work, spor, watch, sleep);

            DailyTracksPanel.Visible = false;
        }


        private void TBPanel_Click(object sender, EventArgs e)
        {
            if (DailyTracksPanel.Visible == true)
            {
                DailyTracksPanel.Visible = false;
            }
            else
            {
                DailyTracksPanel.Visible = true;
            }


        }
    }
}
