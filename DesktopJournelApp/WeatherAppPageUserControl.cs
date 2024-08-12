using Microsoft.Web.WebView2.Core;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopJournelApp
{
    public partial class WeatherAppPageUserControl : UserControl
    {
        public WeatherAppPageUserControl()
        {
            InitializeComponent();
            LoadWebContent();
            //LoadWeatherData();
        }

        private const string apiKey = "197f9672f375adfdb1734e1c5aa28eeb";
        private const string apiUrl = "https://api.openweathermap.org/data/2.5/weather?units=metric&q=";

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

        //private async void LoadWeatherData()
        //{
        //    string city = SQL.GetUserCity(MainAppForm._userId);
        //    if (!string.IsNullOrEmpty(city))
        //    {
        //        string weatherData = await GetWeatherDataAsync(city);
        //        DisplayWeatherData(weatherData);
        //    }
        //}

        private async Task<string> GetWeatherDataAsync(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{apiUrl}{city}&appid={apiKey}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        //private void DisplayWeatherData(string weatherData)
        //{
        //    // Parse the weather data and display it on the panel
        //    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(weatherData);
        //    string temp = data.main.temp + "°C";
        //    string cityName = data.name;
        //    string humidity = data.main.humidity + "%";
        //    string windSpeed = data.wind.speed + " km/h";

        //    // Update the labels on your panel
        //    string weatherInfo = $"City: {cityName}\nTemperature: {temp}\nHumidity: {humidity}\nWind Speed: {windSpeed}";
        //    MainAppForm mainForm = (MainAppForm)this.FindForm();
        //    mainForm.UpdateWeatherInfo(weatherInfo);
        //}
    }
}

