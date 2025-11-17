var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// Homepage
app.MapGet("/", () => Results.Ok("App Time Zone API is running 🚀"));

// GET UTC
app.MapGet("Time/utc", () => Results.Ok(DateTime.UtcNow));

await app.RunAsync();
