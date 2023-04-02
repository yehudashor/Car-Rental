using DO;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CarRentalDalEF;

public class CarRentalDBContext : DbContext
{
    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<BranchOpeningHours> BranchesOpeningHours { get; set; }
    public virtual DbSet<BranchLocation> BranchesLocations { get; set; }
    public virtual DbSet<Car> Cars { get; set; }
    public virtual DbSet<CarColor> CarColors { get; set; }
    public virtual DbSet<CarImage> CarImages { get; set; }
    public virtual DbSet<CarRental> CarRentals { get; set; }
    public virtual DbSet<CreditCard> CreditCards { get; set; }
    public virtual DbSet<CustomerDetails> CustomerDetails { get; set; }
    public virtual DbSet<CustomerPayment> CustomerPayments { get; set; }
    public virtual DbSet<Location> Locations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetEntryAssembly());

}
