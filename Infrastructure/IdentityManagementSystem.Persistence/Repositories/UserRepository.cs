using IdentityManagementSystem.Application.Repositories;
using IdentityManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityManagementSystem.Persistence.Repositories;

public class UserRepository(UserManager<AppUser> _userManager) : IUserRepository
{
    public async Task<List<AppUser>> GetListAsync()
    {
        var user = await _userManager.Users.ToListAsync();
        return user;
    }
}
