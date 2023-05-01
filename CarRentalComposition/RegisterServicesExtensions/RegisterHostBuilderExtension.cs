using Microsoft.Extensions.Hosting;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using CarRentalComposition.Autofac.RegisterAssemblyModules;

namespace CarRentalComposition.RegisterServicesExtensions;

public static class RegisterHostBuilderExtension
{
    public static void RegisterHostBuilder(this IHostBuilder hostBuilder)
    {
        hostBuilder.UseServiceProviderFactory(new AutofacServiceProviderFactory(builder =>
        {
            builder.RegisterAssemblyModules<RegisterAssemblyModules>();
        }));
    }
}
