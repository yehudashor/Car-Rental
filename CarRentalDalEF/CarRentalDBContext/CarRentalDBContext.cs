using DO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalDalEF;

internal class CarRentalDBContext : DbContext
{
    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<BranchOpeningHours> BranchesOpeningHours { get; set; }
    public virtual DbSet<BranchLocation> BranchesLocations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(b => b.BranchId);

                entity.HasOne(b => b.BranchLocation).WithOne(b => b.Branch).HasForeignKey<BranchLocation>(b => b.BranchId);
                entity.HasMany(b => b.OpeningHoursList).WithOne(b => b.Branch).HasForeignKey(b => b.BranchId);
                entity.HasMany(b => b.CarRentals).WithOne(b => b.Branch).HasForeignKey(b => b.BranchId);

            });

     
        EntityTypeBuilder<BranchLocation> branchLocationBuilder = modelBuilder.Entity<BranchLocation>();

        branchLocationBuilder.HasKey(bl => bl.BranchLocationId);

       // branchLocationBuilder.HasOne(bl => bl.Location).WithOne()

    }
}
