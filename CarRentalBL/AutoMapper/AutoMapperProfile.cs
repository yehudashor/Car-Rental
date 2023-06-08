using AutoMapper;
using CarRentalBL.BusinessEntities.Branch;
using CarRentalDalCore.DataObjects.Branch;
using BranchOpeningHours = CarRentalBL.BusinessEntities.Branch.BranchOpeningHours;

namespace CarRentalBL.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Branch, BranchBase>().ReverseMap();
        CreateMap<Branch, BranchForList>().ReverseMap();
        CreateMap<CarRentalDalCore.DataObjects.Branch.BranchOpeningHours, BranchOpeningHours>().ReverseMap();
    }
}
