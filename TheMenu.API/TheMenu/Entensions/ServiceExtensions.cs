using Microsoft.EntityFrameworkCore;
using TheMenu.Application.Services;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Domain.Interfaces.Services;
using TheMenu.Infrastructure.Context;
using TheMenu.Infrastructure.Repositories;

namespace TheMenu.Entensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<RepositoryContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();
    }
}
