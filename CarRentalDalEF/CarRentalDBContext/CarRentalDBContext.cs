﻿using CarRentalDalCore.DalApi.IEntity;
using CarRentalDalCore.DataObjects.BranchOperations;
using CarRentalDalCore.DataObjects.CarOperations;
using CarRentalDalCore.DataObjects.Customer;
using CarRentalDalCore.DataObjects.Locations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CarRentalDalEF.CarRentalDBContext;

public class CarRentalDBContext : DbContext
{
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

    // לדרוס את הפונקציות של הוספה וכו ולהוסיף שמירה בתוכן ולאחר מכן למחוק.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetEntryAssembly());

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.IgnoreAny<IEntity>();
        configurationBuilder.Properties<string>().HaveMaxLength(50);
    }

}
