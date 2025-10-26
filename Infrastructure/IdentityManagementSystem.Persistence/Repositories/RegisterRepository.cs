using IdentityManagementSystem.Application.Repositories;
using IdentityManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityManagementSystem.Persistence.Repositories;

public class RegisterRepository(UserManager<AppUser> _userManager) : IRegisterRepository
{
    public async Task<IdentityResult> CreateAsync(AppUser user)
    {
        var identityResult = await _userManager.CreateAsync(user);
        return identityResult;
    }
}
