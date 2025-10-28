using Microsoft.Extensions.Logging;
using Restaurants.Domain.Repositories;
using Ent = Restaurants.Domain.Entities;

namespace Restaurants.Application.Restaurant;

internal class RestaurantService(
    IRestaurantsRepository repository,
    ILogger<RestaurantService> logger) : IRestaurantService
{
    public async Task<IEnumerable<Ent.Restaurant>> GetAllRestaurants()
    {
        logger.LogInformation("Getting all restaurants");
        var restaurants = await repository.GetAllAsync();
        return restaurants;
    }
}
