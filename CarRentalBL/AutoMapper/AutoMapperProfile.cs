using BusinessEntities;

namespace AutoMapper;

internal class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<DataObjects.Branch, BranchBase>().ReverseMap();
        CreateMap<DataObjects.Branch, BranchForList>().ReverseMap();
        CreateMap<DataObjects.BranchOpeningHours, BranchOpeningHours>().ReverseMap();
    }
}
