using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Serilog;
using workshop.wwwapi.Data;
using workshop.wwwapi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("WeatherDb"));
builder.Host.UseSerilog((context, config) => config.ReadFrom.Configuration(context.Configuration));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "Demo API");
    });
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.ConfigureWeatherEndpoints();
app.ConfigureSeedEndpoints();
app.UseSerilogRequestLogging(); // IMPORTANT
app.Run();

