using CarRentalBL.BusinessEntities.Branch;

namespace CarRentalBL.BLApi.ICustomer;

public interface IBranchForCustomerService
{
    Task<BranchForCustomer> GetBranchForCustomer(int branchId);
    Task<IEnumerable<BranchForList>> GetAllBranchForListByCountry(string country);
}
