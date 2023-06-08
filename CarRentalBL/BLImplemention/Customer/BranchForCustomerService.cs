using CarRentalBL.BLApi.IBranch;
using CarRentalBL.BLApi.ICustomer;
using CarRentalBL.BusinessEntities.Branch;

namespace CarRentalBL.BLImplemention.Customer;

public class BranchForCustomerService : IBranchForCustomerService
{
    private readonly IBranchService _branchService;

    private readonly IBranchForListService _branchForListSerivce;

    public BranchForCustomerService(IBranchService branchService, IBranchForListService branchForListSerivce)
    {
        _branchService = branchService;
        _branchForListSerivce = branchForListSerivce;
    }

    public async Task<IEnumerable<BranchForList>> GetAllBranchForListByCountry(string country)
        => await _branchForListSerivce.GetAllBranchForListByCountry(country);


    public async Task<BranchForCustomer> GetBranchForCustomer(int branchId)
    {
        var branch = await _branchService.GetBranch(branchId);
        return new BranchForCustomer { BranchBase = branch };
    }
}
