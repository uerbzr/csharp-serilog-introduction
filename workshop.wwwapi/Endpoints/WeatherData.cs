using workshop.wwwapi.Data;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.Endpoints
{
    public static class WeatherData
    {
        public static void ConfigureSeedEndpoints(this WebApplication app)
        {
            app.MapGet("/seed", async (DataContext db, ILogger<WeatherForecast> logger) =>
            {
                try
                {

                    if (!db.WeatherForecasts.Any())
                    {
                        db.WeatherForecasts.AddRange(new List<WeatherForecast>
                        {
                            new WeatherForecast { Date = DateOnly.FromDateTime(DateTime.Now), TemperatureC = 20, Summary = "Warm" },
                            new WeatherForecast { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), TemperatureC = 25, Summary = "Hot" },
                            new WeatherForecast { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), TemperatureC = 15, Summary = "Cool" }
                        });
                        await db.SaveChangesAsync();
                        logger.LogInformation("Database seeded with initial data");
                        return Results.Ok("Database seeded");
                    }
                    else
                    {
                        logger.LogWarning("Database had data");
                        return Results.Ok("Database had data");
                    }
                }
                catch(Exception ex)
                {
                    logger.LogError(ex, "Error seeding database");
                    return Results.Problem("Error seeding database");
                }
                finally
                {
                    logger.LogInformation("Seed endpoint completed");
                }
            });
        }
    }
}
