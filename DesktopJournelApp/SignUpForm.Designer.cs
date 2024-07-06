namespace DesktopJournelApp
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.SignUplabel = new System.Windows.Forms.Label();
            this.creUserNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordAgainTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.crePasswordTextBox = new System.Windows.Forms.TextBox();
            this.actualSignUpButton = new System.Windows.Forms.Button();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.showPassword_checkBoxSP = new System.Windows.Forms.CheckBox();
            this.passwordAgainLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.crePasswordLabel = new System.Windows.Forms.Label();
            this.creUserNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUplabel
            // 
            this.SignUplabel.AutoSize = true;
            this.SignUplabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUplabel.Location = new System.Drawing.Point(93, 49);
            this.SignUplabel.Name = "SignUplabel";
            this.SignUplabel.Size = new System.Drawing.Size(283, 31);
            this.SignUplabel.TabIndex = 0;
            this.SignUplabel.Text = "Let\'s Sign You Up";
            this.SignUplabel.Click += new System.EventHandler(this.SignUplabel_Click);
            // 
            // creUserNameTextBox
            // 
            this.creUserNameTextBox.Font = new System.Drawing.Font("Footlight MT Light", 10.2F);
            this.creUserNameTextBox.Location = new System.Drawing.Point(224, 115);
            this.creUserNameTextBox.Name = "creUserNameTextBox";
            this.creUserNameTextBox.Size = new System.Drawing.Size(218, 25);
            this.creUserNameTextBox.TabIndex = 3;
            // 
            // passwordAgainTextBox
            // 
            this.passwordAgainTextBox.Font = new System.Drawing.Font("Footlight MT Light", 10.2F);
            this.passwordAgainTextBox.Location = new System.Drawing.Point(224, 237);
            this.passwordAgainTextBox.Name = "passwordAgainTextBox";
            this.passwordAgainTextBox.PasswordChar = '*';
            this.passwordAgainTextBox.Size = new System.Drawing.Size(218, 25);
            this.passwordAgainTextBox.TabIndex = 4;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Font = new System.Drawing.Font("Footlight MT Light", 10.2F);
            this.locationTextBox.Location = new System.Drawing.Point(224, 307);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(218, 25);
            this.locationTextBox.TabIndex = 5;
            this.locationTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // crePasswordTextBox
            // 
            this.crePasswordTextBox.Font = new System.Drawing.Font("Footlight MT Light", 10.2F);
            this.crePasswordTextBox.Location = new System.Drawing.Point(224, 175);
            this.crePasswordTextBox.Name = "crePasswordTextBox";
            this.crePasswordTextBox.PasswordChar = '*';
            this.crePasswordTextBox.Size = new System.Drawing.Size(218, 25);
            this.crePasswordTextBox.TabIndex = 8;
            this.crePasswordTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // actualSignUpButton
            // 
            this.actualSignUpButton.Font = new System.Drawing.Font("Footlight MT Light", 10.2F);
            this.actualSignUpButton.Location = new System.Drawing.Point(304, 366);
            this.actualSignUpButton.Name = "actualSignUpButton";
            this.actualSignUpButton.Size = new System.Drawing.Size(125, 51);
            this.actualSignUpButton.TabIndex = 9;
            this.actualSignUpButton.Text = "Sign Up";
            this.actualSignUpButton.UseVisualStyleBackColor = true;
            this.actualSignUpButton.Click += new System.EventHandler(this.actualSignUpButton_Click);
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.Controls.Add(this.showPassword_checkBoxSP);
            this.SignUpPanel.Controls.Add(this.actualSignUpButton);
            this.SignUpPanel.Controls.Add(this.passwordAgainLabel);
            this.SignUpPanel.Controls.Add(this.locationTextBox);
            this.SignUpPanel.Controls.Add(this.SignUplabel);
            this.SignUpPanel.Controls.Add(this.passwordAgainTextBox);
            this.SignUpPanel.Controls.Add(this.crePasswordTextBox);
            this.SignUpPanel.Controls.Add(this.locationLabel);
            this.SignUpPanel.Controls.Add(this.crePasswordLabel);
            this.SignUpPanel.Controls.Add(this.creUserNameTextBox);
            this.SignUpPanel.Controls.Add(this.creUserNameLabel);
            this.SignUpPanel.Location = new System.Drawing.Point(22, 37);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(471, 458);
            this.SignUpPanel.TabIndex = 11;
            this.SignUpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // showPassword_checkBoxSP
            // 
            this.showPassword_checkBoxSP.AutoSize = true;
            this.showPassword_checkBoxSP.BackColor = System.Drawing.Color.Transparent;
            this.showPassword_checkBoxSP.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword_checkBoxSP.Location = new System.Drawing.Point(304, 268);
            this.showPassword_checkBoxSP.Name = "showPassword_checkBoxSP";
            this.showPassword_checkBoxSP.Size = new System.Drawing.Size(138, 23);
            this.showPassword_checkBoxSP.TabIndex = 11;
            this.showPassword_checkBoxSP.Text = "Show Password";
            this.showPassword_checkBoxSP.UseVisualStyleBackColor = false;
            this.showPassword_checkBoxSP.CheckedChanged += new System.EventHandler(this.showPassword_checkBoxSP_CheckedChanged);
            // 
            // passwordAgainLabel
            // 
            this.passwordAgainLabel.AutoSize = true;
            this.passwordAgainLabel.Font = new System.Drawing.Font("Footlight MT Light", 12F);
            this.passwordAgainLabel.Location = new System.Drawing.Point(25, 237);
            this.passwordAgainLabel.Name = "passwordAgainLabel";
            this.passwordAgainLabel.Size = new System.Drawing.Size(134, 20);
            this.passwordAgainLabel.TabIndex = 10;
            this.passwordAgainLabel.Text = "Password again";
            this.passwordAgainLabel.Click += new System.EventHandler(this.passwordAgainLabel_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Footlight MT Light", 12F);
            this.locationLabel.Location = new System.Drawing.Point(25, 307);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(168, 20);
            this.locationLabel.TabIndex = 6;
            this.locationLabel.Text = "Where do you live?";
            this.locationLabel.Click += new System.EventHandler(this.locationLabel_Click);
            // 
            // crePasswordLabel
            // 
            this.crePasswordLabel.AutoSize = true;
            this.crePasswordLabel.Font = new System.Drawing.Font("Footlight MT Light", 12F);
            this.crePasswordLabel.Location = new System.Drawing.Point(25, 177);
            this.crePasswordLabel.Name = "crePasswordLabel";
            this.crePasswordLabel.Size = new System.Drawing.Size(144, 20);
            this.crePasswordLabel.TabIndex = 7;
            this.crePasswordLabel.Text = "Create password";
            this.crePasswordLabel.Click += new System.EventHandler(this.crePasswordLabel_Click);
            // 
            // creUserNameLabel
            // 
            this.creUserNameLabel.AutoSize = true;
            this.creUserNameLabel.Font = new System.Drawing.Font("Footlight MT Light", 12F);
            this.creUserNameLabel.Location = new System.Drawing.Point(25, 117);
            this.creUserNameLabel.Name = "creUserNameLabel";
            this.creUserNameLabel.Size = new System.Drawing.Size(147, 20);
            this.creUserNameLabel.TabIndex = 1;
            this.creUserNameLabel.Text = "Create username";
            this.creUserNameLabel.Click += new System.EventHandler(this.creUserNameLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(515, 571);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignUpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.Text = "SS";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SignUplabel;
        private System.Windows.Forms.TextBox creUserNameTextBox;
        private System.Windows.Forms.TextBox passwordAgainTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox crePasswordTextBox;
        private System.Windows.Forms.Button actualSignUpButton;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.CheckBox showPassword_checkBoxSP;
        private System.Windows.Forms.Label passwordAgainLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label crePasswordLabel;
        private System.Windows.Forms.Label creUserNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}