using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurants.Domain.Repositories;
using Restaurants.Infrastructure.Persistence;
using Restaurants.Infrastructure.Repositories;
using Restaurants.Infrastructure.Seeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        //1. Read the connnection string from configuration
        var connectionString = configuration.GetConnectionString("RestaurantsDb");

        //2. Register the DbContext with EF
        services.AddDbContext<RestaurantsDbContext>(options =>
            options.UseSqlServer(connectionString)
        );

        //3. Register Seeder as Scoped
        services.AddScoped<IRestaurantSeeders, RestaurantSeeders>();

        //4. Register RestaurantRepository as Scoped
        services.AddScoped<IRestaurantsRepository, RestaurantRepository>();

    }
}
