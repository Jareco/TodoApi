using TodoApi.Features.Weather.Models;

namespace TodoApi.Features.Weather.Services
{
    public interface IWeatherService
    {
        Task<WeatherResponse?> GetCurrentWeatherAsync(double latitude = 52.52, double longitude = 13.41);
    }
}
