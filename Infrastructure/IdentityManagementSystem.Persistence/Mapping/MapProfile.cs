using AutoMapper;
using IdentityManagementSystem.Application.DTOs;
using IdentityManagementSystem.Domain.Entities;

namespace IdentityManagementSystem.Persistence.Mapping;

public class MapProfile : Profile
{
	public MapProfile()
	{
		CreateMap<SignUpDto, AppUser>().ReverseMap();
        //CreateMap<List<AppUser>, List<UserListDto>>().ReverseMap();
        CreateMap<AppUser, UserListDto>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
        CreateMap<AppUser, UserListDto>().ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName));
        CreateMap<AppUser, UserListDto>().ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
        CreateMap<AppUser, UserListDto>().ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber));

    }
}
