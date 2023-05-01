using Autofac;
using System.Reflection;
using Module = Autofac.Module;

namespace CarRentalComposition.Autofac.RegisterAssemblyModules;

internal class RegisterAssemblyModules : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        var assembly = Assembly.GetExecutingAssembly();

        builder.RegisterAssemblyModules(assembly).IfNotRegistered(typeof(RegisterAssemblyModules));
    }
}
