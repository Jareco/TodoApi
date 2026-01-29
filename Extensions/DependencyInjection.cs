using Microsoft.Extensions.DependencyInjection;
using TodoApi.Features.TodoItems.Services;
using TodoApi.Features.Weather.Services;

namespace TodoApi.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services)
        {
            services.AddScoped<ITodoService, TodoService>();
            
            services.AddHttpClient<IWeatherService, WeatherService>();

            return services;
        }
    }
}
