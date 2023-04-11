using AutoMapper;
using Domain;
using Repository;

namespace WebApp
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
