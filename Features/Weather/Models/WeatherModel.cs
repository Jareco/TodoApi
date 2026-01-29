using System.Text.Json.Serialization;

namespace TodoApi.Features.Weather.Models
{
    public class WeatherData
    {
        [JsonPropertyName("temperature")]
        public double Temperature { get; set; }

        [JsonPropertyName("windspeed")]
        public double Windspeed { get; set; }

        [JsonPropertyName("winddirection")]
        public double Winddirection { get; set; }

        [JsonPropertyName("weathercode")]
        public int Weathercode { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; } = string.Empty;
    }

    public class WeatherResponse
    {
        [JsonPropertyName("current_weather")]
        public WeatherData? CurrentWeather { get; set; }
    }
}
