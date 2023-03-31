using DO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEntityConfigurations;

internal class BranchLocationConfiguration : IEntityTypeConfiguration<BranchLocation>
{
    public void Configure(EntityTypeBuilder<BranchLocation> builder)
    {
        throw new NotImplementedException();
    }
}
