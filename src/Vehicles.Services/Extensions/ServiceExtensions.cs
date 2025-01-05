using Microsoft.Extensions.DependencyInjection;

namespace Vehicles.Services.Extensions;

public static class ServiceExtensions
{
    public static void AddVehicleServices(this IServiceCollection services)
    {
        services.AddScoped<VehicleService>();
    }
}

