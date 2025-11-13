var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "I Wll be great, Hello World! Simple .NET Web App deployed to Azure!");

app.MapGet("/health", () => new { Status = "Healthy", Timestamp = DateTime.UtcNow });

app.Run();