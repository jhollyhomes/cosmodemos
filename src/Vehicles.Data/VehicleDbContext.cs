using Microsoft.EntityFrameworkCore;
using Vehicles.Data.Configuration;
using Vehicles.Domain;

namespace Vehicles.Data;

public class VehicleDbContext(DbContextOptions<VehicleDbContext> options) : DbContext(options)
{
    public DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new VehicleConfiguration());
    }
}