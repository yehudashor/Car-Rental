using CarRentalBL.BusinessEntities.Branch;

namespace CarRentalBL.BLApi.IManager;

public interface IBranchForManagerService
{
    Task Add(BranchBase branchBase);
    Task Update(BranchBase branchBase);
    Task Delete(int branchId);
    Task<BranchForManager> GetBranchForManager(int branchId);
    Task UpdateOpeningHours(BranchOpeningHours branchOpeningHours);

    event Action<IEnumerable<BranchForList>> OnOpenCloseChange;
    Task<IEnumerable<BranchForList>> GetAllBranchForList(Func<BranchForList, bool> filter = null);
    Task<IEnumerable<BranchForList>> GetAllBranchForListByCountry(string country);
}
