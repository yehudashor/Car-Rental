using AutoMapper;
using CarRentalBL.BLApi.IBranch;
using CarRentalBL.BLApi.IBranch.IOpeningHoursService;
using CarRentalBL.BusinessEntities.Branch;
using CarRentalDalCore.DalApi.IEntityDal;
using FluentValidation;
using BranchDo = CarRentalDalCore.DataObjects.Branch.Branch;

namespace CarRentalBL.BLImplemention.Branch;

public class BranchService : IBranchService
{
    private readonly IBranch _branch;

    private readonly IBranchOpeningHoursService _branchOpeningHoursService;

    private readonly IValidator _validator;

    private readonly IMapper _mapper;

    public BranchService(IBranch ibranch, IBranchOpeningHoursService ibranchOpeningHoursService, IMapper imapper)
    {
        _branch = ibranch;
        _branchOpeningHoursService = ibranchOpeningHoursService;
        _mapper = imapper;
    }

    public async Task Add(BranchBase branchBase)
    {
        await _branchOpeningHoursService.AddRange(branchBase.BranchId, branchBase.OpeningHoursList);

        var branch = _mapper.Map<BranchDo>(branchBase);

        await _branch.Add(branch);
    }

    public async Task Delete(int branchId)
    {
        await _branch.Delete(branch => branch.BranchId == branchId);
    }

    public async Task<BranchBase> GetBranch(int branchId)
    {
        var branch = await _branch.Get(
            b => b.BranchId == branchId,
            b => b.BranchLocation.Location,
            b => b.OpeningHoursList,
            b => b.BranchOpeningHoursEvents);

        var branchForCustomer = _mapper.Map<BranchBase>(branch);

        return branchForCustomer;
    }

    public async Task Update(BranchBase branchBase)
    {
        var branch = _mapper.Map<BranchDo>(branchBase);
        await _branch.Update(branch);
    }

    public async Task UpdateOpeningHours(BranchOpeningHours branchOpeningHours)
    {
        await _branchOpeningHoursService.Add(branchOpeningHours);
    }

    public async Task DeleteOpeningHours(BranchOpeningHours branchOpeningHours)
    {
        await _branchOpeningHoursService.Delete(branchOpeningHours);
    }

    //public async Task<IEnumerable<BranchForList>> GetBranchForListByCountry(string countryName)
    //{
    //    IEnumerable<DataObjects.BranchId> branches = await _branch.GetAll(
    //        filter: b => b.BranchLocation.Location.Country == countryName,
    //        sort: b => b.BranchLocation.Location.City,
    //         b => b.BranchLocation.Location, b => b.OpeningHoursList);

    //    var branchForLists = _mapper.Map<IEnumerable<BranchForList>>(branches);

    //    var numberBranchesInCity = branchForLists
    //        .GroupBy(b => b.City)
    //        .ToDictionary(g => g.Key, g => g.Count());

    //    branchForLists = branchForLists.Select(branchForList =>
    //    {
    //        //bool isOpenNow = await IsBranchOpen(branchForList.BranchId, DateTime.Now);

    //        if (numberBranchesInCity[branchForList.City] > 0)
    //        {
    //            branchForList.Description.Append(branchForList.City);
    //            branchForList.Description.Append(branchForList.Street);
    //        }
    //        else
    //        {
    //            branchForList.Description.Append(branchForList.City);
    //        }
    //        return branchForList;
    //    });

    //    return branchForLists;
    //}

    //public Task<bool> IsBranchesOpen(params (int, DateTime)[] branchesAndTimes)
    //{
    //    throw new NotImplementedException();
    //}

    //private Dictionary<string, int> countBranchesInEachCity(IEnumerable<BranchForList> branchForLists)
    //{
    //    Dictionary<string, int> numberBranchesInCity = new Dictionary<string, int>();

    //    foreach (var branchForList in branchForLists)
    //    {
    //        ref var valOrNew = ref CollectionsMarshal
    //              .GetValueRefOrAddDefault(numberBranchesInCity, branchForList.City, out bool exists);

    //        if (exists)
    //        {
    //            valOrNew++;
    //        }
    //    }
    //    return numberBranchesInCity;
    //}

    //public Task<bool> IsBranchesOpen(params (int, DateTime)[] branchesAndTimes)
    //{
    //    //return Task.FromResult(branchesAndTimes.All(async oh => await _branchOpeningHoursService.IsBranchOpen(oh.Item1, oh.Item2)));
    //}
}
