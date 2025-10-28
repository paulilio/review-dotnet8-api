// Specify who the API should work
//What dependencies are we going to register in the build-in dependency container
//How the HTTP request pipeline will look like

using Restaurants.API.Controllers;
using Restaurants.Application.Extensions;
using Restaurants.Infrastructure.Extensions;
using Restaurants.Infrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddEnvironmentVariables();

// Add Appication and Infrastructure
builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

//Controller Invocation
//Necessary Types to the Dependency Injection Container (so API can run using controllers.
builder.Services.AddControllers();

var app = builder.Build();

//Run seeding automatically
using (var scope = app.Services.CreateScope())
{
    var seeder = scope.ServiceProvider.GetRequiredService<IRestaurantSeeders>();
    await seeder.SeedAsync();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
