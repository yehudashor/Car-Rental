using AutoMapper;
using CarRentalBL.BusinessEntities.Branch;
using CarRentalDalCore.DataObjects.BranchOperations;

namespace CarRentalBL.AutoMapper;

internal class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Branch, BranchBase>().ReverseMap();
        CreateMap<Branch, BranchForList>().ReverseMap();
        CreateMap<CarRentalDalCore.DataObjects.BranchOperations.BranchOpeningHours, BranchOpeningHours>().ReverseMap();
    }
}
