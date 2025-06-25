using Microsoft.EntityFrameworkCore.ValueGeneration;
using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.Repositories;

namespace SchoolProject.Infrastructure
{
    
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services) {
            return services.AddScoped<IStudentRepository, StudentRepository>();
        }




    }
}
