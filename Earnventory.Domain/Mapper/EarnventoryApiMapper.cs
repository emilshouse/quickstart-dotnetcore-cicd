using Earnventory.Domain.Dtos;
using Earnventory.Domain.Entities;

namespace Earnventory.Domain.Mapper
{
    public class EarnventoryApiMapper: AutoMapper.Profile
    {
        public EarnventoryApiMapper()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}