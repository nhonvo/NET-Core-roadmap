using _1.Relational_sqlServer_Postgres;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration.Get<AppSettings>();

if (configuration.SqlServer)
{

    builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.SqlServerConnectionStrings));
}
else if (configuration.PostgreSql)
{
    builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(configuration.PostgreSqlConnectionStrings));
}

builder.Services.AddSingleton(configuration);
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
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();
app.MapGet("/books", async ([FromServices] ApplicationDbContext context) =>
{
    return await context.Books.ToListAsync();
});
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
public class Book
{
    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime DateRelease { get; set; }

}