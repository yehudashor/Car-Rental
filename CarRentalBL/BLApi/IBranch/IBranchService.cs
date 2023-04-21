using CarRentalBL.BusinessEntities.Branch;

namespace CarRentalBL.BLApi.IBranch;

public interface IBranchService
{
    Task Add(BranchBase branchBase);
    Task Update(BranchBase branchBase);
    Task Delete(int branchId);
    Task<BranchBase> GetBranch(int branchId);
    Task UpdateOpeningHours(BranchOpeningHours branchOpeningHours);
}
