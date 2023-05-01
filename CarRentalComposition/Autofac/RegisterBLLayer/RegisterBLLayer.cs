
using Autofac;
using CarRentalComposition.Autofac.Extensions;

namespace CarRentalComposition.Autofac.RegisterBLLayer;

internal class RegisterBLLayer :Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterAssemblyTypesWhere(nameof(CarRentalBL), t => t.Name.EndsWith("Service") && t.IsClass);
    }

}
