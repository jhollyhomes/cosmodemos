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

    public async Task<IResponse<Vehicle>> Get(string uid)
    {
        try
        {
            var model = await context.Vehicles.FindAsync(uid);

            if (model is null)
            {
                return new NotFoundResponse<Vehicle>($"vehicle with id {uid} not found");
            }

            return new SuccessResponse<Vehicle>(model);
        }
        catch (Exception e)
        {
            return new ExceptionResponse<Vehicle>(e);
        }
    }
}