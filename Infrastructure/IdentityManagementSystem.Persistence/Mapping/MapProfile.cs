using AutoMapper;
using IdentityManagementSystem.Application.DTOs;
using IdentityManagementSystem.Domain.Entities;

namespace IdentityManagementSystem.Persistence.Mapping;

public class MapProfile : Profile
{
	public MapProfile()
	{
		CreateMap<SignUpDto, AppUser>().ReverseMap();
    }
}
