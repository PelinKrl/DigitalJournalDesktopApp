using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopJournelApp;

namespace DesktopJournelApp
{
    public partial class SettingsForm : Form
    {
        private ChangeProfileValuesUserControl changePV; 
        private AddGenreSettingUserControl addGenre;
        private string currentOperation;
        

        public SettingsForm()
        {
            InitializeComponent();
            InitializeChangeProfilePage();
            InitializeAddGenrePage();
            
        }


        private void InitializeChangeProfilePage()
        {
            changePV = new ChangeProfileValuesUserControl();
            changePV.Dock = DockStyle.Fill; 
            ChosenSettingPanel.Controls.Add(changePV);
            changePV.Visible = false;
            changePV.CPSaveButton.Click += CPSaveButton_Click;
        }

        private void InitializeAddGenrePage()
        {
            addGenre = new AddGenreSettingUserControl();
            addGenre.Dock = DockStyle.Fill;
            ChosenSettingPanel.Controls.Add(addGenre);
            addGenre.Visible = false;
        }


        private void HideAllPages()
        {
            changePV.Visible = false;
            addGenre.Visible = false;

        }
        private void ChangeUserNameButton_Click(object sender, EventArgs e)
        {
            HideAllPages();
            changePV.Visible = true;
            changePV.ShowChangeUserName();
            currentOperation = "ChangeUserName";
        }


        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            HideAllPages();
            changePV.Visible = true;
            changePV.ShowChangePassword();
            currentOperation = "ChangePassword";
        }

        private void ChangeCityButton_Click(object sender, EventArgs e)
        {
            
            HideAllPages();
            changePV.Visible = true;
            changePV.ShowChangeCity();
            currentOperation = "ChangeCity"; 
        }

        private void AddGenreBookButton_Click(object sender, EventArgs e)
        {
            HideAllPages();
            addGenre.Visible = true;

        }

        private void addGenreMTVButton_Click(object sender, EventArgs e)
        {
            HideAllPages();
            addGenre.Visible = true;

        }

        private void CPSaveButton_Click(object sender, EventArgs e)
        {
            changePV.HandleSaveButtonClick(currentOperation); 
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Close all forms
                Application.Exit();

                // Restart the application with the WelcomeForm
                System.Diagnostics.Process.Start(Application.ExecutablePath);
            }
        }
    }
}
