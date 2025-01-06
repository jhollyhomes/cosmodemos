using Vehicles.Api.EndPoints;

namespace Vehicles.Api.Extensions;

public static class ServiceExtensions
{
    public static void RegisterEndpoints(this IEndpointRouteBuilder builder)
    {
        builder.RegisterHealthEndpoints();
        builder.RegisterVehicleEndpoints();
    }

    private static void RegisterHealthEndpoints(this IEndpointRouteBuilder builder)
    {
        builder.MapGet(Constants.ApiResources.Health, () => Results.Ok());
    }
}