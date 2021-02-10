using AutoMapper;
using Earnventory.Domain.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace Earnventory.Domain.Utils
{
    public static class DemoUtils
    {
        public static void RegisterDomainServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(EarnventoryApiMapper));
        }
    }
}