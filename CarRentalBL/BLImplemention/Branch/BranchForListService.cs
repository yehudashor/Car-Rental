using AutoMapper;
using CarRentalBL.BLApi.IBranch;
using CarRentalBL.BLApi.IBranch.IOpeningHoursService;
using CarRentalBL.BusinessEntities.Branch;
using CarRentalBL.BusinessEntities.Enums;
using CarRentalDalCore.DalApi.IEntityDal;
using FluentValidation;

namespace CarRentalBL.BLImplemention.Branch;

public class BranchForListService : IBranchForListService
{
    private readonly IBranch _branch;

    private readonly IBranchOpeningHoursService _branchOpeningHoursService;

    private readonly IValidator _validator;

    private readonly IMapper _mapper;

    private readonly System.Timers.Timer _openCloseTimer;

    private event Action<IEnumerable<BranchForList>> _onOpenCloseChange;

    public event Action<IEnumerable<BranchForList>> OnOpenCloseChange
    {
        add { _onOpenCloseChange += value; }
        remove { _onOpenCloseChange -= value; }
    }

    public BranchForListService(IBranch ibranch, IBranchOpeningHoursService ibranchOpeningHoursService, IMapper mapper)
    {
        _branch = ibranch;
        _branchOpeningHoursService = ibranchOpeningHoursService;

        _mapper = mapper;

        _openCloseTimer = new System.Timers.Timer(600000)
        {
            AutoReset = true,
        };
    }

    public async Task<IEnumerable<BranchForList>> GetAllBranchForList(Func<BranchForList, bool> filter = null)
    {
        var branches = await _branch.GetAll(sort: b => b.BranchLocation.Location.City,
                      includeProperties: b => b.BranchLocation.Location);

        var branchesForList = _mapper.Map<IEnumerable<BranchForList>>(branches).Where(filter);

        _openCloseTimer.Elapsed += (sender, e) => onOpenClose(branchesForList);
        _openCloseTimer.Start();

        return branchesForList;
    }

    private async void onOpenClose(IEnumerable<BranchForList> branchesForList)
    {
        bool wasChange = false;

        foreach (var branchForList in branchesForList)
        {
            OpenClose previousOpenClose = branchForList.OpenClose;
            branchForList.OpenClose = await _branchOpeningHoursService.IsOpenOrClose(branchForList.BranchId, DateTime.Now);

            if (previousOpenClose != branchForList.OpenClose)
            {
                wasChange = true;
            }
        }

        if (wasChange)
        {
            //לעורר את האירוע עי הוספת מתודות הרחבה
        }
    }

    public async Task<IEnumerable<BranchForList>> GetAllBranchForListByCountry(string country)
    {
        var branches = await _branch.GetAll(filter: b => b.BranchLocation.Location.Country == country,
        sort: b => b.BranchLocation.Location.City, includeProperties: b => b.BranchLocation.Location);

        var branchesForList = _mapper.Map<IEnumerable<BranchForList>>(branches);

        _openCloseTimer.Elapsed += (sender, e) => onOpenClose(branchesForList);
        _openCloseTimer.Start();

        return branchesForList;
    }
}
