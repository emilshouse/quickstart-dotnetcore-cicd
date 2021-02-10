using System;
using System.Threading.Tasks;
using Earnventory.Domain.Dtos;

namespace Earnventory.Services.IRepository
{
    public interface IUserRepository
    {
        public Task<UserDto> GetUser(Guid id);

    }
}