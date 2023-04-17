using BusinessEntities;

namespace BLApi;

public interface IBranchForCustomerService
{
    Task<BranchForCustomer> GetBranchForCustomer(int branchId);
    Task<IEnumerable<BranchForList>> GetAllBranchForListByCountry(string country);
}
