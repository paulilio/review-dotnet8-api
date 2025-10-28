﻿using Microsoft.AspNetCore.Mvc;
using Restaurants.Application.Restaurant;
using System.Threading.Tasks;

namespace Restaurants.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantsController(IRestaurantService restaurantService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var restaurants = await restaurantService.GetAllRestaurants();
        return Ok(restaurants);
    }
}
