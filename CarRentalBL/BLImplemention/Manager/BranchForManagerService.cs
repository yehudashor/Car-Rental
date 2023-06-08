using CarRentalBL.BLApi.IBranch;
using CarRentalBL.BLApi.IManager;
using CarRentalBL.BusinessEntities.Branch;

namespace CarRentalBL.BLImplemention.Manager;

public class BranchForManagerService : IBranchForManagerService
{
    private readonly IBranchService _branchService;

    private readonly IBranchForListService _branchForListSerivce;

    public BranchForManagerService(IBranchService branchService, IBranchForListService branchForListSerivce)
    {
        _branchService = branchService;
        _branchForListSerivce = branchForListSerivce;
    }

    public event Action<IEnumerable<BranchForList>> OnOpenCloseChange;

    public async Task Add(BranchForManager branchBase)
    {
        await _branchService.Add(branchBase);
    }

    public async Task Delete(int branchId)
    {
        await _branchService.Delete(branchId);
    }

    public async Task<IEnumerable<BranchForList>> GetAllBranchForList(Func<BranchForList, bool> filter = null)
    {
        var branches = await _branchForListSerivce.GetAllBranchForList(filter);
        return branches;
    }

    public async Task<IEnumerable<BranchForList>> GetAllBranchForListByCountry(string country)
    {
        return await GetAllBranchForList(branch => branch.Country == country);
    }

    public async Task<BranchForManager> GetBranchForManager(int branchId)
    {
        var branch = await _branchService.GetBranch(branchId);

        //להןסיף את הפרמטרים הנוספים
        return (BranchForManager)branch;
    }

    public async Task Update(BranchForManager branchForManager)
    {
        await _branchService.Update(branchForManager);
    }

    //public async Task UpdateOpeningHours(BranchOpeningHours branchOpeningHours)
    //{

    //}
}
