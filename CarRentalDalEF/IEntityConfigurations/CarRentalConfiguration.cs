

using DO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEntityConfigurations;

internal class CarRentalConfiguration : IEntityTypeConfiguration<CarRental>
{
    public void Configure(EntityTypeBuilder<CarRental> builder)
    {
        throw new NotImplementedException();
    }
}
