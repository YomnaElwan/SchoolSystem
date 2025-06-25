using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SchoolProject.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection service)


        {

            //Configuration for MediatR
            service.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //Configuration for AutoMapper
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
            return service;
        }
    }
}
