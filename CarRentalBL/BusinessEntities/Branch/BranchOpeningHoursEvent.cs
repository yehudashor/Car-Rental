using CarRentalBL.BusinessEntities.Enums;

namespace CarRentalBL.BusinessEntities.Branch;

public class BranchOpeningHoursEvent
{
    public int BranchOpeningHoursEventId { get; set; }
    public int StartDay { get; set; }
    public int EndDay { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public string EventDescription { set; get; }
    public OpenClose OpenClose { get; set; }
}
