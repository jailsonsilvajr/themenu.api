using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Infrastructure.Repositories;

namespace TheMenu.API.Entensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
