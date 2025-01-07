using Vehicles.Contracts;
using Vehicles.Services;
using Vehicles.Api.Extensions;

namespace Vehicles.Api.EndPoints;
public static class VehicleEndpoints
{
    public static void RegisterVehicleEndpoints(this IEndpointRouteBuilder builder)
    {
        var mapGroup = builder.MapGroup(Constants.ApiResources.Vehicles);

        //mapGroup.MapGet("/", GetVehicles);
        mapGroup.MapGet("/{id}", GetVehicle);
        mapGroup.MapPost("/", CreateVehicle);
        //mapGroup.MapPut("/", UpdateVehicle);
    }

    static async Task<IResult> CreateVehicle(VehicleService service, CreateVehicleRequest request)
    {
        var result = await service.AddVehicle(request);

        return result.ProcessResponse();
    }

    static async Task<IResult> GetVehicle(VehicleService service, string id)
    {
        var result = await service.GetVehicle(id);

        return result.ProcessResponse();
    }
}

