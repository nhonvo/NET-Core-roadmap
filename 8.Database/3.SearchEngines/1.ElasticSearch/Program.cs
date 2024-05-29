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

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
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

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}


public class ElasticsearchClientProvider
{
    public static ElasticClient GetClient(IConfiguration configuration)
    {
        var settings = new ConnectionSettings(new Uri(configuration["ElasticsearchUrl"]))
            .DefaultIndex("products"); // Default index for simplicity
        return new ElasticClient(settings);
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}


public class ElasticsearchService
{
    private readonly ElasticClient _client;

    public ElasticsearchService(ElasticClient client)
    {
        _client = client;
    }

    public async Task<bool> CreateIndexAsync()
    {
        var createIndexResponse = await _client.Indices.CreateAsync("products", c => c
            .Map<Product>(m => m
                .AutoMap()
            )
        );

        return createIndexResponse.IsValid;
    }

    public async Task<bool> IndexProductAsync(Product product)
    {
        var indexResponse = await _client.IndexDocumentAsync(product);
        return indexResponse.IsValid;
    }

    public async Task<Product> GetProductAsync(int id)
    {
        var response = await _client.GetAsync<Product>(id);
        return response.Source;
    }

    public async Task<ISearchResponse<Product>> SearchProductsAsync(string query)
    {
        var searchResponse = await _client.SearchAsync<Product>(s => s
            .Query(q => q
                .MultiMatch(m => m
                    .Fields(f => f
                        .Field(p => p.Name)
                        .Field(p => p.Description)
                    )
                    .Query(query)
                )
            )
        );

        return searchResponse;
    }

    public async Task<bool> DeleteProductAsync(int id)
    {
        var deleteResponse = await _client.DeleteAsync<Product>(id);
        return deleteResponse.IsValid;
    }
}