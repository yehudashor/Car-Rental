using BusinessEntities;

namespace BLApi;

public interface IOpenOrCloseService
{
    Task<OpenClose> IsOpenOrClose(int branchId, DateTime dateTime);
}
