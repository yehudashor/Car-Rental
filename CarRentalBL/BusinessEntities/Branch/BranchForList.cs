using System.Text;

namespace BusinessEntities;

public class BranchForList
{
    /// <summary>
    /// Unique identifier for the branch.
    /// </summary>
    public int BranchId { set; get; }

    /// <summary>
    /// Gets or sets the city of the location.
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the street of the location.
    /// </summary>
    public string Street { get; set; }

    public OpenClose OpenClose { get; set; }

    public StringBuilder Description { get; } = new StringBuilder();
}
