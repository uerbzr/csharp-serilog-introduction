using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using workshop.wwwapi.Data;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.Endpoints
{
    public static class WeatherEndpoints
    {
        public static void ConfigureWeatherEndpoints(this WebApplication app)
        {
            var weather = app.MapGroup("/weather");

            weather.MapGet("/", async (DataContext db, ILogger<WeatherForecast> logger) =>
            {
                var entities = await db.WeatherForecasts.ToListAsync();
                logger.LogInformation("{@entities}", entities);
                return Results.Ok(entities);
            });
        }
     
    }
}
