using Newtonsoft.Json;
using Serilog;
using Serilog.Core;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.UseSerilog();

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

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    Log.Information($"Returning weather forecasts {JsonConvert.SerializeObject(forecast)}");
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.MapGet("/logging", (string type) =>
{
    switch (type.ToLower())
    {
        case "warning":
            Log.Warning("Logging warning level: {Type}", type);
            break;
        case "error":
            Log.Error("Logging error level: {Type}", type);
            break;
        case "debug":
            Log.Debug("Logging debug level: {Type}", type);
            break;
        case "information":
            Log.Information("Logging information level: {Type}", type);
            break;
        default:
            throw new Exception("Unknown logging level: " + type);
    }
    return Results.Ok($"Logged {type} level message");
});

Log.Logger = new LoggerConfiguration()
                       .Enrich.FromLogContext()
                       .MinimumLevel.ControlledBy(new LoggingLevelSwitch(LogEventLevel.Information))
                       .WriteTo.Debug()
                       .WriteTo.Console()
                       .WriteTo.File("./Log/log-data.log")
                       .CreateLogger();
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
