using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ongoing.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            LoadWeatherData();
        }

        private async void LoadWeatherData()
        {
            string apiUrl = "https://api.openweathermap.org/data/2.5/forecast?id=524901&appid=7b639c27ee55a70bf4a1f9eae6a21957";
            using HttpClient client = new HttpClient();
            try
            {
                var weatherData = await client.GetFromJsonAsync<WeatherResponse>(apiUrl);
                if (weatherData != null && weatherData.List != null && weatherData.List.Count > 0)
                {
                    msg.Text = "Data acquired. \nSUCCESS.\n";
                    // Get the first weather item
                    var item = weatherData.List[5];

                    // Ensure UI updates are on the main thread
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        dateLabel.Text = $"Date and Time: {item.Dt_Txt}";
                        tempLabel.Text = $"Temperature: {item.Main.Temp}K";
                        weatherLabel.Text = $"Weather: {item.Weather[0].Description}";
                        humidityLabel.Text = $"Humidity: {item.Main.Humidity}%";
                        visibilityLabel.Text = $"Visibility: {item.Visibility}";
                    });
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("No weather data found.");
                }
            }
            catch (HttpRequestException e)
            {
                System.Diagnostics.Debug.WriteLine($"Request error: {e.Message}");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine($"Unexpected error: {e.Message}");
            }
        }

        public class WeatherResponse
        {
            public List<WeatherForecast> List { get; set; }
        }

        public class WeatherForecast
        {
            public Main Main { get; set; }
            public List<WeatherDescription> Weather { get; set; }
            public string Dt_Txt { get; set; }
            public int Visibility { get; set; }
        }

        public class Main
        {
            public float Temp { get; set; }
            public int Humidity { get; set; }
        }

        public class WeatherDescription
        {
            public string Description { get; set; }
        }
    }
}
