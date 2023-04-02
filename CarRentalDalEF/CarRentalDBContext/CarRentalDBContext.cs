using DalApi.IEntity;
using DO;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetEntryAssembly());
    }
}
