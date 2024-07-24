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
    public partial class ChangeProfileValuesUserControl : UserControl
    {
        public ChangeProfileValuesUserControl()
        {
            InitializeComponent();
        }

        public void ShowChangeUserName()
        {
            CPEnterUserNameLabel.Visible = true; // default true for each one
            CPUserNameTextBox.Visible = true;
            CPShowCheckBox1.Visible = true;

            CPENterNewUNlabel.Visible = true; // spesific to the method
            CPEnterNewUserNameTextBox.Visible=true;

            CPEnterNewPasswordLabel.Visible = false;
            CPNewPasswordTextBox.Visible = false;

            CPEnterNewPasswordALabel.Visible = false;
            CPNewPasswordAgainTextBox.Visible = false;
            CPShowCheckBox2.Visible = false;

            CPEnterCityLabel.Visible = false;
            SettingsCityTextBox.Visible = false;

        }

        public void ShowChangePassword() 
        {
            CPEnterUserNameLabel.Visible = true; // default true for each one
            CPUserNameTextBox.Visible = true;
            CPShowCheckBox1.Visible = true;

            CPENterNewUNlabel.Visible = false; // spesific to the method
            CPEnterNewUserNameTextBox.Visible = false;

            CPEnterNewPasswordLabel.Visible = true;
            CPNewPasswordTextBox.Visible = true;
            CPShowCheckBox2.Visible = true;

            CPEnterNewPasswordALabel.Visible = true;
            CPNewPasswordAgainTextBox.Visible = true;

            CPEnterCityLabel.Visible = false;
            SettingsCityTextBox.Visible = false;

        }

        public void ShowChangeCity()
        {
            CPEnterUserNameLabel.Visible = true; // default true for each one
            CPUserNameTextBox.Visible = true;
            CPShowCheckBox1.Visible = true;

            CPENterNewUNlabel.Visible = false; // spesific to the method
            CPEnterNewUserNameTextBox.Visible = false;

            CPEnterNewPasswordLabel.Visible = false;
            CPNewPasswordTextBox.Visible = false;

            CPEnterNewPasswordALabel.Visible = false;
            CPNewPasswordAgainTextBox.Visible = false;
            CPShowCheckBox2.Visible = false;

            CPEnterCityLabel.Visible = true;
            SettingsCityTextBox.Visible = true;

            CPEnterCityLabel.Location = new Point(12, 210);
            SettingsCityTextBox.Location = new Point(262, 210);
            //SettingsCityTextBox.Size = new Size(273, 27); 

        }

        public void HandleSaveButtonClick(string operation)
        {
            string username = CPUserNameTextBox.Text;
            string password = CPPasswordTextBox.Text;
            int userId = SQL.ValidateUser(username, password);

            if (userId != -1)
            {
                switch (operation)
                {
                    case "ChangeUserName":
                        string newUsername = CPEnterNewUserNameTextBox.Text;
                        if (!string.IsNullOrEmpty(newUsername))
                        {
                            SQL.UpdateUserName(userId, newUsername);
                            //MessageBox.Show("Username updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Please enter a new username.");
                        }
                        break;

                    case "ChangePassword":
                        string newPassword = CPNewPasswordTextBox.Text;
                        string newPasswordAgain = CPNewPasswordAgainTextBox.Text;
                        if (newPassword == newPasswordAgain && !string.IsNullOrEmpty(newPassword))
                        {
                            SQL.UpdateUserPassword(username, newPassword);
                            //MessageBox.Show("Password updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match or are empty.");
                        }
                        break;

                    case "ChangeCity":
                        string newCity = SettingsCityTextBox.Text;
                       
                        if (!string.IsNullOrEmpty(newCity))
                        {
                            SQL.UpdateUserCity(userId, newCity);
                            //MessageBox.Show("City updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Please enter a new city.");
                        }
                        break;

                    default:
                        MessageBox.Show("Invalid operation.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

            CPUserNameTextBox.Clear();
            CPPasswordTextBox.Clear();
            CPNewPasswordTextBox.Clear();
            CPNewPasswordAgainTextBox.Clear();
            CPEnterNewUserNameTextBox.Clear();
            SettingsCityTextBox.Clear(); 


        }


        private void CPShowCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CPPasswordTextBox.PasswordChar = CPShowCheckBox1.Checked ? '\0' : '*';
        }

        private void CPShowCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CPNewPasswordTextBox.PasswordChar = CPShowCheckBox2.Checked ? '\0' : '*';
            CPNewPasswordAgainTextBox.PasswordChar = CPShowCheckBox2.Checked ? '\0' : '*';
        }

        private void CPSaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
