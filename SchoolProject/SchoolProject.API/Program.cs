
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using SchoolProject.Core;
using SchoolProject.Infrastructure;
using SchoolProject.Infrastructure.Data;
using SchoolProject.Service;

namespace SchoolProject.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            //Connect to the database 

            builder.Services.AddDbContext<ApplicationDBContext>(option => {
                option.UseSqlServer(builder.Configuration.GetConnectionString("dbcontext"));
            });
            #region Dependency Injection
            builder.Services.AddInfrastructureDependencies().AddServiceDependencies().AddCoreDependencies();
            #endregion
            builder.Services.AddSwaggerGen(swagger =>
            {
                //This is to generate the Default UI of Swagger Documentation    
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "ASP.NET 9 Web API",
                    Description = " School System Project"
                });
            });


                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.MapOpenApi();
                    app.UseSwagger();
                    app.UseSwaggerUI();

                }

                app.UseHttpsRedirection();


                app.UseAuthorization();


                app.MapControllers();

                app.Run();
            }
    }
    }
