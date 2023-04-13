
namespace BusinessEntities;

public class BranchForManager : BranchBase
{
    /// <summary>
    /// The opening hours for the branch, stored as a collection of daily opening hour entities.
    /// </summary>
    public ICollection<Car> Cars { set; get; }

    public int AvailableCarsNumber { get; set; }

    public int UnavailableCarsNumber { get; set; }
}
