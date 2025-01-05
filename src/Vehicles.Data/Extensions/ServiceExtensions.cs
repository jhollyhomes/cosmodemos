using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Vehicles.Data.Repositorys;

namespace Vehicles.Data.Extensions;
public static class ServiceExtensions
{
    public static void AddDatabaseServices(this IServiceCollection services,
                                                IConfiguration configuration,
                                                IHostEnvironment hostEnvironment)
    {
        services.AddScoped<VehicleRepository>();
        services.AddDbContext<VehicleDbContext>(o =>
        {
            o.UseCosmos("", "", databaseName: "databaseName");
        });
    }
}
