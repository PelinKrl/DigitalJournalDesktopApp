namespace DesktopJournelApp
{
    partial class GraphsPageUserControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GraphsPanel = new System.Windows.Forms.Panel();
            this.MoodChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChooseFinnishDate = new System.Windows.Forms.Label();
            this.ChooseStartDate = new System.Windows.Forms.Label();
            this.TimeSpentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WaterChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GViewButton = new System.Windows.Forms.Button();
            this.GFinishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GraphsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoodChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSpentChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphsPanel
            // 
            this.GraphsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GraphsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GraphsPanel.Controls.Add(this.MoodChart);
            this.GraphsPanel.Controls.Add(this.ChooseFinnishDate);
            this.GraphsPanel.Controls.Add(this.ChooseStartDate);
            this.GraphsPanel.Controls.Add(this.TimeSpentChart);
            this.GraphsPanel.Controls.Add(this.PageChart);
            this.GraphsPanel.Controls.Add(this.WaterChart);
            this.GraphsPanel.Controls.Add(this.GViewButton);
            this.GraphsPanel.Controls.Add(this.GFinishDateTimePicker);
            this.GraphsPanel.Controls.Add(this.GStartDateTimePicker);
            this.GraphsPanel.Location = new System.Drawing.Point(4, 4);
            this.GraphsPanel.Name = "GraphsPanel";
            this.GraphsPanel.Size = new System.Drawing.Size(1845, 762);
            this.GraphsPanel.TabIndex = 0;
            // 
            // MoodChart
            // 
            this.MoodChart.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.MoodChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.MoodChart.Legends.Add(legend5);
            this.MoodChart.Location = new System.Drawing.Point(281, 3);
            this.MoodChart.Name = "MoodChart";
            this.MoodChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series8.Legend = "Legend1";
            series8.Name = "Mood";
            series8.YValuesPerPoint = 2;
            this.MoodChart.Series.Add(series8);
            this.MoodChart.Size = new System.Drawing.Size(760, 391);
            this.MoodChart.TabIndex = 9;
            this.MoodChart.Text = "chart2";
            this.MoodChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MoodChart_MouseClick);
            // 
            // ChooseFinnishDate
            // 
            this.ChooseFinnishDate.AutoSize = true;
            this.ChooseFinnishDate.BackColor = System.Drawing.Color.Transparent;
            this.ChooseFinnishDate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFinnishDate.Location = new System.Drawing.Point(24, 122);
            this.ChooseFinnishDate.Name = "ChooseFinnishDate";
            this.ChooseFinnishDate.Size = new System.Drawing.Size(226, 22);
            this.ChooseFinnishDate.TabIndex = 8;
            this.ChooseFinnishDate.Text = "Choose Finish Date";
            // 
            // ChooseStartDate
            // 
            this.ChooseStartDate.AutoSize = true;
            this.ChooseStartDate.BackColor = System.Drawing.Color.Transparent;
            this.ChooseStartDate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseStartDate.Location = new System.Drawing.Point(20, 45);
            this.ChooseStartDate.Name = "ChooseStartDate";
            this.ChooseStartDate.Size = new System.Drawing.Size(214, 22);
            this.ChooseStartDate.TabIndex = 7;
            this.ChooseStartDate.Text = "Choose Start Date";
            // 
            // TimeSpentChart
            // 
            this.TimeSpentChart.BackColor = System.Drawing.Color.Transparent;
            this.TimeSpentChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.TimeSpentChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.TimeSpentChart.Legends.Add(legend6);
            this.TimeSpentChart.Location = new System.Drawing.Point(1047, 384);
            this.TimeSpentChart.Name = "TimeSpentChart";
            this.TimeSpentChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Minutes Of Work";
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Minutes Of Watch";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Minutes Of Exercises";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Minutes Of Sleep";
            this.TimeSpentChart.Series.Add(series9);
            this.TimeSpentChart.Series.Add(series10);
            this.TimeSpentChart.Series.Add(series11);
            this.TimeSpentChart.Series.Add(series12);
            this.TimeSpentChart.Size = new System.Drawing.Size(795, 380);
            this.TimeSpentChart.TabIndex = 6;
            this.TimeSpentChart.Text = "chart4";
            this.TimeSpentChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TimeSpentChart_MouseClick);
            // 
            // PageChart
            // 
            this.PageChart.BackColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            this.PageChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.PageChart.Legends.Add(legend7);
            this.PageChart.Location = new System.Drawing.Point(1091, -4);
            this.PageChart.Name = "PageChart";
            this.PageChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Page";
            series13.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.PageChart.Series.Add(series13);
            this.PageChart.Size = new System.Drawing.Size(629, 395);
            this.PageChart.TabIndex = 5;
            this.PageChart.Text = "chart3";
            this.PageChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PageChart_MouseClick);
            // 
            // WaterChart
            // 
            this.WaterChart.BackColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.WaterChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.WaterChart.Legends.Add(legend8);
            this.WaterChart.Location = new System.Drawing.Point(315, 355);
            this.WaterChart.Name = "WaterChart";
            this.WaterChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series14.BorderColor = System.Drawing.Color.Transparent;
            series14.ChartArea = "ChartArea1";
            series14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series14.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series14.Legend = "Legend1";
            series14.MarkerBorderColor = System.Drawing.Color.White;
            series14.Name = "Water";
            series14.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series14.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.WaterChart.Series.Add(series14);
            this.WaterChart.Size = new System.Drawing.Size(735, 404);
            this.WaterChart.TabIndex = 4;
            this.WaterChart.Text = "chart2";
            title2.Name = "Page Of books";
            this.WaterChart.Titles.Add(title2);
            this.WaterChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WaterChart_MouseClick);
            // 
            // GViewButton
            // 
            this.GViewButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GViewButton.Location = new System.Drawing.Point(153, 191);
            this.GViewButton.Name = "GViewButton";
            this.GViewButton.Size = new System.Drawing.Size(93, 35);
            this.GViewButton.TabIndex = 2;
            this.GViewButton.Text = "View";
            this.GViewButton.UseVisualStyleBackColor = true;
            this.GViewButton.Click += new System.EventHandler(this.GViewButton_Click);
            // 
            // GFinishDateTimePicker
            // 
            this.GFinishDateTimePicker.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GFinishDateTimePicker.Location = new System.Drawing.Point(28, 147);
            this.GFinishDateTimePicker.Name = "GFinishDateTimePicker";
            this.GFinishDateTimePicker.Size = new System.Drawing.Size(218, 27);
            this.GFinishDateTimePicker.TabIndex = 1;
            // 
            // GStartDateTimePicker
            // 
            this.GStartDateTimePicker.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GStartDateTimePicker.Location = new System.Drawing.Point(24, 72);
            this.GStartDateTimePicker.Name = "GStartDateTimePicker";
            this.GStartDateTimePicker.Size = new System.Drawing.Size(218, 27);
            this.GStartDateTimePicker.TabIndex = 0;
            // 
            // GraphsPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GraphsPanel);
            this.Name = "GraphsPageUserControl";
            this.Size = new System.Drawing.Size(1852, 768);
            this.GraphsPanel.ResumeLayout(false);
            this.GraphsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoodChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSpentChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GraphsPanel;
        private System.Windows.Forms.Button GViewButton;
        private System.Windows.Forms.DateTimePicker GFinishDateTimePicker;
        private System.Windows.Forms.DateTimePicker GStartDateTimePicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart TimeSpentChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart WaterChart;
        private System.Windows.Forms.Label ChooseFinnishDate;
        private System.Windows.Forms.Label ChooseStartDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart MoodChart;
    }
}
