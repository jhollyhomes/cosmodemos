using Vehicles.Domain;
using Vehicles.Responses;
using Vehicles.Responses.Interfaces;

namespace Vehicles.Data.Repositorys;

public class VehicleRepository(VehicleDbContext context)
{
    public async Task<IResponse<Vehicle>> Add(Vehicle model)
    {
        try
        {
            await context.Vehicles.AddAsync(model);
            await context.SaveChangesAsync();

            return new SuccessResponse<Vehicle>(model);
        }
        catch (Exception e)
        {
            return new ExceptionResponse<Vehicle>(e);
        }
    }
}

