using CarRentalDalCore.DataObjects.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalDalEF.IEntityConfigurations;

internal class CarImageConfiguration : IEntityTypeConfiguration<CarImage>
{
    public void Configure(EntityTypeBuilder<CarImage> builder)
    {
        builder.HasKey(ci => new { ci.CarId, ci.CarImageId });
    }
}
