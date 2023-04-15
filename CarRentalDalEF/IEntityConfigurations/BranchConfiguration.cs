using DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEntityConfigurations;

internal class BranchConfiguration : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.HasKey(b => b.BranchId);

        builder.HasOne(b => b.BranchLocation)
            .WithOne(b => b.Branch)
            .HasForeignKey<BranchLocation>(b => b.BranchId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(b => b.OpeningHoursList)
            .WithOne(b => b.Branch)
            .HasForeignKey(b => b.BranchId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(b => b.CarRentals)
            .WithOne(b => b.Branch)
            .HasForeignKey(b => b.BranchId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(b => b.BranchOpeningHoursEvents)
            .WithOne(b => b.Branch)
            .HasForeignKey(b => b.BranchId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
