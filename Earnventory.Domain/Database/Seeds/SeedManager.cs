using System;
using Earnventory.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Earnventory.Domain.Database.Seeds
{
    public static class SeedManager
    {
        public static IHost SeedData(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            try
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                context.Database.Migrate();
            }
            catch (Exception)
            {
                // ignored
            }

            try
            {
                var databaseSeeder = new DatabaseSeeder(scope);
                databaseSeeder.SeedData();
            }
            catch (Exception)
            {
                // ignored
            }

            return host;
        } 
    }
}