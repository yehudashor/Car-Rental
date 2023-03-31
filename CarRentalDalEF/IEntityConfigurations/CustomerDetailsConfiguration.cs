using DO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEntityConfigurations;

internal class CustomerDetailsConfiguration : IEntityTypeConfiguration<CustomerDetails>
{
    public void Configure(EntityTypeBuilder<CustomerDetails> builder)
    {
        throw new NotImplementedException();
    }
}
