using BLApi;
using BusinessEntities;

namespace BLImplemention;

public class BranchForCustomerService : IBranchForCustomerService
{
    private readonly IBranchService _branchService;

    private readonly IBranchForListSerivce _branchForListSerivce;

    public BranchForCustomerService(IBranchService branchService, IBranchForListSerivce branchForListSerivce)
    {
        _branchService = branchService;
        _branchForListSerivce = branchForListSerivce;
    }

    public async Task<IEnumerable<BranchForList>> GetAllBranchForListByCountry(string country)
        => await _branchForListSerivce.GetAllBranchForListByCountry(country);


    public async Task<BranchForCustomer> GetBranchForCustomer(int branchId)
    {
        var branch = await _branchService.GetBranch(branchId);
        return (BranchForCustomer)branch;
    }
}
