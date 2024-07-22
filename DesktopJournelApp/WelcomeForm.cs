using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;

namespace DesktopJournelApp
{
    public partial class LoginForm : Form
    {


        public LoginForm()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(this.LoginForm_Paint);
            this.Resize += new EventHandler(this.LoginForm_Resize);
            
        }


        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;
            if (rect.Width == 0 || rect.Height == 0) return;

            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.BlueViolet, Color.White, 90F))
            {
                g.FillRectangle(brush, rect);
            }
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); // Redraw the form when it's resized
            CenterLabel();
        }

        private void CenterLabel()
        {
            if (welcomeLabel != null)
            {
                welcomeLabel.Left = (this.ClientSize.Width - welcomeLabel.Width) / 2;
                welcomeLabel.Top = 100; 
            }
            if (whoAreYouLabel != null)
            {
                whoAreYouLabel.Left = (this.ClientSize.Width - whoAreYouLabel.Width) / 2;
                whoAreYouLabel.Top = 140; 
            }
            if (logIn_Panel != null)
            {
                logIn_Panel.Left = (this.ClientSize.Width - logIn_Panel.Width) / 2;
                logIn_Panel.Top = 190; 
            }


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SQL.Connect();
        }

        private void showPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            password_textBox.PasswordChar = showPassword_checkBox.Checked ? '\0' : '*'; 
        }

        
       

        private void logIn_button_Click(object sender, EventArgs e)
        {

            string username = userName_textBox.Text;
            string password = password_textBox.Text;
            int id = SQL.ValidateUser(username, password);
            if (id!=-1)
            {
                MainAppForm mainAppForm = new MainAppForm(id);
                mainAppForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
            
            
           

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQL.Disconnect();
        }

        private void signUp_button_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show(); 
        }

       

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logIn_button.PerformClick();
            }
        }
    }


}

