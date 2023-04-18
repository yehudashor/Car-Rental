using AutoMapper;
using BLImplemention;
using CarRentalBL.BLApi.IBranch.IOpeningHoursService;
using CarRentalBL.BusinessEntities.Branch;
using CarRentalBL.BusinessEntities.Enums;
using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.BranchOperations;
using FluentValidation;

namespace CarRentalBL.BLImplemention.Branch.OpeningHoursService;
public class BranchOpeningHoursService : IBranchOpeningHoursService
{
    public IOpenOrCloseService OpenOrCloseService
    {
        set
        {
            _openOrCloseService = value;
        }
    }

    private IOpenOrCloseService _openOrCloseService = new OpenOrCloseService();

    private readonly IBranchOpeningHours _branchOpeningHours;

    private readonly IValidator _validator;

    private readonly IMapper _mapper;
    public BranchOpeningHoursService(IBranchOpeningHours branchOpeningHours, IValidator validator, IMapper mapper)
    {
        _branchOpeningHours = branchOpeningHours;
        _validator = validator;
        _mapper = mapper;
    }

    public async Task Add(params BranchOpeningHours[] branchOpeningHours)
    {
        CarRentalDalCore.DataObjects.BranchOperations.BranchOpeningHours[] branchOpeningHoursDo = _mapper.Map<CarRentalDalCore.DataObjects.BranchOperations.BranchOpeningHours[]>(branchOpeningHours);
        await _branchOpeningHours.AddRange(branchOpeningHoursDo);
    }

    public async Task<IEnumerable<BranchOpeningHours>> GetAllOpeningHours(Func<BranchOpeningHours, bool> filter = null)
    {
        var listBranchOpeningHours = await _branchOpeningHours.GetAll();
        return _mapper.Map<IEnumerable<BranchOpeningHours>>(listBranchOpeningHours).Where(filter);
    }

    public async Task<IEnumerable<BranchOpeningHours>> GetAllOpeningHoursByBranchId(int branchId)
    {
        var listBranchOpeningHours = await _branchOpeningHours.GetAll(filter: boh => boh.BranchId == branchId, sort: boh => boh.DayOfWeek);
        return _mapper.Map<IEnumerable<BranchOpeningHours>>(listBranchOpeningHours);
    }

    public async Task<BranchOpeningHours> GetOpeningHours(int branchId, DayOfWeek dayOfWeek)
    {
        var branchOpeningHours = await _branchOpeningHours.Get(filter: boh => boh.BranchId == branchId && boh.DayOfWeek == dayOfWeek);
        return _mapper.Map<BranchOpeningHours>(branchOpeningHours);
    }

    public async Task<OpenClose> IsOpenOrClose(int branchId, DateTime dateTime)
    {
        return await _openOrCloseService.IsOpenOrClose(branchId, dateTime);
    }

    public async Task Update(BranchOpeningHours branchOpeningHours)
    {
        CarRentalDalCore.DataObjects.BranchOperations.BranchOpeningHours branchOpeningHoursDo = _mapper.Map<CarRentalDalCore.DataObjects.BranchOperations.BranchOpeningHours>(branchOpeningHours);
        await _branchOpeningHours.Update(branchOpeningHoursDo);
    }
}
