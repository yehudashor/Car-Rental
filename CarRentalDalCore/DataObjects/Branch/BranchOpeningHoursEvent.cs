using CarRentalDalCore.DalApi.IEntity;
using CarRentalDalCore.DataObjects.Enums;

namespace CarRentalDalCore.DataObjects.Branch;

public class BranchOpeningHoursEvent : IEntity
{
    public int BranchOpeningHoursEventId { get; set; }
    public DayOfWeek StartDay { get; set; }
    public DayOfWeek EndDay { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public string EventDescription { set; get; }
    public OpenClose OpenClose { get; set; }

    /// <summary>
    /// The branch to which these opening hours apply.
    /// </summary>
    public Branch Branch { set; get; }

    public int BranchId { get; set; }
}
