using Vehicles.Contracts;
using Vehicles.Data.Repositorys;
using Vehicles.Domain;
using Vehicles.Responses;
using Vehicles.Responses.Extensions;
using Vehicles.Responses.Interfaces;
using Vehicles.Services.Mappers;

namespace Vehicles.Services;

public class VehicleService(VehicleRepository repository)
{
    public async Task<IResponse<CreateVehicleResponse?>> AddVehicle(CreateVehicleRequest request)
    {
        var model = new Vehicle
        {
            Vrm = request.Vrm,
            Make = request.Make,
            Model = request.Model,
            Colour = request.Colour,
            Uid = Guid.NewGuid().ToString()
        };

        var result = await repository.Add(model);

        if (!result.IsSuccess)
        {
            return result.ReturnFailedResponse<Vehicle, CreateVehicleResponse>();
        }
        
        return new SuccessResponse<CreateVehicleResponse?>(result.Data.MapTo());
    }
}

