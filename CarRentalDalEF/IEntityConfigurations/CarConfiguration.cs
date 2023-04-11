using DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEntityConfigurations;

internal class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(c => c.CarId);

        builder.HasMany(c => c.Images)
            .WithOne(c => c.Car)
            .HasForeignKey(c => c.CarId)
              .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(c => c.CarRentals)
         .WithOne(c => c.Car)
         .HasForeignKey(c => c.CarId)
           .OnDelete(DeleteBehavior.NoAction);
    }
}
