using BusinessEntities;

namespace BLApi;

public interface IBranchForListSerivce
{
    Task<IEnumerable<BranchForList>> GetAllBranchForList(Func<BranchForList, bool> filter);
    Task<IEnumerable<BranchForList>> GetAllBranchForListByCountry(string country);

}
