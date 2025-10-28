
using Microsoft.Extensions.DependencyInjection;
using Restaurants.Application.Restaurant;

namespace Restaurants.Application.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    { 
        services.AddScoped<IRestaurantService, RestaurantService>();
        return services;
    }
}
