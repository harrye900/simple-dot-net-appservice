var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "🚀God is great V2 🎉");

app.MapGet("/health", () => new { Status = "Healthy", Timestamp = DateTime.UtcNow });

app.MapGet("/info", () => new { 
    App = "Simple .NET Web App", 
    Version = "2.0", 
    DeployedTo = "Azure Web App", 
    Runtime = ".NET 8.0",
    LastUpdated = DateTime.UtcNow 
});

app.Run();