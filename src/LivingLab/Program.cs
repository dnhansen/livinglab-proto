var builder = WebApplication.CreateBuilder(args);

// DEPENDENCY INJECTION

builder.Services.AddPresentation();
builder.Services.AddDomain();
builder.Services.AddInfrastructure();

var app = builder.Build();


// MIDDLEWARE PIPELINE


// ENDPOINTS

app.MapCowEndpoints();

app.Run();
