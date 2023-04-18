namespace CarRentalBL.BusinessEntities.Branch;

public class BranchOpeningHours
{
    /// <summary>
    /// The day of the week and the second key part of which these opening hours apply.
    /// </summary>
    public DayOfWeek DayOfWeek { set; get; }

    /// <summary>
    /// The branch to which these opening hours apply.
    /// </summary> 
    public BranchBase Branch { set; get; }

    /// <summary>
    /// The time at which the branch opens on the specified day of the week.
    /// </summary>
    public TimeOnly StartTime { set; get; }

    /// <summary>
    /// The time at which the branch closes on the specified day of the week.
    /// </summary>
    public TimeOnly EndTime { set; get; }
}
