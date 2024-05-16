using Test.Backend.Dotnet.Core.Interfaces;
using Test.Backend.Dotnet.Core.Services;

namespace Test.Backend.Dotnet.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IItemService, ItemService>();
            return services;
        }

    }
}
