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
                logger.LogDebug("{@entities}", entities);
                return Results.Ok(entities);
            });

            weather.MapGet("/{id}", async (int id, DataContext db, ILogger<WeatherForecast> logger) =>
            {
                var entity = await db.WeatherForecasts.FindAsync(id);
                
                if(entity is not null)
                {
                    logger.LogDebug("Found entity with id {id}: {@entity}", id, entity);
                    return Results.Ok(entity);

                }
                else
                {
                    logger.LogDebug("Entity with id {id} not found", id);
                    return Results.NotFound();
                }
            });

            weather.MapDelete("/{id}", async (int id, DataContext db, ILogger<WeatherForecast> logger) =>
            {
                var entity = await db.WeatherForecasts.FindAsync(id);
                if (entity is null)
                {
                    logger.LogDebug("Entity with id {id} not found", id);
                    return Results.NotFound();
                }
                db.WeatherForecasts.Remove(entity);
                await db.SaveChangesAsync();
                logger.LogDebug("DELETED entity with id {id}: {@entity}", id, entity);
                return Results.Ok(entity);
            });


            weather.MapPut("/{id}", async (int id, WeatherForecast model, DataContext db) =>
            {
                var target = await db.WeatherForecasts.FindAsync(id);
                if (target is null)
                {
                    return Results.NotFound();
                }
                target.TemperatureC = model.TemperatureC;
                target.Date = model.Date;
                target.Summary = model.Summary;
                db.Update(target);
                await db.SaveChangesAsync();
                return Results.Ok(target);
            });

            weather.MapPost("/", async (WeatherForecast model, DataContext db) =>
            {
                db.WeatherForecasts.Add(model);
                await db.SaveChangesAsync();
                return Results.Created($"/weather/{model.Id}", model);
            });


        }
     
    }
}
