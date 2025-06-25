using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SchoolProject.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection service)


        {
            service.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return service;
        }
    }
}
