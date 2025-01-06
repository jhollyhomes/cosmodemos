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

        var connectionString = configuration.GetConnectionString("VehiclesCosmoDb");
        ArgumentException.ThrowIfNullOrWhiteSpace(connectionString, Constants.ErrorMessages.VehicleCosmoDbConnectionStringIsNull);

       services.AddDbContext<VehicleDbContext>(o =>
       {
           o.UseCosmos(
               connectionString: connectionString,
               databaseName: Constants.DatabaseSettings.DatabaseName,
               cosmosOptionsAction: options =>
               {
                   options.ConnectionMode(Microsoft.Azure.Cosmos.ConnectionMode.Direct);
                   options.MaxRequestsPerTcpConnection(16);
                   options.MaxTcpConnectionsPerEndpoint(32);
               });
       });
    }
}
