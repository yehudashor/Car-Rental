using DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEntityConfigurations;

internal class BranchOpeningHoursConfiguration : IEntityTypeConfiguration<BranchOpeningHours>
{
    public void Configure(EntityTypeBuilder<BranchOpeningHours> builder)
    {
        builder.HasKey(boh => new { boh.BranchId, boh.DayOfWeek });
    }
}
