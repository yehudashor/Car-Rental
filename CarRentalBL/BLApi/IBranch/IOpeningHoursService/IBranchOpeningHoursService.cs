using CarRentalBL.BusinessEntities.Branch;
using CarRentalBL.BusinessEntities.Enums;

namespace CarRentalBL.BLApi.IBranch.IOpeningHoursService;

public interface IBranchOpeningHoursService
{
    Task<IEnumerable<BranchOpeningHours>> GetAllOpeningHours(Func<BranchOpeningHours, bool> filter = null);
    Task<IEnumerable<BranchOpeningHours>> GetAllOpeningHoursByBranchId(int branchId);
    Task<BranchOpeningHours> GetOpeningHours(int branchId, DayOfWeek dayOfWeek);

    Task Add(params BranchOpeningHours[] branchOpeningHours);

    Task Update(BranchOpeningHours branchOpeningHours);

    Task<OpenClose> IsOpenOrClose(int branchId, DateTime dateTime);

    IOpenOrCloseService OpenOrCloseService { set; }
}
