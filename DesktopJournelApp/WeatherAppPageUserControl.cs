using Microsoft.Web.WebView2.Core;
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

        private async void LoadWebContent()
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string webContentPath = Path.GetFullPath("C:\\Users\\psk\\Desktop\\GitHubFiles\\DigitalJournalDesktopApp\\DesktopJournelApp\\WeatherApp\\index.html");

            if (File.Exists(webContentPath)) 
            {
                await webView21.EnsureCoreWebView2Async(null);
                webView21.CoreWebView2.Navigate(webContentPath);
            }
            else
            {
                MessageBox.Show("Web content not found.");
            }
        }
    }
}
