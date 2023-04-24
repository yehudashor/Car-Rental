using CarRentalDalCore.DalApi.IEntity;
using CarRentalDalCore.DataObjects.BranchOperations;
using CarRentalDalCore.DataObjects.CarOperations;
using CarRentalDalCore.DataObjects.Customer;
using CarRentalDalCore.DataObjects.Locations;
using CarRentalDalEF.Converters;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CarRentalDalEF.CarRentalDBContext;

public class CarRentalDBContext : DbContext
{
    private const string connectionString = "Server=localHost;DataBase=CarRental;Trusted_Connection=True;TrustServerCertificate=True"; 

    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<BranchOpeningHours> BranchesOpeningHours { get; set; }
    public virtual DbSet<BranchLocation> BranchesLocations { get; set; }

    public virtual DbSet<BranchOpeningHoursEvent> BranchOpeningHoursEvents { get; set; }
    public virtual DbSet<Car> Cars { get; set; }
    public virtual DbSet<CarColor> CarColors { get; set; }
    public virtual DbSet<CarImage> CarImages { get; set; }
    public virtual DbSet<CarRental> CarRentals { get; set; }
    public virtual DbSet<CreditCard> CreditCards { get; set; }
    public virtual DbSet<CustomerDetails> CustomerDetails { get; set; }
    public virtual DbSet<CustomerPayment> CustomerPayments { get; set; }
    public virtual DbSet<Location> Locations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

    // לדרוס את הפונקציות של הוספה וכו ולהוסיף שמירה בתוכן ולאחר מכן למחוק.
    protected override void OnModelCreating(ModelBuilder modelBuilder)

    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<BranchOpeningHours>().HasData(new BranchOpeningHours { BranchId = 5, DayOfWeek = DayOfWeek.Monday });
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.IgnoreAny<IEntity>();
        configurationBuilder.Properties<string>().HaveMaxLength(50);
        configurationBuilder.Properties<DateOnly>().HaveConversion<DateOnlyConverter>();
        configurationBuilder.Properties<TimeOnly>().HaveConversion<TimeOnlyConverter>();
    }

}
