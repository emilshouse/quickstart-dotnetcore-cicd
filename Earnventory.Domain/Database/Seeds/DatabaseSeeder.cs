using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace Earnventory.Domain.Database.Seeds
{
    public class DatabaseSeeder
    {
        private IEnumerable<ISeeder> Seeds { get; }
        private readonly IServiceScope _scope;
        public DatabaseSeeder(IServiceScope scope)
        {
            _scope = scope;
            Seeds = new List<ISeeder>
            {
                
            };
        }

        public void SeedData()
        {
            foreach (var seeder in Seeds)
            {
                seeder.Handle(_scope);
            }
        }
    }
}