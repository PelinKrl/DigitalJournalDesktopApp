using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopJournelApp
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void creUserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void crePasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void actualSignUpButton_Click(object sender, EventArgs e)
        {
            string username = creUserNameTextBox.Text;
            string password = crePasswordTextBox.Text;
            string location = locationTextBox.Text;
            string password2 = passwordAgainTextBox.Text;

            if (username != string.Empty && password != string.Empty && password2!=string.Empty && location != string.Empty)
            {
                if(SQL.CheckUsernameExists(username))
                {
                    MessageBox.Show("The username is already taken. Please choose a different username.");
                }
                else {
                    if (password == password2)
                    {
                        bool isSuccess = SQL.InsertUser(username, password, location);
                        if (isSuccess)
                        {
                            MessageBox.Show("User registered successfully.");

                            creUserNameTextBox.Clear();
                            crePasswordTextBox.Clear();
                            locationTextBox.Clear();
                            passwordAgainTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while registering the user.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your password doesn't match");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please make sure that you have entered all informations");
            }

        }

        private void SignUplabel_Click(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void showPassword_checkBoxSP_CheckedChanged(object sender, EventArgs e)
        {
           crePasswordTextBox.PasswordChar = showPassword_checkBoxSP.Checked ? '\0' : '*';
           passwordAgainTextBox.PasswordChar = showPassword_checkBoxSP.Checked ? '\0' : '*';
        }

      
        private void locationLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordAgainLabel_Click(object sender, EventArgs e)
        {

        }

        private void creUserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
