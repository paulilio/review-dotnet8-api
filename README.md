# .NET 8 Web API - Practical Review & Best Practices

This lab project is based on a .NET course I'm currently taking (Module 4). 
It is used for practice and to help colleagues understand key backend concepts.
It is part of my personal review and consolidation of core concepts in modern .NET 8 Web API development.

The goal is to apply and revisit important patterns and tools using simple but realistic examples.
Each module represents a focused topic (e.g., DI, DTOs, FluentValidation, EF Core, etc).

## Topics Covered (so far)

- Clean project structure and minimal setup
- Controllers and REST principles
- DTOs and Entity mapping
- FluentValidation for input validation
- EF Core and database migrations
- Dependency Injection (DI)
- Logging and configuration
- Clean Architecture layers (API, Application, Domain, Infrastructure)
- Repository and Service patterns
- Unit tests and integration tests (coming soon)
- Middleware and exception handling (coming soon)

---

## Tech Stack

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- FluentValidation
- xUnit (planned)

---

## Run & Test
### Run the API
 ```bash
 dotnet run --project Restaurants.API
 ```
### Test 
**On PowerShell**
```bash
curl -Uri http://localhost:5163/api/restaurants
```
**On Linux**
```bash
curl -s http://localhost:5163/api/restaurants
```

### Check Response
- Status: 200 OK
- Body: JSON list of restaurants from the database.

---

## Final Project

<img width="783" height="540" alt="image" src="https://github.com/user-attachments/assets/f4e36218-f82b-4210-a1f5-f261ea002e8b" />


