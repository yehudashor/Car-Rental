using CarRentalDalCore.DataObjects.Branch;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalDalEF.IEntityConfigurations
{
    internal class BranchOpeningHoursEventConfiguration : IEntityTypeConfiguration<BranchOpeningHoursEvent>
    {
        public void Configure(EntityTypeBuilder<BranchOpeningHoursEvent> builder)
        {
            builder.HasKey(bohe => bohe.BranchOpeningHoursEventId);
        }
    }
}
