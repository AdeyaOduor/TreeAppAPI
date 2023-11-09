using AutoMapper;
using TreeAppAPIv1.Dtos;
using TreeAppAPIv1.Entities;
using static TreeAppAPIv1.Dtos.DTOs;

namespace TreeAppAPIv1.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<APILogin, APILoginDto>().ReverseMap();
            CreateMap<region, regionDto>().ReverseMap();
        }
    }
}
