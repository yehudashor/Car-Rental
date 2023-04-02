using DO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEntityConfigurations;

internal class BranchConfiguration : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.HasKey(b => b.BranchId);
        builder.HasOne(b => b.BranchLocation).WithOne(b => b.Branch).HasForeignKey<BranchLocation>(b => b.BranchId);
        builder.HasMany(b => b.OpeningHoursList).WithOne(b => b.Branch).HasForeignKey(b => b.BranchId);
        builder.HasMany(b => b.CarRentals).WithOne(b => b.Branch).HasForeignKey(b => b.BranchId);
        builder.Property(b => b.BranchLocation).IsRequired();

    }
}
