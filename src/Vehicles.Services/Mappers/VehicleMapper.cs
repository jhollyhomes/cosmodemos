using Vehicles.Contracts;
using Vehicles.Domain;

namespace Vehicles.Services.Mappers;

public static class VehicleMapper
{
    public static CreateVehicleResponse? MapTo(this Vehicle? model)
    {
        if (model is null) return null;

        return new CreateVehicleResponse(model.Uid, 
                                         model.Vrm, 
                                         model.Make, 
                                         model.Model,
                                         model.Colour);
    }
}

