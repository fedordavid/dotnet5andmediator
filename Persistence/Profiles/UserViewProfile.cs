using AutoMapper;
using Persistence.Users;

namespace Persistence.Profiles
{
    public class UserViewProfile : Profile
    {
        public UserViewProfile()
        {
            CreateMap<UserEntity, UserView>();
        }
    }
}