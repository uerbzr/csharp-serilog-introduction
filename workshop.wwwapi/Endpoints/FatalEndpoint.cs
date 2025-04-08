using workshop.wwwapi.Models;

namespace workshop.wwwapi.Endpoints
{
    public static class FatalEndpoint
    {
        public static void ConfigureFatalEndpoint(this WebApplication app)
        {
            app.MapGet("/fatal", (ILogger<WeatherForecast> logger) => { throw new NotImplementedException(); });
        }
    }
}
