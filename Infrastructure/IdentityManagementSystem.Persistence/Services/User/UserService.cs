using AutoMapper;
using IdentityManagementSystem.Application.DTOs;
using IdentityManagementSystem.Application.Repositories;
using IdentityManagementSystem.Application.Services;

namespace IdentityManagementSystem.Persistence.Services.User;

public class UserService(IUserRepository _repository, IMapper _mapper) : IUserService
{
    public async Task<List<UserListDto>> GetListAsync()
    {
        var dto = _mapper.Map<List<UserListDto>>(await _repository.GetListAsync());
        return dto;
    }
}
