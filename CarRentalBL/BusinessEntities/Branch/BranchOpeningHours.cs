namespace CarRentalBL.BusinessEntities.Branch;

public class BranchOpeningHours
{
    public DayOfWeek FromDay { set; get; }
    public DayOfWeek ToDay { set; get; }

    /// <summary>
    /// The branch to which these opening hours apply.
    /// </summary> 
    public int BranchId { set; get; }

    /// <summary>
    /// The time at which the branch opens on the specified day of the week.
    /// </summary>
    public TimeOnly? StartTime { set; get; }

    /// <summary>
    /// The time at which the branch closes on the specified day of the week.
    /// </summary>
    public TimeOnly? EndTime { set; get; }
}
