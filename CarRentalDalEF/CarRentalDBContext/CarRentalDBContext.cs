using DO;
using Microsoft.EntityFrameworkCore;

namespace CarRentalDalEF;

internal class CarRentalDBContext : DbContext
{
    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<BranchOpeningHours> BranchesOpeningHours { get; set; }
    public virtual DbSet<BranchLocation> BranchesLocations { get; set; }

}
