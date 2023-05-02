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

    public Task Add(BranchBase branchBase)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int branchId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BranchForList>> GetAllBranchForList(Func<BranchForList, bool> filter = null)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BranchForList>> GetAllBranchForListByCountry(string country)
    {
        throw new NotImplementedException();
    }

    public async Task<BranchForManager> GetBranchForManager(int branchId)
    {
        var branch = await _branchService.GetBranch(branchId);

        //להןסיף את הפרמטרים הנוספים
        return (BranchForManager)branch;

    }

    public Task Update(BranchBase branchBase)
    {
        throw new NotImplementedException();
    }

    public Task UpdateOpeningHours(BranchOpeningHours branchOpeningHours)
    {
        throw new NotImplementedException();
    }
}
