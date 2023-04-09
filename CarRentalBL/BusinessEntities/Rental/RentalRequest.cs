using BusinessEntities.BranchEntities;

namespace BusinessEntities.Rental;

internal class RentalRequest
{
    /// <summary>
    /// 
    /// </summary>
    public BranchForRental BranchForRental { set; get; }

    /// <summary>
    /// The start date of the rental period.
    /// </summary>
    public DateTime RentalStart { set; get; }

    /// <summary>
    /// The end date of the rental period.
    /// </summary>
    public DateTime RentalEnd { set; get; }
}
