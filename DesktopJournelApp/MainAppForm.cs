using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopJournelApp
{
    public partial class MainAppForm : Form
    {
        private JournalPageUserControl journalPage;
        private CalendarPageUserControl calendarPage; 
        private WeatherAppPageUserControl weatherPage;
        private WatchListPageUserControl watchListPage;
        private ReadingListPageUserControl readingListPage;
        private TaskPlanerPageUserControl TaskPlanerPage;

        public static int _userId;
        public MainAppForm(int userId)
        {
            InitializeComponent(); 
            this.Paint += new PaintEventHandler(this.MainAppForm_Paint);
            this.Resize += new EventHandler(this.MainAppForm_Resize);
            InitializeJournalPage();
            InitializeCalendarPage();
            InitializeWeatherAppPage();
            InitializeWatchListPage();
            InitializeReadingListPage();
            InitializeTaskPlanerPage();
            MoodscomboBox.SelectedIndex= 0;
            _userId=userId;
        }

        private void MainAppForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;
            if (rect.Width == 0 || rect.Height == 0) return;

            using (var brush = new LinearGradientBrush(this.ClientRectangle,  Color.Transparent, Color.Transparent, LinearGradientMode.Vertical))
            {
                var blend = new ColorBlend();
                blend.Positions = new[] { 0, 1/ 4f, 3 / 4f,  1 };
                blend.Colors = new[] { Color.White, Color.White, Color.Violet, Color.BlueViolet };
                brush.InterpolationColors = blend;
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            //using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.BlueViolet, Color.White, 90F))
            //{
            //    // Create a blend object to control the gradient
            //    Blend blend = new Blend();
            //    blend.Positions = new float[] { 0.0f, 0.3f, 1.0f }; // Adjust the position to start with white and transition to violet
            //    blend.Factors = new float[] { 1.0f, 0.7f, 0.0f }; // Adjust the factors to start with full white and transition to violet


            //    // Apply the blend to the brush
            //    brush.Blend = blend;

            //    // Fill the rectangle with the gradient
            //    g.FillRectangle(brush, rect);
            //}
        }

        private void HideAllPages()
        {
            journalPage.Visible = false;
            calendarPage.Visible = false;
            weatherPage.Visible = false;
            watchListPage.Visible = false;
            readingListPage.Visible = false;
            TaskPlanerPage.Visible = false;
        }

        private void InitializeJournalPage()
        {
            
            journalPage = new JournalPageUserControl();
            journalPage.Dock = DockStyle.Fill; // Fill the MainAreaPanel
            MainAreaPanel.Controls.Add(journalPage);
        }

        private void InitializeCalendarPage()
        {

            calendarPage = new CalendarPageUserControl();
            calendarPage.Dock = DockStyle.Fill; // Fill the MainAreaPanel
            MainAreaPanel.Controls.Add(calendarPage);
        }
        private void InitializeWeatherAppPage()
        {
            weatherPage = new WeatherAppPageUserControl();
            weatherPage.Dock = DockStyle.Fill;
            MainAreaPanel.Controls.Add(weatherPage);
        }

        private void InitializeWatchListPage()
        {
            watchListPage = new WatchListPageUserControl();
            watchListPage.Dock = DockStyle.Fill;
            MainAreaPanel.Controls.Add(watchListPage);
        }

        private void InitializeReadingListPage()
        {
            readingListPage = new ReadingListPageUserControl();
            readingListPage.Dock = DockStyle.Fill;
            MainAreaPanel.Controls.Add(readingListPage);
        }

        private void InitializeTaskPlanerPage()
        {
            TaskPlanerPage = new TaskPlanerPageUserControl();
            TaskPlanerPage.Dock = DockStyle.Fill;
            MainAreaPanel.Controls.Add(TaskPlanerPage);
        }

        private void ShowJournalPage()
        {
            HideAllPages();
            journalPage.Visible = true;
            JournalPanel.BackColor = Color.MediumPurple;
            CalendarPanel.BackColor = Color.Transparent;
            WeatherAppPanel.BackColor = Color.Transparent;
            WatchListPanel.BackColor = Color.Transparent;   
            ReadingListPanel.BackColor = Color.Transparent; 
            TaskPlannerPanel.BackColor = Color.Transparent;
            
        }

        private void ShowCalendarPage()
        {
            HideAllPages();
            calendarPage.Visible = true;
            CalendarPanel.BackColor = Color.MediumPurple;
            JournalPanel.BackColor = Color.Transparent;
            WeatherAppPanel.BackColor = Color.Transparent;
            WatchListPanel.BackColor = Color.Transparent;
            ReadingListPanel.BackColor = Color.Transparent;
            TaskPlannerPanel.BackColor = Color.Transparent;
        }

        private void ShowWeatherAppPage()
        {
            HideAllPages();
            weatherPage.Visible = true;
            WeatherAppPanel.BackColor = Color.MediumPurple;
            JournalPanel.BackColor = Color.Transparent;
            CalendarPanel.BackColor = Color.Transparent;
            WatchListPanel.BackColor = Color.Transparent;
            ReadingListPanel.BackColor = Color.Transparent;
            TaskPlannerPanel.BackColor = Color.Transparent;
        }

        private void ShowWatchListPage()
        {
            HideAllPages();
            watchListPage.Visible = true;
            WatchListPanel.BackColor = Color.MediumPurple; 
            JournalPanel.BackColor = Color.Transparent;
            CalendarPanel.BackColor = Color.Transparent;
            WeatherAppPanel.BackColor = Color.Transparent;
            TaskPlannerPanel.BackColor = Color.Transparent;
            ReadingListPanel.BackColor = Color.Transparent;
        }

        private void ShowReadingListPage()
        {
            HideAllPages();
            readingListPage.Visible = true;
            ReadingListPanel.BackColor = Color.MediumPurple;
            JournalPanel.BackColor = Color.Transparent;
            CalendarPanel.BackColor = Color.Transparent;
            WeatherAppPanel.BackColor = Color.Transparent;
            WatchListPanel.BackColor = Color.Transparent;
            TaskPlannerPanel.BackColor = Color.Transparent;

        }
        private void ShowTaskPlanerPage()
        {
            HideAllPages();
            TaskPlanerPage.Visible = true;
            TaskPlannerPanel.BackColor = Color.MediumPurple;
            JournalPanel.BackColor = Color.Transparent;
            CalendarPanel.BackColor = Color.Transparent;
            WeatherAppPanel.BackColor = Color.Transparent;
            WatchListPanel.BackColor = Color.Transparent;
            ReadingListPanel.BackColor = Color.Transparent; 

        }


        private void MainAppForm_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); // Redraw the form when it's resized
            
        }


        private void MainAppForm_Load(object sender, EventArgs e)
        {

        }

        

        private void MainAreaPanel_Click(object sender, EventArgs e)
        {

        }

        private void JournalPanel_Click(object sender, EventArgs e)
        {
            ShowJournalPage();
            MainAreaPanel.Visible = true;

        }

        private void CalendarPanel_Click(object sender, EventArgs e)
        {
            ShowCalendarPage();
            MainAreaPanel.Visible = true; 
        }

        private void WeatherAppPanel_Click(object sender, EventArgs e)
        {
            ShowWeatherAppPage();
            MainAreaPanel.Visible = true; 
        }

        private void WatchListPanel_Click(object sender, EventArgs e)
        {
            ShowWatchListPage();
            MainAreaPanel.Visible = true; 
        }

        private void ReadingListPanel_Click(object sender, EventArgs e)
        {
            ShowReadingListPage();
            MainAreaPanel.Visible = true; 
        }

        private void TaskPlannerPanel_Click(object sender, EventArgs e)
        {
            ShowTaskPlanerPage();
            MainAreaPanel.Visible = true; 
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

            SQL.InsertTrackBehaviour(mood, water, pages, work, spor, watch, sleep); 
        }

        private void MovieTvSHowLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainAppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

       
    }
}
