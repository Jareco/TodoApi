using Microsoft.Extensions.DependencyInjection;
using TodoApi.Services;

namespace TodoApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services)
        {
            services.AddScoped<ITodoService, TodoService>();
            return services;
        }
    }
}
