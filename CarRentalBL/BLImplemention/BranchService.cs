using AutoMapper;
using BLApi;
using BusinessEntities;
using DalApi.IEntityDal;
using FluentValidation;
using System.Runtime.InteropServices;

namespace BLImplemention;

public class BranchService : IBranchService
{
    private readonly IValidator _validator;

    private readonly IBranch _branch;

    private readonly IBranchOpeningHoursService _branchOpeningHoursService;

    private readonly IMapper _mapper;

    public BranchService(IBranch branch, IBranchOpeningHoursService branchOpeningHoursService,
        IValidator validator, IMapper mapper)
    {
        _branch = branch;
        _branchOpeningHoursService = branchOpeningHoursService;
        _validator = validator;
        _mapper = mapper;
    }

    public Task<IEnumerable<BranchForList>> GetBranchForList(Func<BranchForList, bool> filter)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<BranchForList>> GetBranchForListByCountry(string countryName)
    {
        IEnumerable<DataObjects.Branch> branches = await _branch.GetAll(
            filter: b => b.BranchLocation.Location.Country == countryName,
            sort: b => b.BranchLocation.Location.City,
             b => b.BranchLocation.Location, b => b.OpeningHoursList);

        var branchForLists = _mapper.Map<IEnumerable<BranchForList>>(branches);

        var numberBranchesInCity = branchForLists
            .GroupBy(b => b.City)
            .ToDictionary(g => g.Key, g => g.Count());

        branchForLists = branchForLists.Select(branchForList =>
        {
            //bool isOpenNow = await IsBranchOpen(branchForList.BranchId, DateTime.Now);

            if (numberBranchesInCity[branchForList.City] > 0)
            {
                branchForList.Description.Append(branchForList.City);
                branchForList.Description.Append(branchForList.Street);
            }
            else
            {
                branchForList.Description.Append(branchForList.City);
            }
            return branchForList;
        });

        return branchForLists;
    }

    public Task<bool> IsBranchesOpen(params (int, DateTime)[] branchesAndTimes)
    {
        throw new NotImplementedException();
    }

    private Dictionary<string, int> countBranchesInEachCity(IEnumerable<BranchForList> branchForLists)
    {
        Dictionary<string, int> numberBranchesInCity = new Dictionary<string, int>();

        foreach (var branchForList in branchForLists)
        {
            ref var valOrNew = ref CollectionsMarshal
                  .GetValueRefOrAddDefault(numberBranchesInCity, branchForList.City, out bool exists);

            if (exists)
            {
                valOrNew++;
            }
        }
        return numberBranchesInCity;
    }

    //public Task<bool> IsBranchesOpen(params (int, DateTime)[] branchesAndTimes)
    //{
    //    //return Task.FromResult(branchesAndTimes.All(async oh => await _branchOpeningHoursService.IsBranchOpen(oh.Item1, oh.Item2)));
    //}


}
