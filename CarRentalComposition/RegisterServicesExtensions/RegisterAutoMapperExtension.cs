using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CarRentalComposition.RegisterServicesExtensions;

internal static class RegisterAutoMapperExtension
{
    public static IServiceCollection RegisterAutoMapper(this IServiceCollection services)
    {
        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile<CarRentalBL.AutoMapper.AutoMapperProfile>();
        });

        IMapper mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);

        return services;
    }
}
