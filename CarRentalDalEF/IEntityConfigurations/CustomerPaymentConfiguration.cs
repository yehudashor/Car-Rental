using DO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEntityConfigurations;

internal class CustomerPaymentConfiguration : IEntityTypeConfiguration<CustomerPayment>
{
    public void Configure(EntityTypeBuilder<CustomerPayment> builder)
    {
        builder.HasKey(cp => cp.CustomerPaymentId);

        builder.HasOne(cp => cp.CreditCard)
            .WithOne()
            .HasForeignKey<CustomerPayment>(cp => cp.CreditCardId);
    }
}
