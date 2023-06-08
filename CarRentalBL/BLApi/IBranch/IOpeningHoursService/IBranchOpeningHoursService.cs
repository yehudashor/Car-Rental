using CarRentalBL.BusinessEntities.Branch;
using CarRentalBL.BusinessEntities.Enums;

namespace CarRentalBL.BLApi.IBranch.IOpeningHoursService;

public interface IBranchOpeningHoursService
{
    Task<IEnumerable<BranchOpeningHours>> GetAllOpeningHours(Func<BranchOpeningHours, bool> filter = null);
    Task<IEnumerable<BranchOpeningHours>> GetBranchOpeningHours(int branchId);
    Task AddRange(int branchId, ICollection<BranchOpeningHours> branchesOpeningHours);
    Task Add(BranchOpeningHours branchOpeningHours);
    Task Delete(BranchOpeningHours branchOpeningHours);

    Task Update(BranchOpeningHours branchOpeningHours);

    Task<OpenClose> IsOpenOrClose(int branchId, DateTime dateTime);

    IOpenOrCloseService OpenOrCloseService { set; }
}
