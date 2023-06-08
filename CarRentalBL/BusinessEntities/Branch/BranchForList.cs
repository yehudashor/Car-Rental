using CarRentalBL.BusinessEntities.Enums;
using System.Text;

namespace CarRentalBL.BusinessEntities.Branch;

public class BranchForList
{
    /// <summary>
    /// Unique identifier for the branch.
    /// </summary>
    public int BranchId { set; get; }

    /// <summary>
    /// Gets or sets the country of the location.
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the city of the location.
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the street of the location.
    /// </summary>
    public string Street { get; set; }

    public OpenClose OpenClose { get; set; }
}
