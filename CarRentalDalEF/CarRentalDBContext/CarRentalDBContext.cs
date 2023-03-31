using DalApi.IEntity;
using DO;
using IEntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalDalEF;

public class CarRentalDBContext : DbContext
{
    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<BranchOpeningHours> BranchesOpeningHours { get; set; }
    public virtual DbSet<BranchLocation> BranchesLocations { get; set; }

    private List<IEntityTypeConfiguration<IEntity>> _entityTypeConfigurations;

    public CarRentalDBContext()
    {
        _entityTypeConfigurations = new List<IEntityTypeConfiguration<IEntity>>
        {

        };
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var entityTypeConfiguration in _entityTypeConfigurations)
        {
            modelBuilder.ApplyConfiguration(entityTypeConfiguration);
        }
    }
}
