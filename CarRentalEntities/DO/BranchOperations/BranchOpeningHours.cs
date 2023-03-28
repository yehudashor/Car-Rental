using CarRentalEntities.IEntity;

namespace DO;

public class BranchOpeningHours : IEntity
{
    public int BranchOpeningHoursId { get; set; }
    public DayOfWeek DayOfWeek { set; get; }

    public Branch Branch { set; get; }

    public int BranchId { set; get; }

    /// <summary>
    /// 
    /// </summary>
    public TimeOnly StartTime { set; get; }

    /// <summary>
    /// 
    /// </summary>
    public TimeOnly EndTime { set; get; }

}
