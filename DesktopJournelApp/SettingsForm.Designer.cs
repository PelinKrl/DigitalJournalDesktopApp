namespace DesktopJournelApp
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SettingMenuPanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChangeUserNameButton = new System.Windows.Forms.Button();
            this.AddGenreBookButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ChangeCityButton = new System.Windows.Forms.Button();
            this.ChosenSettingPanel = new System.Windows.Forms.Panel();
            this.SettingMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingMenuPanel
            // 
            this.SettingMenuPanel.Controls.Add(this.LogOutButton);
            this.SettingMenuPanel.Controls.Add(this.pictureBox1);
            this.SettingMenuPanel.Controls.Add(this.ChangeUserNameButton);
            this.SettingMenuPanel.Controls.Add(this.AddGenreBookButton);
            this.SettingMenuPanel.Controls.Add(this.ChangePasswordButton);
            this.SettingMenuPanel.Controls.Add(this.ChangeCityButton);
            this.SettingMenuPanel.Location = new System.Drawing.Point(12, 12);
            this.SettingMenuPanel.Name = "SettingMenuPanel";
            this.SettingMenuPanel.Size = new System.Drawing.Size(262, 540);
            this.SettingMenuPanel.TabIndex = 6;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(27, 349);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(204, 62);
            this.LogOutButton.TabIndex = 11;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 429);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ChangeUserNameButton
            // 
            this.ChangeUserNameButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeUserNameButton.Location = new System.Drawing.Point(27, 34);
            this.ChangeUserNameButton.Name = "ChangeUserNameButton";
            this.ChangeUserNameButton.Size = new System.Drawing.Size(204, 61);
            this.ChangeUserNameButton.TabIndex = 0;
            this.ChangeUserNameButton.Text = "Change User Name";
            this.ChangeUserNameButton.UseVisualStyleBackColor = true;
            this.ChangeUserNameButton.Click += new System.EventHandler(this.ChangeUserNameButton_Click);
            // 
            // AddGenreBookButton
            // 
            this.AddGenreBookButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGenreBookButton.Location = new System.Drawing.Point(27, 267);
            this.AddGenreBookButton.Name = "AddGenreBookButton";
            this.AddGenreBookButton.Size = new System.Drawing.Size(204, 66);
            this.AddGenreBookButton.TabIndex = 8;
            this.AddGenreBookButton.Text = "Add Genre / Delete";
            this.AddGenreBookButton.UseVisualStyleBackColor = true;
            this.AddGenreBookButton.Click += new System.EventHandler(this.AddGenreBookButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(27, 112);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(204, 60);
            this.ChangePasswordButton.TabIndex = 6;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangeCityButton
            // 
            this.ChangeCityButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeCityButton.Location = new System.Drawing.Point(27, 188);
            this.ChangeCityButton.Name = "ChangeCityButton";
            this.ChangeCityButton.Size = new System.Drawing.Size(204, 62);
            this.ChangeCityButton.TabIndex = 7;
            this.ChangeCityButton.Text = "Change City";
            this.ChangeCityButton.UseVisualStyleBackColor = true;
            this.ChangeCityButton.Click += new System.EventHandler(this.ChangeCityButton_Click);
            // 
            // ChosenSettingPanel
            // 
            this.ChosenSettingPanel.Location = new System.Drawing.Point(292, 12);
            this.ChosenSettingPanel.Name = "ChosenSettingPanel";
            this.ChosenSettingPanel.Size = new System.Drawing.Size(701, 540);
            this.ChosenSettingPanel.TabIndex = 7;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 564);
            this.Controls.Add(this.ChosenSettingPanel);
            this.Controls.Add(this.SettingMenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.SettingMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SettingMenuPanel;
        private System.Windows.Forms.Panel ChosenSettingPanel;
        private System.Windows.Forms.Button ChangeUserNameButton;
        private System.Windows.Forms.Button AddGenreBookButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button ChangeCityButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogOutButton;
    }
}