using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Earnventory.Domain.Context;
using Earnventory.Domain.Dtos;
using Earnventory.Domain.Entities;
using Earnventory.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Earnventory.Services.Repository
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        private readonly IMapper _mapper;
        public UserRepository(ApplicationDbContext ctx,IMapper mapper) : base(ctx)
        {
            _mapper = mapper;
        }

        public async Task<UserDto> GetUser(Guid id)
        {
            var user = await Context.Users.SingleOrDefaultAsync(item => item.Id == id);
            return _mapper.Map<UserDto>(user);
        }
    }
}