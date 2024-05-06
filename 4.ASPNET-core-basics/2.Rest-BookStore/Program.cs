using System.Diagnostics;
using System.Text.Json.Serialization;
using _2.Rest_BookStore;
using _2.Rest_BookStore.Filters;
using _2.Rest_BookStore.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration.Get<AppSettings>();

builder.Services.AddSingleton(configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register services
builder.Services.AddSingleton<RoutingMiddleware>();
builder.Services.AddSingleton<PerformanceMiddleware>();
builder.Services.AddSingleton<Stopwatch>();
builder.Services.AddScoped<ValidateFilter>();

// Filter
builder.Services.AddControllers(options =>
{
    options.Filters.Add<ExceptionFilter>();
    options.Filters.Add(typeof(ValidateFilter));
}).AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Middleware
app.UseMiddleware<PerformanceMiddleware>();
app.UseMiddleware<RoutingMiddleware>();

// Filter 
app.MapControllers();

// Controller 
app.MapGet("/custom-middleware", () => "custom");

app.MapGet("/book", () => new List<Book>{
        new () { Id = Guid.NewGuid(), Name = "Be Foolish", Year = 2000},
        new () { Id = Guid.NewGuid(), Name = "Keep learning", Year = 2001},
    }
);


app.Run();

public class Book
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
}