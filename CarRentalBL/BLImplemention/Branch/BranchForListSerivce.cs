using AutoMapper;
using BLApi;
using BusinessEntities;
using DalApi.IEntityDal;
using FluentValidation;

namespace BLImplemention;

public class BranchForListSerivce : IBranchForListSerivce
{
    private readonly IBranch _ibranch;

    private readonly IBranchOpeningHoursService _ibranchOpeningHoursService;

    private readonly IValidator _validator;

    private readonly IMapper _mapper;

    public BranchForListSerivce(IBranch ibranch, IBranchOpeningHoursService ibranchOpeningHoursService, IValidator validator, IMapper mapper)
    {
        _ibranch = ibranch;
        _ibranchOpeningHoursService = ibranchOpeningHoursService;
        _validator = validator;
        _mapper = mapper;
    }

    public Task<IEnumerable<BranchForList>> GetAllBranchForList(Func<BranchForList, bool> filter)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BranchForList>> GetAllBranchForListByCountry(string country)
    {
        throw new NotImplementedException();
    }
}
