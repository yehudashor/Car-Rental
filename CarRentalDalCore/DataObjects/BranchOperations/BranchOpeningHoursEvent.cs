using CarRentalDalCore.DalApi.IEntity;
using CarRentalDalCore.DataObjects.Enums;

namespace CarRentalDalCore.DataObjects.BranchOperations;

public class BranchOpeningHoursEvent : IEntity
{
    public int BranchOpeningHoursEventId { get; set; }
    public int StartDay { get; set; }
    public int EndDay { get; set; }
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
