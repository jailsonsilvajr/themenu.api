using Microsoft.EntityFrameworkCore;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Infrastructure.Context;
using TheMenu.Infrastructure.Repositories;

namespace TheMenu.API.Entensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<RepositoryContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
    }
}
