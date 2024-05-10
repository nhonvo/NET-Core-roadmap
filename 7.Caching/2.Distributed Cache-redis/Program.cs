using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add Redis cache service
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "redis:6379";
    options.InstanceName = "redis";
});

builder.Services.AddLogging(config =>
{
    config.AddConsole();
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

MinimalApi.AddDevelopmentEndpoint(app, summaries);

app.Run();

public class MinimalApi
{
    public static void AddDevelopmentEndpoint(WebApplication app, string[] summaries)
    {
        app.MapGet("/weatherforecast", async ([FromServices] IDistributedCache cache, [FromServices] ILogger<MinimalApi> logger) =>
        {
            var cachedData = await cache.GetAsync("forecast");
            if (cachedData != null)
            {
                var result = JsonSerializer.Deserialize<WeatherForecast[]>(cachedData);
                logger.LogInformation("Data get from cache");
                logger.LogInformation($"Response: {JsonSerializer.Serialize(result)}");

                return result;
            }
            var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
                .ToArray();

            var cachedDataString = JsonSerializer.Serialize(forecast);
            var newDataToCache = Encoding.UTF8.GetBytes(cachedDataString);

            var options = new DistributedCacheEntryOptions()
                           .SetAbsoluteExpiration(DateTime.Now.AddMinutes(2))
                           .SetSlidingExpiration(TimeSpan.FromMinutes(1));
            await cache.SetAsync("forecast", newDataToCache, options);
            logger.LogInformation("Cache not exist");
            logger.LogInformation($"Response: {JsonSerializer.Serialize(forecast)}");
            return forecast;
        })
        .WithName("GetWeatherForecast")
        .WithOpenApi();
    }
}


record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
