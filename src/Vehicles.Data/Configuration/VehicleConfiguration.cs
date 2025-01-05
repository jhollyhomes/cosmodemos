using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vehicles.Domain;

namespace Vehicles.Data.Configuration;
public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.ToContainer("VehiclesList");
        builder.HasKey(x => x.Uid);
    }
}

