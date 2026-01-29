using Microsoft.AspNetCore.Mvc;
using TodoApi.Features.Weather.Models;
using TodoApi.Features.Weather.Services;

namespace TodoApi.Features.Weather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public async Task<ActionResult<WeatherResponse>> GetWeather()
        {
            var weather = await _weatherService.GetCurrentWeatherAsync();
            
            if (weather == null)
            {
                return StatusCode(500, "Unable to fetch weather data.");
            }

            return Ok(weather);
        }
    }
}
