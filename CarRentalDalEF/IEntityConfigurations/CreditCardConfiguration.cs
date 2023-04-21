using CarRentalDalCore.DataObjects.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalDalEF.IEntityConfigurations;

internal class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
{
    public void Configure(EntityTypeBuilder<CreditCard> builder)
    {
        builder.HasKey(cc => cc.CreditCardId);

        builder.HasMany(cc => cc.CreditCardPayments)
            .WithOne(ccp => ccp.CreditCard)
            .HasForeignKey(ccp => ccp.CreditCardId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
