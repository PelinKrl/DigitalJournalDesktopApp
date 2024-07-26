using System;
using System.IO;
using System.Windows.Forms;

namespace DesktopJournelApp
{
    public partial class WeatherAppPageUserControl : UserControl
    {
        public WeatherAppPageUserControl()
        {
            InitializeComponent();
            LoadWebContent();
             
        }

        private void WeatherAppPageUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadWebContent()
        {
            // Get the path to the HTML file
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string webContentPath = Path.Combine(appDirectory, "WeatherApp", "index.html");

            if (File.Exists(webContentPath))
            {
                webBrowser1.Url = new Uri(webContentPath);
            }
            else
            {
                MessageBox.Show("Web content not found.");
            }
        }


    }
}
