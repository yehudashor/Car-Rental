using Autofac;
using CarRentalComposition.Autofac.Extensions;
using System.Reflection;
using Module = Autofac.Module;

namespace CarRentalComposition.Autofac.RegisterDalLayer;

internal class RegisterDalLayer : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterAssemblyTypesWhere(nameof(CarRentalDalEF), t => t.Name.StartsWith("Dal"));
    }
}
