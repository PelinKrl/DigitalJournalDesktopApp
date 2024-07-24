namespace DesktopJournelApp
{
    partial class LoginForm
    {
        private const bool V = true;

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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.whoAreYouLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.showPassword_checkBox = new System.Windows.Forms.CheckBox();
            this.logIn_button = new System.Windows.Forms.Button();
            this.signUp_button = new System.Windows.Forms.Button();
            this.logIn_Panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logIn_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Courier New", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(116, 145);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(828, 49);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Your Digital Journal";
            // 
            // whoAreYouLabel
            // 
            this.whoAreYouLabel.AutoSize = true;
            this.whoAreYouLabel.BackColor = System.Drawing.Color.Transparent;
            this.whoAreYouLabel.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoAreYouLabel.Location = new System.Drawing.Point(400, 218);
            this.whoAreYouLabel.Name = "whoAreYouLabel";
            this.whoAreYouLabel.Size = new System.Drawing.Size(281, 39);
            this.whoAreYouLabel.TabIndex = 1;
            this.whoAreYouLabel.Text = "Who Are You?";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(26, 63);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(106, 22);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(26, 149);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(106, 22);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // userName_textBox
            // 
            this.userName_textBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_textBox.Location = new System.Drawing.Point(203, 59);
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.Size = new System.Drawing.Size(343, 30);
            this.userName_textBox.TabIndex = 4;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(203, 149);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(343, 30);
            this.password_textBox.TabIndex = 5;
            // 
            // showPassword_checkBox
            // 
            this.showPassword_checkBox.AutoSize = true;
            this.showPassword_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.showPassword_checkBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword_checkBox.Location = new System.Drawing.Point(408, 201);
            this.showPassword_checkBox.Name = "showPassword_checkBox";
            this.showPassword_checkBox.Size = new System.Drawing.Size(161, 24);
            this.showPassword_checkBox.TabIndex = 6;
            this.showPassword_checkBox.Text = "Show Password";
            this.showPassword_checkBox.UseVisualStyleBackColor = false;
            this.showPassword_checkBox.CheckedChanged += new System.EventHandler(this.showPassword_checkBox_CheckedChanged);
            // 
            // logIn_button
            // 
            this.logIn_button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn_button.Location = new System.Drawing.Point(398, 246);
            this.logIn_button.Name = "logIn_button";
            this.logIn_button.Size = new System.Drawing.Size(162, 44);
            this.logIn_button.TabIndex = 7;
            this.logIn_button.Text = "Log In";
            this.logIn_button.Click += new System.EventHandler(this.logIn_button_Click);
            // 
            // signUp_button
            // 
            this.signUp_button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_button.Location = new System.Drawing.Point(30, 246);
            this.signUp_button.Name = "signUp_button";
            this.signUp_button.Size = new System.Drawing.Size(162, 44);
            this.signUp_button.TabIndex = 8;
            this.signUp_button.Text = "Sign Up";
            this.signUp_button.UseVisualStyleBackColor = true;
            this.signUp_button.Click += new System.EventHandler(this.signUp_button_Click);
            // 
            // logIn_Panel
            // 
            this.logIn_Panel.BackColor = System.Drawing.Color.Transparent;
            this.logIn_Panel.Controls.Add(this.signUp_button);
            this.logIn_Panel.Controls.Add(this.userNameLabel);
            this.logIn_Panel.Controls.Add(this.logIn_button);
            this.logIn_Panel.Controls.Add(this.passwordLabel);
            this.logIn_Panel.Controls.Add(this.showPassword_checkBox);
            this.logIn_Panel.Controls.Add(this.userName_textBox);
            this.logIn_Panel.Controls.Add(this.password_textBox);
            this.logIn_Panel.Location = new System.Drawing.Point(245, 279);
            this.logIn_Panel.Name = "logIn_Panel";
            this.logIn_Panel.Size = new System.Drawing.Size(577, 303);
            this.logIn_Panel.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(723, 604);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 588);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1084, 872);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.whoAreYouLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.logIn_Panel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Journal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.logIn_Panel.ResumeLayout(false);
            this.logIn_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label whoAreYouLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userName_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.CheckBox showPassword_checkBox;
        private System.Windows.Forms.Button logIn_button;
        private System.Windows.Forms.Button signUp_button;
        private System.Windows.Forms.Panel logIn_Panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

