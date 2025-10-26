using IdentityManagementSystem.Application.DTOs;

namespace IdentityManagementSystem.Application.Services;

public interface IUserService
{
    Task<List<UserListDto>> GetListAsync();
}
