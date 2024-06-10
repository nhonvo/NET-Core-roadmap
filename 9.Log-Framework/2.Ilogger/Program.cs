using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

// using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
// ILogger logger = factory.CreateLogger<Program>();

app.MapGet("/weatherforecast", (ILogger<Program> logger) =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    logger.LogInformation("GetWeatherForecast called");
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

LoggerFactoryExample.Logging();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
public partial class Program { }


public static class LoggerFactoryExample
{
    private static readonly ILoggerFactory logger;
    public static void Logging()
    {
        ILogger _logger = logger.CreateLogger<Program>();
        _logger.LogInformation("A called");
    }
}