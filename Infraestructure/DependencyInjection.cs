using System.Reflection;
using Core.Interfaces.Repositories;
using Infraestructure.Data;
using Infraestructure.Helpers;
using Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AgregarInfraestructura(this IServiceCollection services)
        {
            services.AddTransient<ICasesRepository, CasesRepository>();
            services.AddTransient<ApplicationDbContextAccessor>();
            // Descomentar para usar Entity Framework Core
            var config = services.BuildServiceProvider().GetService<IConfiguration>();
            var migrationsAssembly = typeof(DependencyInjection).GetTypeInfo().Assembly.GetName().Name;

            services.AddDbContext<ApplicationDbContext>(builder => builder.UseNpgsql(
                config.GetConnectionString("Default")!,
                optionsBuilder => optionsBuilder.MigrationsAssembly(migrationsAssembly))
            );

            return services;
        }
    }
}