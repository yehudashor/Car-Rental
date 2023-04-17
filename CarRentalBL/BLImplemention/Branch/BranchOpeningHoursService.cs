using AutoMapper;
using BLApi;
using BusinessEntities;
using DalApi.IEntityDal;
using FluentValidation;

namespace BLImplemention.Branch;

public class BranchOpeningHoursService : IBranchOpeningHoursService
{
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
        DataObjects.BranchOpeningHours[] branchOpeningHoursDo = _mapper.Map<DataObjects.BranchOpeningHours[]>(branchOpeningHours);
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
        TimeOnly time = TimeOnly.FromDateTime(dateTime);

        bool isOpenOrClose = await _branchOpeningHours.Any(boh => boh.BranchId == branchId &&
        boh.DayOfWeek == dateTime.DayOfWeek && boh.StartTime < time && boh.EndTime > time);

        return isOpenOrClose ? OpenClose.Open : OpenClose.Close;
    }

    public async Task Update(BranchOpeningHours branchOpeningHours)
    {
        DataObjects.BranchOpeningHours branchOpeningHoursDo = _mapper.Map<DataObjects.BranchOpeningHours>(branchOpeningHours);
        await _branchOpeningHours.Update(branchOpeningHoursDo);
    }
}
