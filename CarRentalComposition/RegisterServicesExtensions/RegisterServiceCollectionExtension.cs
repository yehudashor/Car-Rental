using Microsoft.Extensions.DependencyInjection;

namespace CarRentalComposition.RegisterServicesExtensions;

public static class RegisterServiceCollectionExtension
{
    public static void RegisterServicesCollection(this IServiceCollection services)
    {
        services.RegisterAutoMapper();

    }
}
