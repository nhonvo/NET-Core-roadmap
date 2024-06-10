using System.Reflection;
using Newtonsoft.Json;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.Elasticsearch;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.UseSerilog();
ConfigureLogging();
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

static void ConfigureLogging()
{
    Log.Logger = new LoggerConfiguration()
                   .Enrich.FromLogContext()
                        .MinimumLevel.ControlledBy(new LoggingLevelSwitch(LogEventLevel.Information))
                        .WriteTo.Debug()
                        .WriteTo.Console()
                           .WriteTo.File("./Log/log-data.log")
                            .WriteTo.Elasticsearch(ConfigureElasticSink())
                           .CreateLogger();
}
static ElasticsearchSinkOptions ConfigureElasticSink()
{
    return new ElasticsearchSinkOptions(new Uri("http://localhost:9200"))
    {
        AutoRegisterTemplate = true,
        IndexFormat = $"{Assembly.GetExecutingAssembly().GetName().Name!.ToLower(System.Globalization.CultureInfo.CurrentCulture)}-{DateTime.UtcNow:yyyy-MM}",
        NumberOfReplicas = 2
    };
}
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

