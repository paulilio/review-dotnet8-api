using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurants.Domain.Entities;

namespace Restaurants.Infrastructure.Persistence;

public class RestaurantsDbContext(DbContextOptions<RestaurantsDbContext> options) : DbContext(options)
{
    internal DbSet<Restaurant> Restaurants { get; set; }
    internal DbSet<Dish> Dishes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Address is owned by Restaurant (no separated table)
        modelBuilder.Entity<Restaurant>().OwnsOne(r => r.Address);

        modelBuilder.Entity<Dish>()
            .Property(d => d.Price)
            .HasPrecision(18, 2);

        // One-to-Many: Restaurant + Dishes
        modelBuilder.Entity<Restaurant>()
            .HasMany(r => r.Dishes)
            .WithOne()
            .HasForeignKey(d => d.RestaurantId);
    }
}
