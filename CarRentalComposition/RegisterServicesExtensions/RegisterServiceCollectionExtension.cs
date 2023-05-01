using CarRentalComposition.RegisterServicesExtensions;
using Microsoft.Extensions.DependencyInjection;

namespace CarRentalComposition.RegisterServicesExtension;

public static class RegisterServiceCollectionExtension
{
    public static void RegisterServicesCollection(this IServiceCollection services)
    {
        services.RegisterAutoMapper();


    }
}
