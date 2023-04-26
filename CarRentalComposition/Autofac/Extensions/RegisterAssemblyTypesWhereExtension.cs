using Autofac;
using System.Reflection;

namespace CarRentalComposition.Autofac.Extensions;

internal static class RegisterAssemblyTypesWhereExtension
{
    public static void RegisterAssemblyTypesWhere(this ContainerBuilder builder,
        string assemblyName, Func<Type, bool> filter)
    {
        var assembly = Assembly.Load(assemblyName);

        builder.RegisterAssemblyTypes(assembly).Where(filter).AsImplementedInterfaces();
    }
}
