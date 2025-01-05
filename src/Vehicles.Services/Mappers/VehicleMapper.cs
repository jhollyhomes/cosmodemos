using Vehicles.Contracts;
using Vehicles.Domain;

namespace Vehicles.Services.Mappers;

public static class VehicleMapper
{
    public static CreateVehicleResponse MapTo(this Vehicle? model)
    {
        return new CreateVehicleResponse
        {
            Vrm = model.Vrm,
            Make = model.Make,
            Model = model.Model,
            Colour = model.Colour,
            Uid = model.Uid
        };
    }
}

