﻿using CarRentalDalCore.DataObjects.Branch;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalDalEF.IEntityConfigurations;

internal class BranchLocationConfiguration : IEntityTypeConfiguration<BranchLocation>
{
    public void Configure(EntityTypeBuilder<BranchLocation> builder)
    {
        builder.HasKey(bl => bl.BranchLocationId);

        builder.HasOne(bl => bl.Location)
            .WithOne()
            .HasForeignKey<BranchLocation>(bl => bl.LocationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
