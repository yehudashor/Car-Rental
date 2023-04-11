using BusinessEntities;

namespace BLApi;

public interface IBranchService
{
    Task<IEnumerable<BranchForList>> GetBranchForList(Func<BranchForList, bool> filter);
    Task<IEnumerable<BranchForList>> GetBranchForListByCountry(string countryName);
    Task<bool> IsBranchesOpen(params (int, DateTime)[] branchesAndTimes);
}
