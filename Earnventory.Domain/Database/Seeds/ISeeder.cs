using Microsoft.Extensions.DependencyInjection;

namespace Earnventory.Domain.Database.Seeds
{
    public interface ISeeder
    {
        void Handle(IServiceScope scope);
    }
}