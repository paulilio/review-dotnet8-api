namespace Restaurants.Domain.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int? KiloCalories { get; set; }

        //foreign key
        public int RestaurantId { get; set; }
    }
}