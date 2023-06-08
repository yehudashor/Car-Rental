using CarRentalBL.BusinessEntities.Enums;

namespace CarRentalBL.BusinessEntities.Branch;

public class BranchOpeningHoursEvent
{
    public int BranchOpeningHoursEventId { get; set; }
    public DayOfWeek StartDay { get; set; }
    public DayOfWeek EndDay { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public string EventDescription { set; get; }
    public OpenClose OpenClose { get; set; }
}
