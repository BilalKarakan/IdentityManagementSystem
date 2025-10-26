using IdentityManagementSystem.Domain.Entities;

namespace IdentityManagementSystem.Application.Repositories;

public interface IUserRepository
{
    Task<List<AppUser>> GetListAsync();
}
