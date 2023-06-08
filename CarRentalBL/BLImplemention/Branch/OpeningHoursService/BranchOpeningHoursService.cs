using AutoMapper;
using CarRentalBL.BLApi.IBranch.IOpeningHoursService;
using CarRentalBL.BusinessEntities.Branch;
using CarRentalBL.BusinessEntities.Enums;
using CarRentalDalCore.DalApi.IEntityDal;
using FluentValidation;
using BranchOpeningHoursDo = CarRentalDalCore.DataObjects.Branch.BranchOpeningHours;

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

    public BranchOpeningHoursService(IBranchOpeningHours branchOpeningHours, IMapper mapper)
    {
        _branchOpeningHours = branchOpeningHours;
        _mapper = mapper;
    }

    public async Task AddRange(int branchId, ICollection<BranchOpeningHours> branchesOpeningHours)
    {
        var openingHoursDo = await _branchOpeningHours.GetAll(boh => boh.BranchId == branchId);

        foreach (var openingHours in branchesOpeningHours)
        {
            await openingHoursArrangement(openingHours, openingHoursDo);
        }

        BranchOpeningHoursDo[] branchOpeningHoursDo = _mapper.Map<BranchOpeningHoursDo[]>(branchesOpeningHours);
        await _branchOpeningHours.AddRange(branchOpeningHoursDo);
    }

    public async Task Add(BranchOpeningHours branchOpeningHours)
    {
        var openingHoursDo = await _branchOpeningHours.GetAll(boh => boh.BranchId == branchOpeningHours.BranchId);

        await openingHoursArrangement(branchOpeningHours, openingHoursDo);

        BranchOpeningHoursDo branchOpeningHoursDo = _mapper.Map<BranchOpeningHoursDo>(branchOpeningHours);
        await _branchOpeningHours.Add(branchOpeningHoursDo);
    }

    private async Task openingHoursArrangement(BranchOpeningHours branchOpeningHours, IEnumerable<BranchOpeningHoursDo> branchesOpeningHours)
    {
        bool startAfter, endBefore;

        foreach (var openingHours in branchesOpeningHours)
        {
            startAfter = openingHours.FromDay >= branchOpeningHours.FromDay;
            endBefore = openingHours.ToDay <= branchOpeningHours.ToDay;

            if (startAfter && endBefore)
            {
                await _branchOpeningHours.Delete(openingHours);
                continue;
            }
            else if (endBefore)
            {
                var dayBeforeStart = branchOpeningHours.FromDay - 1;
                openingHours.ToDay = dayBeforeStart;
            }
            else
            {
                var dayAfterEnd = branchOpeningHours.FromDay + 1;
                openingHours.FromDay = dayAfterEnd;
            }

            await _branchOpeningHours.Update(openingHours);
        }
    }

    public async Task<IEnumerable<BranchOpeningHours>> GetAllOpeningHours(Func<BranchOpeningHours, bool> filter = null)
    {
        var listBranchOpeningHours = await _branchOpeningHours.GetAll();
        return _mapper.Map<IEnumerable<BranchOpeningHours>>(listBranchOpeningHours).Where(filter);
    }

    public async Task<IEnumerable<BranchOpeningHours>> GetBranchOpeningHours(int branchId)
    {
        var branchOpeningHoursDo = await _branchOpeningHours.GetAll(filter:
            boh => boh.BranchId == branchId,
            sort: boh => boh.FromDay);

        List<BranchOpeningHours> branchOpeningHoursBo = null;

        if (branchOpeningHoursDo.Any())
        {
            branchOpeningHoursBo = _mapper.Map<List<BranchOpeningHours>>(branchOpeningHoursDo);

            var first = branchOpeningHoursBo.First();
            var last = branchOpeningHoursBo.Last();

            if (first.FromDay is not DayOfWeek.Sunday)
            {
                branchOpeningHoursBo.Insert(0, new BranchOpeningHours { FromDay = DayOfWeek.Sunday, ToDay = last.FromDay - 1, });
            }

            if (last.ToDay is not DayOfWeek.Saturday)
            {
                branchOpeningHoursBo.Add(new BranchOpeningHours { FromDay = last.ToDay + 1, ToDay = DayOfWeek.Saturday });
            }

            var count = branchOpeningHoursBo.Count() - 1;

            for (int i = 2; i < count; i++)
            {
                var difDays = branchOpeningHoursBo[i].FromDay - branchOpeningHoursBo[i - 1].ToDay;

                if (difDays > 1)
                {
                    DayOfWeek fromDay = branchOpeningHoursBo[i - 1].ToDay + 1;
                    DayOfWeek toDay = branchOpeningHoursBo[i].FromDay - 1;

                    branchOpeningHoursBo.Insert(i, new BranchOpeningHours { FromDay = fromDay, ToDay = toDay });
                }
            }
        }

        return branchOpeningHoursBo;
    }

    public async Task<OpenClose> IsOpenOrClose(int branchId, DateTime dateTime)
    {
        return await _openOrCloseService.IsOpenOrClose(branchId, dateTime);
    }

    public async Task Update(BranchOpeningHours branchOpeningHours)
    {
        BranchOpeningHoursDo branchOpeningHoursDo = _mapper.Map<BranchOpeningHoursDo>(branchOpeningHours);
        await _branchOpeningHours.Update(branchOpeningHoursDo);
    }

    public async Task Delete(BranchOpeningHours branchOpeningHours)
    {
        await _branchOpeningHours.Delete(opening => opening.BranchId == branchOpeningHours.BranchId &&
        opening.FromDay == branchOpeningHours.FromDay && opening.ToDay == branchOpeningHours.ToDay);
    }
}
