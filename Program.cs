var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Configure for Railway deployment
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
app.Urls.Add($"http://0.0.0.0:{port}");

app.MapGet("/", () => "Hello World! Simple .NET Web App deployed to Azure!");

app.MapGet("/health", () => new { Status = "Healthy", Timestamp = DateTime.UtcNow });

app.Run();