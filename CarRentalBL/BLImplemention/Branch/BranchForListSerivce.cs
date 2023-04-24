using AutoMapper;
using CarRentalBL.BLApi.IBranch;
using CarRentalBL.BLApi.IBranch.IOpeningHoursService;
using CarRentalBL.BusinessEntities.Branch;
using CarRentalBL.BusinessEntities.Enums;
using CarRentalDalCore.DalApi.IEntityDal;
using FluentValidation;
namespace CarRentalBL.BLImplemention.Branch;

public class BranchForListSerivce : IBranchForListSerivce
{
    private Dictionary<int, BranchForList> _branchForLists;

    private readonly IBranch _branch;

    private readonly IBranchOpeningHoursService _branchOpeningHoursService;

    private readonly IValidator _validator;

    private readonly IMapper _mapper;

    private readonly System.Timers.Timer _timer;

    private event Action<IEnumerable<BranchForList>> _onOpenCloseChange;

    public event Action<IEnumerable<BranchForList>> OnOpenCloseChange
    {
        add { _onOpenCloseChange += value; }
        remove { _onOpenCloseChange -= value; }
    }

    public BranchForListSerivce(IBranch ibranch, IBranchOpeningHoursService ibranchOpeningHoursService, IValidator validator, IMapper mapper)
    {
        _branch = ibranch;
        _branchOpeningHoursService = ibranchOpeningHoursService;
        _validator = validator;
        _mapper = mapper;

        _timer = new System.Timers.Timer(600000)
        {
            AutoReset = true,
        };
        _timer.Elapsed += (sender, e) => onOpenClose();
    }

    public async Task<IEnumerable<BranchForList>> GetAllBranchForList(Func<BranchForList, bool> filter = null)
    {
        //לטפל במילון ןלהוסיף תתיאור של העיר והרחוב
        if (_branchForLists is null)
        {
            var branches = await _branch.GetAll(sort: b => b.BranchLocation.Location.City,
                       includeProperties: b => b.BranchLocation.Location);

            _branchForLists = _mapper.Map<IEnumerable<BranchForList>>(branches).Where(filter).ToDictionary(bfl => bfl.BranchId);

            _timer.Start();
        }
        return _branchForLists.Values;
    }

    private async void onOpenClose()
    {
        bool wasChange = false;

        foreach (var branchForList in _branchForLists)
        {
            OpenClose previousOpenClose = branchForList.Value.OpenClose;
            branchForList.Value.OpenClose = await _branchOpeningHoursService.IsOpenOrClose(branchForList.Value.BranchId, DateTime.Now);

            if (previousOpenClose != branchForList.Value.OpenClose)
            {
                wasChange = true;
            }
        }

        if (wasChange)
        {
            //לעורר את האירוע עי הןספה מתודות הרחבה
        }
    }

    public Task<IEnumerable<BranchForList>> GetAllBranchForListByCountry(string country)
    {
        throw new NotImplementedException();
    }
}
