using Earnventory.Services.IRepository;
using Earnventory.Services.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Earnventory.Services.Utils
{
    public static class RepoUtils
    {
        public static void RegisterAppRepoServices(this IServiceCollection services)
        {
            services.RegisterScopedServices();
        }

        private static void RegisterScopedServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            services.AddScoped<IAuthRepository,AuthRepository>();
            services.AddScoped<IUserRepository,UserRepository>();
        }
    }
}