
using AutoMapper;
using BLApi;
using BusinessEntities;
using DalApi.IEntityDal;
using FluentValidation;

namespace BLImplemention;

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

    public Task<IEnumerable<BranchOpeningHours>> GetAllBranchOpeningHours()
    {
        throw new NotImplementedException();
    }
}
