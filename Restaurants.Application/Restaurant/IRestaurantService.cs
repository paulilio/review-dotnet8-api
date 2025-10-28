using Ent = Restaurants.Domain.Entities;

namespace Restaurants.Application.Restaurant;

public interface IRestaurantService
{
    Task<IEnumerable<Ent.Restaurant>> GetAllRestaurants();
}