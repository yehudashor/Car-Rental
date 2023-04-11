using BusinessEntities;

namespace BLApi;

public interface IBranchOpeningHoursService
{
    Task<IEnumerable<BranchOpeningHours>> GetAllBranchOpeningHours();

}
