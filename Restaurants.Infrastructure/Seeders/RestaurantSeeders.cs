
using Microsoft.EntityFrameworkCore;
using Restaurants.Domain.Entities;
using Restaurants.Infrastructure.Persistence;

namespace Restaurants.Infrastructure.Seeders;

public interface IRestaurantSeeders
{
    Task SeedAsync();
}

public class RestaurantSeeders(RestaurantsDbContext context) : IRestaurantSeeders
{
    private readonly RestaurantsDbContext _context = context;

    public async Task SeedAsync()
    {
        if (await _context.Database.CanConnectAsync())
        {
            if (!_context.Restaurants.Any())
            {
                var restaurants = GetRestaurants();
                _context.Restaurants.AddRange(restaurants);
                await _context.SaveChangesAsync();
            }
        }
    }

    private IEnumerable<Restaurant> GetRestaurants()
    {
        List<Restaurant> restaurants =
        [
            new Restaurant
            {
                Description = "La Trattoria",
                Category = "Italian",
                HasDelivery = true,
                ContactEmail = "contact@latrattoria.com",
                Address = new Address
                {
                    City = "Rome",
                    Street = "Via Milano 10",
                    PostalCode = "00184"
                },
                Dishes =
                [
                    new Dish { Name = "Margherita Pizza", Description = "Tomato and mozzarella", Price = 8.5m, KiloCalories = 457 },
                    new Dish { Name = "Carbonara", Description = "Pasta with egg and pancetta", Price = 10.0m, KiloCalories = 698 }
                ]
            },
            new Restaurant
            {
                Name = "Sushi Master",
                Description = "Authentic Japanese sushi bar",
                Category = "Japanese",
                HasDelivery = false,
                ContactEmail = "info@sushimaster.jp",
                Address = new Address
                {
                    City = "Tokyo",
                    Street = "Ginza 5-7-8",
                    PostalCode = "104-0061"
                },
                Dishes =
                [
                    new Dish { Name = "Salmon Roll", Description = "Fresh salmon and rice", Price = 6.0m }
                ]
            }
        ];

        return restaurants;
    }
}
 