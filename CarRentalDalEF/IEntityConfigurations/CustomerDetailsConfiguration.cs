using DO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEntityConfigurations;

internal class CustomerDetailsConfiguration : IEntityTypeConfiguration<CustomerDetails>
{
    public void Configure(EntityTypeBuilder<CustomerDetails> builder)
    {
        builder.HasKey(cd => cd.CustomerDetailsId);

        builder.HasMany(cd => cd.CarRentals)
            .WithOne(cd => cd.CustomerDetails)
            .HasForeignKey(cd => cd.CustomerDetails)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(cd => cd.Location)
            .WithOne().HasForeignKey<CustomerDetails>(cd => cd.LocationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
