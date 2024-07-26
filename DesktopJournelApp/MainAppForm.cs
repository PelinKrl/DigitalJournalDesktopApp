using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopJournelApp
{
    public partial class MainAppForm : Form
    {
        private JournalPageUserControl journalPage;
        //private CalendarPageUserControl calendarPage;
        private WeatherAppPageUserControl weatherPage;
        private WatchListPageUserControl watchListPage;
        private ReadingListPageUserControl readingListPage;
        private TaskPlannerPageUserControl taskPlanerPage;
        private GraphsPageUserControl graphsPage;

        public static int _userId;
        public MainAppForm(int userId)
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(this.MainAppForm_Paint);
            this.Resize += new EventHandler(this.MainAppForm_Resize);
            InitializeJournalPage();
            //InitializeCalendarPage();
            InitializeWeatherAppPage();
            InitializeWatchListPage();
            InitializeReadingListPage();
            InitializeTaskPlanerPage();
            InitilizeGraphsPage();
            _userId = userId;
        }

        private void MainAppForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;
            if (rect.Width == 0 || rect.Height == 0) return;

            using (var brush = new LinearGradientBrush(this.ClientRectangle, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical))
            {
                var blend = new ColorBlend();
                blend.Positions = new[] { 0, 1 / 4f, 3 / 4f, 1 };
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
            //calendarPage.Visible = false;
            weatherPage.Visible = false;
            watchListPage.Visible = false;
            readingListPage.Visible = false;
            taskPlanerPage.Visible = false;
            graphsPage.Visible = false;
        }

        private void InitializeJournalPage()
        {
            journalPage = new JournalPageUserControl();
            journalPage.Dock = DockStyle.Fill; // Fill the MainAreaPanel
            MainAreaPanel.Controls.Add(journalPage);
        }

        //private void InitializeCalendarPage()
        //{
        //    calendarPage = new CalendarPageUserControl();
        //    calendarPage.Dock = DockStyle.Fill; // Fill the MainAreaPanel
        //    MainAreaPanel.Controls.Add(calendarPage);
        //}
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
            taskPlanerPage = new TaskPlannerPageUserControl();
            taskPlanerPage.Dock = DockStyle.Fill;
            MainAreaPanel.Controls.Add(taskPlanerPage);
        }

        private void InitilizeGraphsPage()
        {
            graphsPage = new GraphsPageUserControl();
            graphsPage.Dock = DockStyle.Fill;
            MainAreaPanel.Controls.Add(graphsPage);
        }

        private void ShowJournalPage()
        {
            HideAllPages();

            journalPage.Visible = true;

            JournalPanel.BackColor = Color.MediumPurple;
            WeatherAppPanel.BackColor = Color.Transparent;
            WatchListPanel.BackColor = Color.Transparent;
            ReadingListPanel.BackColor = Color.Transparent;
            TaskPlannerPanel.BackColor = Color.Transparent;
            WeeklyGraphPanel.BackColor = Color.Transparent;

        }

        //private void ShowCalendarPage()
        //{
        //    HideAllPages();
        //    //calendarPage.Visible = true;
        //    JournalPanel.BackColor = Color.Transparent;
        //    WeatherAppPanel.BackColor = Color.Transparent;
        //    WatchListPanel.BackColor = Color.Transparent;
        //    ReadingListPanel.BackColor = Color.Transparent;
        //    TaskPlannerPanel.BackColor = Color.Transparent;
        //}

        private void ShowWeatherAppPage()
        {
            HideAllPages();
            weatherPage.Visible = true;
            WeatherAppPanel.BackColor = Color.MediumPurple;
            JournalPanel.BackColor = Color.Transparent;
            WatchListPanel.BackColor = Color.Transparent;
            ReadingListPanel.BackColor = Color.Transparent;
            TaskPlannerPanel.BackColor = Color.Transparent;
            WeeklyGraphPanel.BackColor = Color.Transparent;
        }

        private void ShowWatchListPage()
        {
            HideAllPages();
            watchListPage.Visible = true;
            WatchListPanel.BackColor = Color.MediumPurple;
            JournalPanel.BackColor = Color.Transparent;
            WeatherAppPanel.BackColor = Color.Transparent;
            TaskPlannerPanel.BackColor = Color.Transparent;
            ReadingListPanel.BackColor = Color.Transparent;
            WeeklyGraphPanel.BackColor = Color.Transparent;
        }

        private void ShowReadingListPage()
        {
            HideAllPages();
            readingListPage.Visible = true;
            ReadingListPanel.BackColor = Color.MediumPurple;
            JournalPanel.BackColor = Color.Transparent;
            WeatherAppPanel.BackColor = Color.Transparent;
            WatchListPanel.BackColor = Color.Transparent;
            TaskPlannerPanel.BackColor = Color.Transparent;
            WeeklyGraphPanel.BackColor = Color.Transparent;
        }
        private void ShowTaskPlanerPage()
        {
            HideAllPages();
            taskPlanerPage.Visible = true;
            TaskPlannerPanel.BackColor = Color.MediumPurple;
            JournalPanel.BackColor = Color.Transparent;
            WeatherAppPanel.BackColor = Color.Transparent;
            WatchListPanel.BackColor = Color.Transparent;
            ReadingListPanel.BackColor = Color.Transparent;
            WeeklyGraphPanel.BackColor = Color.Transparent;

        }

        private void ShowGraphsPage()
        {
            HideAllPages();
            graphsPage.Visible = true;
            WeeklyGraphPanel.BackColor = Color.MediumPurple;
            JournalPanel.BackColor = Color.Transparent;
            WeatherAppPanel.BackColor = Color.Transparent;
            WatchListPanel.BackColor = Color.Transparent;
            ReadingListPanel.BackColor = Color.Transparent;
            TaskPlannerPanel.BackColor = Color.Transparent;

        }


        private void MainAppForm_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); // Redraw the form when it's resized

        }


        int clickPlace = 0; 

        private void JournalPanel_Click(object sender, EventArgs e)
        {
            
            ShowJournalPage();
            if (MainAreaPanel.Visible == true && clickPlace==1)
            {
                MainAreaPanel.Visible = false;
                JournalPanel.BackColor = Color.Transparent;
            }
            else
            {
                MainAreaPanel.Visible = true;
                clickPlace = 1;
            }


        }

        

        private void WeatherAppPanel_Click(object sender, EventArgs e)
        {
            ShowWeatherAppPage();
            if (MainAreaPanel.Visible == true && clickPlace == 2)
            {
                MainAreaPanel.Visible = false;
                WeatherAppPanel.BackColor = Color.Transparent;
            }
            else
            {
                MainAreaPanel.Visible = true;
                clickPlace = 2;
            }
        }

        private void WatchListPanel_Click(object sender, EventArgs e)
        {
            ShowWatchListPage();
            if (MainAreaPanel.Visible == true && clickPlace ==3)
            {
                MainAreaPanel.Visible = false;
                WatchListPanel.BackColor = Color.Transparent;
            }
            else
            {
                MainAreaPanel.Visible = true;
                clickPlace = 3;
            }
        }

        private void ReadingListPanel_Click(object sender, EventArgs e)
        {
            ShowReadingListPage();
            if (MainAreaPanel.Visible == true && clickPlace ==4)
            {
                MainAreaPanel.Visible = false;
                ReadingListPanel.BackColor = Color.Transparent;
            }
            else
            {
                MainAreaPanel.Visible = true;
                clickPlace = 4;
            }
        }

        private void TaskPlannerPanel_Click(object sender, EventArgs e)
        {
            ShowTaskPlanerPage();
            if (MainAreaPanel.Visible == true && clickPlace ==5)
            {
                MainAreaPanel.Visible = false;
                TaskPlannerPanel.BackColor = Color.Transparent;
            }
            else
            {
                MainAreaPanel.Visible = true;
                clickPlace = 5;
            }
        }
        private void WeeklyHabbitGraphLabel_Click(object sender, EventArgs e)
        {
            ShowGraphsPage();
            if (MainAreaPanel.Visible == true && clickPlace == 6)
            {
                MainAreaPanel.Visible = false;
                WeeklyGraphPanel.BackColor = Color.Transparent;
            }
            else
            {
                MainAreaPanel.Visible = true;
                clickPlace = 6;
            }

        }

        private void MainAppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainAppForm_Load(object sender, EventArgs e)
        {
            DateTime selectedDate = UpRightdateTimePicker.Value.Date;
            DisplayTasksForDate(selectedDate);
        }

        private void DisplayTasksForDate(DateTime date)
        {
            DataTable tasksForDate = SQL.GetTasksForToday(MainAppForm._userId, date);

            
            TodaysReminderRichTextBox.Clear();
            if (tasksForDate.Rows.Count > 0)
            {
                foreach (DataRow row in tasksForDate.Rows)
                {
                    TodaysReminderRichTextBox.AppendText(row["Name"].ToString() + Environment.NewLine);
                }
            }
            else
            {
                TodaysReminderRichTextBox.Text = "No tasks with the selected date's deadline.";
            }

  
        }

     

        private void UpRightdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = UpRightdateTimePicker.Value.Date;
            DisplayTasksForDate(selectedDate);
        }

        private void SettingPictureBox_Click(object sender, EventArgs e)
        {
           SettingsForm settingForm = new SettingsForm();
           settingForm.Show();
        }

       

        private void todaysReminderLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainAreaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void JournalPanel_MouseEnter(object sender, EventArgs e)
        //{
        //    JournalPanel.BackColor = Color.LightGray; 
        //}

        //private void JournalPanel_MouseLeave(object sender, EventArgs e)
        //{
        //    JournalPanel.BackColor = Color.Transparent; 
        //}
    }
}