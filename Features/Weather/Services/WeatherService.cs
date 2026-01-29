using System.Text.Json;
using TodoApi.Features.Weather.Models;

namespace TodoApi.Features.Weather.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherResponse?> GetCurrentWeatherAsync(double latitude = 52.52, double longitude = 13.41)
        {
            try
            {
                var response = await _httpClient.GetAsync($"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current_weather=true");
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<WeatherResponse>(content);
            }
            catch (Exception ex)
            {
                // Simple error logging or handling could go here
                Console.WriteLine($"Error fetching weather data: {ex.Message}");
                return null;
            }
        }
    }
}
