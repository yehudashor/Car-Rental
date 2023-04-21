using CarRentalBL.BLApi.IBranch.IOpeningHoursService;
using CarRentalBL.BusinessEntities.Enums;
using CarRentalDalCore.DalApi.IEntityDal;

namespace CarRentalBL.BLImplemention.Branch.OpeningHoursService;

internal class OpenOrCloseService : IOpenOrCloseService
{
    private readonly IBranchOpeningHours _ibranchOpeningHours;

    public async Task<OpenClose> IsOpenOrClose(int branchId, DateTime dateTime)
    {
        TimeOnly time = TimeOnly.FromDateTime(dateTime);

        bool isOpenOrClose = await _ibranchOpeningHours.Any(boh => boh.BranchId == branchId &&
        boh.DayOfWeek == dateTime.DayOfWeek && boh.StartTime < time && boh.EndTime > time);

        return isOpenOrClose ? OpenClose.Open : OpenClose.Close;
    }
}
