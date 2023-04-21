using CarRentalDalCore.DataObjects.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalDalEF.IEntityConfigurations;

internal class CustomerPaymentConfiguration : IEntityTypeConfiguration<CustomerPayment>
{
    public void Configure(EntityTypeBuilder<CustomerPayment> builder)
    {
        builder.HasKey(cp => cp.CustomerPaymentId);

        builder.HasMany(cp => cp.CreditCardPayments)
            .WithOne(cp => cp.CustomerPayment)
            .HasForeignKey(cp => cp.CustomerPaymentId);
    }
}
