using DO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEntityConfigurations;

internal class CarRentalConfiguration : IEntityTypeConfiguration<CarRental>
{
    public void Configure(EntityTypeBuilder<CarRental> builder)
    {
        builder.HasKey(cr => cr.CarRentalId);

        builder.HasOne(cr => cr.CustomerPayment)
            .WithOne(cr => cr.CarRental)
            .HasForeignKey<CarRental>(cr => cr.CustomerPaymentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
