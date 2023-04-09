
namespace BusinessEntities.BranchEntities;

internal class BranchOpeningHours
{

    /// <summary>
    /// Foreign key and the first key part of the branch entity.
    /// </summary>
    public int BranchId { set; get; }

    /// <summary>
    /// The day of the week and the second key part of which these opening hours apply.
    /// </summary>
    public DayOfWeek DayOfWeek { set; get; }

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
