using _2.Cloud_DynamoDB;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration.Get<AppSettings>();

// Set the configuration dynamodb 
builder.Services.AddDefaultAWSOptions(builder.Configuration.GetAWSOptions());
if (!string.IsNullOrEmpty(configuration.AwsSettings.ServiceUrl))
{
    builder.Services.AddSingleton<IAmazonDynamoDB>(sp =>
    {
        var clientConfig = new AmazonDynamoDBConfig
        {
            ServiceURL = configuration.AwsSettings.ServiceUrl,
            UseHttp = true
        };
        return new AmazonDynamoDBClient(clientConfig);
    });
}
else
{
    builder.Services.AddAWSService<IAmazonDynamoDB>();
}

builder.Services.AddSingleton<IDynamoDBContext, DynamoDBContext>((serviceProvider) =>
{
    IAmazonDynamoDB amazonDynamoDBClient = serviceProvider.GetRequiredService<IAmazonDynamoDB>();
    var config = new DynamoDBContextConfig
    {
        DisableFetchingTableMetadata = true,
        MetadataCachingMode = MetadataCachingMode.TableNameOnly
    };
    return new DynamoDBContext(amazonDynamoDBClient, config);
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

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}


