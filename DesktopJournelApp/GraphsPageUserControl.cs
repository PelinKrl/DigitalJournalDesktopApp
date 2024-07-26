using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DesktopJournelApp
{
    public partial class GraphsPageUserControl : UserControl
    {
        public GraphsPageUserControl()
        {
            InitializeComponent();
            InitializeCharts();
        }

        DataTable dataTable;

        private void InitializeCharts()
        {
            // Enable zooming and scrolling for all charts
            EnableZoomingAndScrolling(MoodChart);
            EnableZoomingAndScrolling(WaterChart);
            EnableZoomingAndScrolling(PageChart);
            EnableZoomingAndScrolling(TimeSpentChart);

            // Attach MouseWheel event handlers
            MoodChart.MouseWheel += Chart_MouseWheel;
            WaterChart.MouseWheel += Chart_MouseWheel;
            PageChart.MouseWheel += Chart_MouseWheel;
            TimeSpentChart.MouseWheel += Chart_MouseWheel;
        }

        private void EnableZoomingAndScrolling(Chart chart)
        {
            foreach (var area in chart.ChartAreas)
            {
                area.AxisX.ScaleView.Zoomable = true;
                area.AxisY.ScaleView.Zoomable = true;
                area.CursorX.AutoScroll = true;
                area.CursorY.AutoScroll = true;
                area.AxisX.ScrollBar.Enabled = true;
                area.AxisY.ScrollBar.Enabled = true;
            }
        }

        private void Chart_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = sender as Chart;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

        private void GViewButton_Click(object sender, EventArgs e)
        {
            dataTable = SQL.GetTrackBehaviourDataByDateRange(MainAppForm._userId, GStartDateTimePicker.Value, GFinishDateTimePicker.Value);

            if (MoodChart.Series.IndexOf("Mood") == -1)
            {
                MoodChart.Series.Add("Mood");
            }
            // Debug: Check if dataTable contains rows
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data found for the selected date range.");
                return;
            }

            // Ensure the MoodChart is properly configured
            if (MoodChart.Series.IndexOf("Mood") == -1)
            {
                MoodChart.Series.Add("Mood");
            }

            Series moodSeries = MoodChart.Series["Mood"];
            moodSeries.ChartType = SeriesChartType.Point;
            moodSeries.XValueType = ChartValueType.DateTime;
            moodSeries.Points.Clear();

            // Mapping moods to numeric values
            Dictionary<string, int> moodMapping = new Dictionary<string, int>
            {
                { "Magnificent", 17 },
                { "Very Happy", 16 },
                { "Happy", 15 },
                { "Excited", 14 },
                { "Motivated", 13 },
                { "Normal", 12 },
                { "Hardworking", 11 },
                { "Moody", 10 },
                { "Bored", 9 },
                { "Angry", 8 },
                { "Tired", 7 },
                { "Sad", 6},
                { "Lonely", 5 },
                { "Devistaded", 4 },
                { "Stressed", 3 },
                { "Depressed", 2 },
                { "Just Kill Me", 1 }
            };

            // Add data points to the mood series
            foreach (DataRow row in dataTable.Rows)
            {
                DateTime date = Convert.ToDateTime(row["Date"]);
                string moodString = row["Mood"].ToString();
                if (moodMapping.ContainsKey(moodString))
                {
                    int moodValue = moodMapping[moodString];
                    moodSeries.Points.AddXY(date, moodValue);

                    // Debug: Check the added data points
                    Console.WriteLine($"Added data point: Date={date}, Mood={moodString}, Value={moodValue}");
                }
                else
                {
                    // Debug: Check if there's an unmapped mood
                    Console.WriteLine($"Unmapped mood: {moodString}");
                }
            }

            // Ensure the chart updates
            MoodChart.Invalidate();

            MoodChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yyyy";
            MoodChart.ChartAreas[0].AxisY.Interval = 1;
            MoodChart.ChartAreas[0].AxisY.Minimum = 1;
            MoodChart.ChartAreas[0].AxisY.Maximum = 17;
            MoodChart.ChartAreas[0].AxisY.Title = "Mood";
            MoodChart.ChartAreas[0].AxisX.Title = "Date";

            // Customize the Y-axis labels to show mood names instead of numeric values
            MoodChart.ChartAreas[0].AxisY.CustomLabels.Clear();
            foreach (var mood in moodMapping)
            {
                MoodChart.ChartAreas[0].AxisY.CustomLabels.Add(mood.Value - 0.5, mood.Value + 0.5, mood.Key);
            }

            // Configure and update WaterChart
            if (WaterChart.Series.IndexOf("Water") == -1)
            {
                WaterChart.Series.Add("Water");
            }

            Series waterSeries = WaterChart.Series["Water"];
            waterSeries.ChartType = SeriesChartType.Column;
            waterSeries.XValueType = ChartValueType.DateTime;
            waterSeries.Points.Clear();

            // Add data points to the water series
            foreach (DataRow row in dataTable.Rows)
            {
                DateTime date = Convert.ToDateTime(row["Date"]);
                int waterCount = Convert.ToInt32(row["WaterCount"]);
                waterSeries.Points.AddXY(date, waterCount);

                // Debug: Check the added data points
                Console.WriteLine($"Added data point: Date={date}, WaterCount={waterCount}");
            }

            // Update WaterChart appearance
            WaterChart.Invalidate();
            WaterChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yyyy";
            WaterChart.ChartAreas[0].AxisY.Title = "Water Count";
            WaterChart.ChartAreas[0].AxisX.Title = "Date";

            // Debug: Check final series point count
            Console.WriteLine($"Total points in Mood series: {moodSeries.Points.Count}");
            Console.WriteLine($"Total points in Water series: {waterSeries.Points.Count}");
            // Configure and update PageChart
            if (PageChart.Series.IndexOf("Page") == -1)
            {
                PageChart.Series.Add("Page");
            }

            Series pageSeries = PageChart.Series["Page"];
            pageSeries.ChartType = SeriesChartType.Column;
            pageSeries.XValueType = ChartValueType.DateTime;
            pageSeries.Points.Clear();

            // Add data points to the page series
            foreach (DataRow row in dataTable.Rows)
            {
                DateTime date = Convert.ToDateTime(row["Date"]);
                int pageCount = Convert.ToInt32(row["PageCount"]);
                pageSeries.Points.AddXY(date, pageCount);
            }

            // Update PageChart appearance
            PageChart.Invalidate();
            PageChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yyyy";
            PageChart.ChartAreas[0].AxisY.Title = "Page Count";
            PageChart.ChartAreas[0].AxisX.Title = "Date";

            Series hoursOfWorkSeries = TimeSpentChart.Series["Minutes Of Work"];
            Series minutesOfWatchSeries = TimeSpentChart.Series["Minutes Of Watch"];
            Series minutesOfExerciseSeries = TimeSpentChart.Series["Minutes Of Exercises"];
            Series hoursOfSleepSeries = TimeSpentChart.Series["Minutes Of Sleep"];

            hoursOfWorkSeries.ChartType = SeriesChartType.Column;
            minutesOfWatchSeries.ChartType = SeriesChartType.Column;
            minutesOfExerciseSeries.ChartType = SeriesChartType.Column;
            hoursOfSleepSeries.ChartType = SeriesChartType.Column;

            hoursOfWorkSeries.XValueType = ChartValueType.DateTime;
            minutesOfWatchSeries.XValueType = ChartValueType.DateTime;
            minutesOfExerciseSeries.XValueType = ChartValueType.DateTime;
            hoursOfSleepSeries.XValueType = ChartValueType.DateTime;

            hoursOfWorkSeries.Points.Clear();
            minutesOfWatchSeries.Points.Clear();
            minutesOfExerciseSeries.Points.Clear();
            hoursOfSleepSeries.Points.Clear();

            // Add data points to the combined chart series
            foreach (DataRow row in dataTable.Rows)
            {
                DateTime date = Convert.ToDateTime(row["Date"]);
                int hoursOfWork = 60 * (Convert.ToInt32(row["HoursOfWork"]));
                int minutesOfWatch = Convert.ToInt32(row["MinutesOfWatch"]);
                int minutesOfExercise = Convert.ToInt32(row["MinutesOfExercise"]);
                int hoursOfSleep = 60 * (Convert.ToInt32(row["HoursOfSleep"]));

                hoursOfWorkSeries.Points.AddXY(date.ToOADate(), hoursOfWork);
                minutesOfWatchSeries.Points.AddXY(date.ToOADate(), minutesOfWatch);
                minutesOfExerciseSeries.Points.AddXY(date.ToOADate(), minutesOfExercise);
                hoursOfSleepSeries.Points.AddXY(date.ToOADate(), hoursOfSleep);
            }

            // Update CombinedChart appearance
            TimeSpentChart.Invalidate();
            TimeSpentChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yyyy";
            TimeSpentChart.ChartAreas[0].AxisY.Title = "Count";
            TimeSpentChart.ChartAreas[0].AxisX.Title = "Date";
        }

        ToolTip tooltipMood = new ToolTip();
        private void MoodChart_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tooltipMood.RemoveAll();
                HitTestResult result = MoodChart.HitTest(e.X, e.Y);
                if (result.ChartElementType == ChartElementType.DataPoint)//If clicked point is data point
                {
                    //MessageBox.Show(result.Series.Points[result.PointIndex].YValues[0]+""); 
                    //MoodChart.Series[0].ToolTip = "hello world from #VALX, #VAL";
                    var yVal = result.Series.Points[result.PointIndex].YValues[0];

                    var pos = e.Location;
                    tooltipMood.Show(((int)yVal).ToString(), MoodChart, pos.X, pos.Y - 15);
                }

            }
        }

        private void WaterChart_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                tooltipMood.RemoveAll();
                HitTestResult result = WaterChart.HitTest(e.X, e.Y);
                if (result.ChartElementType == ChartElementType.DataPoint)//If clicked point is data point
                {
                    //MessageBox.Show(result.Series.Points[result.PointIndex].YValues[0]+""); 
                    //MoodChart.Series[0].ToolTip = "hello world from #VALX, #VAL";
                    var yVal = result.Series.Points[result.PointIndex].YValues[0];

                    var pos = e.Location;
                    tooltipMood.Show(((int)yVal).ToString(), WaterChart, pos.X, pos.Y - 15);
                }

            }
        }

        private void PageChart_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                tooltipMood.RemoveAll();
                HitTestResult result = PageChart.HitTest(e.X, e.Y);
                if (result.ChartElementType == ChartElementType.DataPoint)//If clicked point is data point
                {
                    //MessageBox.Show(result.Series.Points[result.PointIndex].YValues[0]+""); 
                    //MoodChart.Series[0].ToolTip = "hello world from #VALX, #VAL";
                    var yVal = result.Series.Points[result.PointIndex].YValues[0];

                    var pos = e.Location;
                    tooltipMood.Show(((int)yVal).ToString(), PageChart, pos.X, pos.Y - 15);
                }

            }
        }

        private void TimeSpentChart_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                tooltipMood.RemoveAll();
                HitTestResult result = TimeSpentChart.HitTest(e.X, e.Y);
                if (result.ChartElementType == ChartElementType.DataPoint)//If clicked point is data point
                {
                    //MessageBox.Show(result.Series.Points[result.PointIndex].YValues[0]+""); 
                    //MoodChart.Series[0].ToolTip = "hello world from #VALX, #VAL";
                    var yVal = result.Series.Points[result.PointIndex].YValues[0];

                    var pos = e.Location;
                    tooltipMood.Show(((int)yVal).ToString(), TimeSpentChart, pos.X, pos.Y - 15);
                }

            }
        }
    }
}
