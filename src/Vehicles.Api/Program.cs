using Scalar.AspNetCore;
using Vehicles.Api.Extensions;
using Vehicles.Data;
using Vehicles.Data.Extensions;
using Vehicles.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddVehicleServices();
builder.Services.AddDatabaseServices(builder.Configuration, builder.Environment);

var app = builder.Build();

app.RegisterEndpoints();

if (app.Environment.IsDevelopment() || app.Environment.IsTesting())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options.WithTheme(ScalarTheme.Mars);
        options.WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);
    });

    using var serviceScope = app.Services.CreateScope();
    var services = serviceScope.ServiceProvider;

    var context = services.GetRequiredService<VehicleDbContext>();
    await context.Database.EnsureDeletedAsync();
    await context.Database.EnsureCreatedAsync();
}

app.Run();