using CarRentalDalCore.DataObjects.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalDalEF.IEntityConfigurations;

internal class CarColorConfiguration : IEntityTypeConfiguration<CarColor>
{
    public void Configure(EntityTypeBuilder<CarColor> builder)
    {
        builder.HasKey(cc => cc.CarColorId);

        builder.HasMany(cc => cc.Cars)
            .WithOne(c => c.CarColor)
            .HasForeignKey(c => c.CarColorId);
    }
}
