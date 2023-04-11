namespace BusinessEntities;

public class RentalRequest
{
    public Branch CollectionBranch { get; set; }
    public Branch ReturnBranch { get; set; }

    /// <summary>
    /// The start date of the rental period.
    /// </summary>
    public DateTime CollectionTime { set; get; }

    /// <summary>
    /// The end date of the rental period.
    /// </summary>
    public DateTime ReturnTime { set; get; }

    public int TotalDaysNumber { set; get; }
}
