namespace DesktopJournelApp
{
    partial class TaskPlannerPageUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskPlannerPageUserControl));
            this.TPListTasksButton = new System.Windows.Forms.Button();
            this.TPSearchComboBox = new System.Windows.Forms.ComboBox();
            this.TPDeleteButton = new System.Windows.Forms.Button();
            this.TPUpdateButton = new System.Windows.Forms.Button();
            this.TPSaveButton = new System.Windows.Forms.Button();
            this.WatchListPMPanel = new System.Windows.Forms.Panel();
            this.TPPrioCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.TPListStateButton = new System.Windows.Forms.Button();
            this.TPStateFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TPFilterByPrioButton = new System.Windows.Forms.Button();
            this.TPPriorityButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TPdataGridView = new System.Windows.Forms.DataGridView();
            this.TaskPlannerTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TPPrioComboBox = new System.Windows.Forms.ComboBox();
            this.TPTaskTagComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TPStateCheckBox = new System.Windows.Forms.CheckBox();
            this.TPFilterByDatesButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TPFinishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TPStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TPDeadlineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TPSearchTextBox = new System.Windows.Forms.TextBox();
            this.TPSearchButton = new System.Windows.Forms.Button();
            this.TPDescTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TPNameTextBox = new System.Windows.Forms.TextBox();
            this.MovieTvSName = new System.Windows.Forms.Label();
            this.WatchListPMPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TPListTasksButton
            // 
            this.TPListTasksButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPListTasksButton.Location = new System.Drawing.Point(789, 534);
            this.TPListTasksButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPListTasksButton.Name = "TPListTasksButton";
            this.TPListTasksButton.Size = new System.Drawing.Size(127, 55);
            this.TPListTasksButton.TabIndex = 5;
            this.TPListTasksButton.Text = "List Tasks";
            this.TPListTasksButton.UseVisualStyleBackColor = true;
            this.TPListTasksButton.Click += new System.EventHandler(this.TPListTasksButton_Click);
            // 
            // TPSearchComboBox
            // 
            this.TPSearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TPSearchComboBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPSearchComboBox.FormattingEnabled = true;
            this.TPSearchComboBox.Items.AddRange(new object[] {
            "Home",
            "Work",
            "Fun",
            "Hobby",
            "Travel",
            "Event",
            "Chores ",
            "Birthdays",
            "Plan",
            "All"});
            this.TPSearchComboBox.Location = new System.Drawing.Point(3, 32);
            this.TPSearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPSearchComboBox.Name = "TPSearchComboBox";
            this.TPSearchComboBox.Size = new System.Drawing.Size(179, 28);
            this.TPSearchComboBox.TabIndex = 21;
            // 
            // TPDeleteButton
            // 
            this.TPDeleteButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPDeleteButton.Location = new System.Drawing.Point(475, 528);
            this.TPDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPDeleteButton.Name = "TPDeleteButton";
            this.TPDeleteButton.Size = new System.Drawing.Size(124, 55);
            this.TPDeleteButton.TabIndex = 20;
            this.TPDeleteButton.Text = "Delete";
            this.TPDeleteButton.UseVisualStyleBackColor = true;
            this.TPDeleteButton.Click += new System.EventHandler(this.TPDeleteButton_Click);
            // 
            // TPUpdateButton
            // 
            this.TPUpdateButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPUpdateButton.Location = new System.Drawing.Point(331, 528);
            this.TPUpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPUpdateButton.Name = "TPUpdateButton";
            this.TPUpdateButton.Size = new System.Drawing.Size(124, 55);
            this.TPUpdateButton.TabIndex = 19;
            this.TPUpdateButton.Text = "Update";
            this.TPUpdateButton.UseVisualStyleBackColor = true;
            this.TPUpdateButton.Click += new System.EventHandler(this.TPUpdateButton_Click);
            // 
            // TPSaveButton
            // 
            this.TPSaveButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPSaveButton.Location = new System.Drawing.Point(624, 528);
            this.TPSaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPSaveButton.Name = "TPSaveButton";
            this.TPSaveButton.Size = new System.Drawing.Size(124, 55);
            this.TPSaveButton.TabIndex = 16;
            this.TPSaveButton.Text = "Save";
            this.TPSaveButton.UseVisualStyleBackColor = true;
            this.TPSaveButton.Click += new System.EventHandler(this.TPSaveButton_Click);
            // 
            // WatchListPMPanel
            // 
            this.WatchListPMPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WatchListPMPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WatchListPMPanel.Controls.Add(this.TPPrioCheckedListBox);
            this.WatchListPMPanel.Controls.Add(this.TPListStateButton);
            this.WatchListPMPanel.Controls.Add(this.TPStateFilterComboBox);
            this.WatchListPMPanel.Controls.Add(this.label7);
            this.WatchListPMPanel.Controls.Add(this.TPFilterByPrioButton);
            this.WatchListPMPanel.Controls.Add(this.TPPriorityButton);
            this.WatchListPMPanel.Controls.Add(this.pictureBox1);
            this.WatchListPMPanel.Controls.Add(this.TPdataGridView);
            this.WatchListPMPanel.Controls.Add(this.TaskPlannerTitleLabel);
            this.WatchListPMPanel.Controls.Add(this.panel1);
            this.WatchListPMPanel.Controls.Add(this.TPListTasksButton);
            this.WatchListPMPanel.Location = new System.Drawing.Point(3, 2);
            this.WatchListPMPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WatchListPMPanel.Name = "WatchListPMPanel";
            this.WatchListPMPanel.Size = new System.Drawing.Size(1824, 682);
            this.WatchListPMPanel.TabIndex = 1;
            // 
            // TPPrioCheckedListBox
            // 
            this.TPPrioCheckedListBox.CheckOnClick = true;
            this.TPPrioCheckedListBox.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPPrioCheckedListBox.FormattingEnabled = true;
            this.TPPrioCheckedListBox.Items.AddRange(new object[] {
            "Just For Fun",
            "Not Important",
            "Important",
            "Very Important",
            "ASAP",
            "Matter of Life or Death "});
            this.TPPrioCheckedListBox.Location = new System.Drawing.Point(1586, 53);
            this.TPPrioCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPPrioCheckedListBox.Name = "TPPrioCheckedListBox";
            this.TPPrioCheckedListBox.Size = new System.Drawing.Size(216, 106);
            this.TPPrioCheckedListBox.TabIndex = 30;
            this.TPPrioCheckedListBox.Visible = false;
            // 
            // TPListStateButton
            // 
            this.TPListStateButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPListStateButton.Location = new System.Drawing.Point(1155, 15);
            this.TPListStateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPListStateButton.Name = "TPListStateButton";
            this.TPListStateButton.Size = new System.Drawing.Size(115, 31);
            this.TPListStateButton.TabIndex = 29;
            this.TPListStateButton.Text = "List State";
            this.TPListStateButton.UseVisualStyleBackColor = true;
            this.TPListStateButton.Click += new System.EventHandler(this.TPListStateButton_Click);
            // 
            // TPStateFilterComboBox
            // 
            this.TPStateFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TPStateFilterComboBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPStateFilterComboBox.FormattingEnabled = true;
            this.TPStateFilterComboBox.Items.AddRange(new object[] {
            "Not Done ",
            "Done"});
            this.TPStateFilterComboBox.Location = new System.Drawing.Point(968, 16);
            this.TPStateFilterComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPStateFilterComboBox.Name = "TPStateFilterComboBox";
            this.TPStateFilterComboBox.Size = new System.Drawing.Size(171, 28);
            this.TPStateFilterComboBox.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(785, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Choose State";
            // 
            // TPFilterByPrioButton
            // 
            this.TPFilterByPrioButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPFilterByPrioButton.Location = new System.Drawing.Point(1489, 10);
            this.TPFilterByPrioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPFilterByPrioButton.Name = "TPFilterByPrioButton";
            this.TPFilterByPrioButton.Size = new System.Drawing.Size(91, 39);
            this.TPFilterByPrioButton.TabIndex = 26;
            this.TPFilterByPrioButton.Text = "Filter";
            this.TPFilterByPrioButton.UseVisualStyleBackColor = true;
            this.TPFilterByPrioButton.Click += new System.EventHandler(this.TPFilterByPrioButton_Click);
            // 
            // TPPriorityButton
            // 
            this.TPPriorityButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPPriorityButton.Location = new System.Drawing.Point(1586, 9);
            this.TPPriorityButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPPriorityButton.Name = "TPPriorityButton";
            this.TPPriorityButton.Size = new System.Drawing.Size(215, 39);
            this.TPPriorityButton.TabIndex = 25;
            this.TPPriorityButton.Text = "Priority";
            this.TPPriorityButton.UseVisualStyleBackColor = true;
            this.TPPriorityButton.Click += new System.EventHandler(this.TPPriorityButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1619, 517);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // TPdataGridView
            // 
            this.TPdataGridView.AllowUserToAddRows = false;
            this.TPdataGridView.AllowUserToDeleteRows = false;
            this.TPdataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TPdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TPdataGridView.Location = new System.Drawing.Point(789, 53);
            this.TPdataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPdataGridView.Name = "TPdataGridView";
            this.TPdataGridView.ReadOnly = true;
            this.TPdataGridView.RowHeadersWidth = 51;
            this.TPdataGridView.RowTemplate.Height = 24;
            this.TPdataGridView.Size = new System.Drawing.Size(1013, 464);
            this.TPdataGridView.TabIndex = 2;
            this.TPdataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TPdataGridView_RowHeaderMouseClick);
            // 
            // TaskPlannerTitleLabel
            // 
            this.TaskPlannerTitleLabel.AutoSize = true;
            this.TaskPlannerTitleLabel.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskPlannerTitleLabel.Location = new System.Drawing.Point(3, 9);
            this.TaskPlannerTitleLabel.Name = "TaskPlannerTitleLabel";
            this.TaskPlannerTitleLabel.Size = new System.Drawing.Size(257, 37);
            this.TaskPlannerTitleLabel.TabIndex = 1;
            this.TaskPlannerTitleLabel.Text = "Task Planner";
            this.TaskPlannerTitleLabel.Click += new System.EventHandler(this.TaskPlannerTitleLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TPPrioComboBox);
            this.panel1.Controls.Add(this.TPTaskTagComboBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TPStateCheckBox);
            this.panel1.Controls.Add(this.TPFilterByDatesButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TPFinishDateTimePicker);
            this.panel1.Controls.Add(this.TPStartDateTimePicker);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TPDeadlineDateTimePicker);
            this.panel1.Controls.Add(this.TPSearchComboBox);
            this.panel1.Controls.Add(this.TPDeleteButton);
            this.panel1.Controls.Add(this.TPUpdateButton);
            this.panel1.Controls.Add(this.TPSaveButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TPSearchTextBox);
            this.panel1.Controls.Add(this.TPSearchButton);
            this.panel1.Controls.Add(this.TPDescTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TPNameTextBox);
            this.panel1.Controls.Add(this.MovieTvSName);
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 601);
            this.panel1.TabIndex = 0;
            // 
            // TPPrioComboBox
            // 
            this.TPPrioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TPPrioComboBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPPrioComboBox.FormattingEnabled = true;
            this.TPPrioComboBox.Items.AddRange(new object[] {
            "Just For Fun",
            "Not Important",
            "Important",
            "Very Important",
            "ASAP",
            "Matter of Life or Death "});
            this.TPPrioComboBox.Location = new System.Drawing.Point(177, 245);
            this.TPPrioComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPPrioComboBox.Name = "TPPrioComboBox";
            this.TPPrioComboBox.Size = new System.Drawing.Size(281, 28);
            this.TPPrioComboBox.TabIndex = 32;
            // 
            // TPTaskTagComboBox
            // 
            this.TPTaskTagComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TPTaskTagComboBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPTaskTagComboBox.FormattingEnabled = true;
            this.TPTaskTagComboBox.Items.AddRange(new object[] {
            "Home",
            "Work",
            "Fun",
            "Hobby",
            "Travel",
            "Event",
            "Chores ",
            "Birthdays",
            "Plan"});
            this.TPTaskTagComboBox.Location = new System.Drawing.Point(565, 196);
            this.TPTaskTagComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPTaskTagComboBox.Name = "TPTaskTagComboBox";
            this.TPTaskTagComboBox.Size = new System.Drawing.Size(179, 28);
            this.TPTaskTagComboBox.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Task Tag";
            // 
            // TPStateCheckBox
            // 
            this.TPStateCheckBox.AutoSize = true;
            this.TPStateCheckBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPStateCheckBox.Location = new System.Drawing.Point(665, 91);
            this.TPStateCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.TPStateCheckBox.Name = "TPStateCheckBox";
            this.TPStateCheckBox.Size = new System.Drawing.Size(80, 26);
            this.TPStateCheckBox.TabIndex = 29;
            this.TPStateCheckBox.Text = "Done";
            this.TPStateCheckBox.UseVisualStyleBackColor = true;
            // 
            // TPFilterByDatesButton
            // 
            this.TPFilterByDatesButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPFilterByDatesButton.Location = new System.Drawing.Point(270, 432);
            this.TPFilterByDatesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPFilterByDatesButton.Name = "TPFilterByDatesButton";
            this.TPFilterByDatesButton.Size = new System.Drawing.Size(124, 37);
            this.TPFilterByDatesButton.TabIndex = 28;
            this.TPFilterByDatesButton.Text = "Filter";
            this.TPFilterByDatesButton.UseVisualStyleBackColor = true;
            this.TPFilterByDatesButton.Click += new System.EventHandler(this.TPFilterByDatesButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Filter By Dates";
            // 
            // TPFinishDateTimePicker
            // 
            this.TPFinishDateTimePicker.CalendarFont = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPFinishDateTimePicker.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPFinishDateTimePicker.Location = new System.Drawing.Point(177, 401);
            this.TPFinishDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPFinishDateTimePicker.Name = "TPFinishDateTimePicker";
            this.TPFinishDateTimePicker.Size = new System.Drawing.Size(217, 27);
            this.TPFinishDateTimePicker.TabIndex = 26;
            // 
            // TPStartDateTimePicker
            // 
            this.TPStartDateTimePicker.CalendarFont = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPStartDateTimePicker.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPStartDateTimePicker.Location = new System.Drawing.Point(177, 362);
            this.TPStartDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPStartDateTimePicker.Name = "TPStartDateTimePicker";
            this.TPStartDateTimePicker.Size = new System.Drawing.Size(217, 27);
            this.TPStartDateTimePicker.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Finish Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Start Date";
            // 
            // TPDeadlineDateTimePicker
            // 
            this.TPDeadlineDateTimePicker.CalendarFont = new System.Drawing.Font("Footlight MT Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPDeadlineDateTimePicker.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold);
            this.TPDeadlineDateTimePicker.Location = new System.Drawing.Point(177, 196);
            this.TPDeadlineDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPDeadlineDateTimePicker.Name = "TPDeadlineDateTimePicker";
            this.TPDeadlineDateTimePicker.Size = new System.Drawing.Size(217, 27);
            this.TPDeadlineDateTimePicker.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Priority";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Deadline";
            // 
            // TPSearchTextBox
            // 
            this.TPSearchTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPSearchTextBox.Location = new System.Drawing.Point(200, 28);
            this.TPSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPSearchTextBox.Name = "TPSearchTextBox";
            this.TPSearchTextBox.Size = new System.Drawing.Size(424, 30);
            this.TPSearchTextBox.TabIndex = 8;
            // 
            // TPSearchButton
            // 
            this.TPSearchButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPSearchButton.Location = new System.Drawing.Point(643, 25);
            this.TPSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPSearchButton.Name = "TPSearchButton";
            this.TPSearchButton.Size = new System.Drawing.Size(105, 38);
            this.TPSearchButton.TabIndex = 7;
            this.TPSearchButton.Text = "Search";
            this.TPSearchButton.UseVisualStyleBackColor = true;
            this.TPSearchButton.Click += new System.EventHandler(this.TPSearchButton_Click);
            // 
            // TPDescTextBox
            // 
            this.TPDescTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPDescTextBox.Location = new System.Drawing.Point(177, 140);
            this.TPDescTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPDescTextBox.Name = "TPDescTextBox";
            this.TPDescTextBox.Size = new System.Drawing.Size(567, 30);
            this.TPDescTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // TPNameTextBox
            // 
            this.TPNameTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPNameTextBox.Location = new System.Drawing.Point(177, 87);
            this.TPNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPNameTextBox.Name = "TPNameTextBox";
            this.TPNameTextBox.Size = new System.Drawing.Size(447, 30);
            this.TPNameTextBox.TabIndex = 2;
            // 
            // MovieTvSName
            // 
            this.MovieTvSName.AutoSize = true;
            this.MovieTvSName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTvSName.Location = new System.Drawing.Point(4, 94);
            this.MovieTvSName.Name = "MovieTvSName";
            this.MovieTvSName.Size = new System.Drawing.Size(130, 22);
            this.MovieTvSName.TabIndex = 0;
            this.MovieTvSName.Text = "Task Name ";
            // 
            // TaskPlannerPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WatchListPMPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskPlannerPageUserControl";
            this.Size = new System.Drawing.Size(1993, 827);
            this.WatchListPMPanel.ResumeLayout(false);
            this.WatchListPMPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TPListTasksButton;
        private System.Windows.Forms.ComboBox TPSearchComboBox;
        private System.Windows.Forms.Button TPDeleteButton;
        private System.Windows.Forms.Button TPUpdateButton;
        private System.Windows.Forms.Button TPSaveButton;
        private System.Windows.Forms.Panel WatchListPMPanel;
        private System.Windows.Forms.Button TPListStateButton;
        private System.Windows.Forms.ComboBox TPStateFilterComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button TPFilterByPrioButton;
        private System.Windows.Forms.Button TPPriorityButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView TPdataGridView;
        private System.Windows.Forms.Label TaskPlannerTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TPSearchTextBox;
        private System.Windows.Forms.Button TPSearchButton;
        private System.Windows.Forms.TextBox TPDescTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TPNameTextBox;
        private System.Windows.Forms.Label MovieTvSName;
        private System.Windows.Forms.DateTimePicker TPDeadlineDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TPFilterByDatesButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker TPFinishDateTimePicker;
        private System.Windows.Forms.DateTimePicker TPStartDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox TPStateCheckBox;
        private System.Windows.Forms.ComboBox TPTaskTagComboBox;
        private System.Windows.Forms.ComboBox TPPrioComboBox;
        private System.Windows.Forms.CheckedListBox TPPrioCheckedListBox;
    }
}
