using CarRentalDalCore.DalApi.IEntity;

namespace CarRentalDalCore.DataObjects.Branch;

// Represents the opening hours for a branch on a given day of the week.
public class BranchOpeningHours : IEntity
{
    public int BranchId { set; get; }

    public DayOfWeek FromDay { set; get; }
    public DayOfWeek ToDay { set; get; }

    /// <summary>
    /// The branch to which these opening hours apply.
    /// </summary>
    public Branch Branch { set; get; }

    /// <summary>
    /// The time at which the branch opens on the specified day of the week.
    /// </summary>
    public TimeOnly StartTime { set; get; }

    /// <summary>
    /// The time at which the branch closes on the specified day of the week.
    /// </summary>
    public TimeOnly EndTime { set; get; }
}

