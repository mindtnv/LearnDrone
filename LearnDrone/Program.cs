var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables();
var app = builder.Build();

app.MapGet("/", (IConfiguration configuration) => $"Hello World! 123456");

app.Run();