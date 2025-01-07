using Vehicles.Contracts;
using Vehicles.Domain;

namespace Vehicles.Services.Mappers;

public static class VehicleMapper
{
    public static CreateVehicleResponse? MapToCreateVehicleResponse(this Vehicle? model)
    {
        if (model is null) return null;

        return new CreateVehicleResponse(model.Uid, 
                                         model.Vrm, 
                                         model.Make, 
                                         model.Model,
                                         model.Colour);
    }

    public static VehicleResponse? MapToVehicleResponse(this Vehicle? model)
    {
        if (model is null) return null;

        return new VehicleResponse(model.Uid,
            model.Vrm,
            model.Make,
            model.Model,
            model.Colour);
    }
}

