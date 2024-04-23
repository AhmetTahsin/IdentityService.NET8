using AutoMapper;
using IdentityService.DTOs;
using IdentityService.Models.Entities;

namespace IdentityService.Mapper
{
    public class IdentityMapper:Profile
    {
        public IdentityMapper()
        {
            CreateMap<RegisterDTO, AppUser>()
                .ForMember(dest => dest.UserName, act => act.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email)).ReverseMap();
                



        }

    }
}
