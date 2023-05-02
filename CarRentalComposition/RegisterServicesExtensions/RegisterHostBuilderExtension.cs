using Autofac.Extensions.DependencyInjection;
using CarRentalComposition.Autofac.Extensions;
using Microsoft.Extensions.Hosting;

namespace CarRentalComposition.RegisterServicesExtensions;

public static class RegisterHostBuilderExtension
{
    public static void RegisterHostBuilder(this IHostBuilder hostBuilder)
    {
        hostBuilder.UseServiceProviderFactory(new AutofacServiceProviderFactory(builder =>
        {
            builder.RegisterAssemblyTypesWhere("CarRentalBL", t => t.Name.EndsWith("Service") && t.IsClass);
            builder.RegisterAssemblyTypesWhere(nameof(CarRentalDalEF), t => t.Name.StartsWith("Dal"));

            //  builder.RegisterAssemblyModules<RegisterAssemblyModules>();
        }));
    }
}
