using CarRentalBL.BusinessEntities.Enums;

namespace CarRentalBL.BLApi.IBranch.IOpeningHoursService;

public interface IOpenOrCloseService
{
    Task<OpenClose> IsOpenOrClose(int branchId, DateTime dateTime);
}
