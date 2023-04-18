using CarRentalBL.BusinessEntities.Branch;

namespace CarRentalBL.BLApi.IBranch;

public interface IBranchForListSerivce
{
    event Action<IEnumerable<BranchForList>> OnOpenCloseChange;
    Task<IEnumerable<BranchForList>> GetAllBranchForList(Func<BranchForList, bool> filter = null);
    Task<IEnumerable<BranchForList>> GetAllBranchForListByCountry(string country);

}
