var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables();
var app = builder.Build();

app.MapGet("/", (IConfiguration configuration) => $"Hello World! Your secret: {configuration["SECRET_VARIABLE"]}");

app.Run();