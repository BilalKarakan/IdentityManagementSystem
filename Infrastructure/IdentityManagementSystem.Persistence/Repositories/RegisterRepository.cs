using IdentityManagementSystem.Application.Repositories;
using IdentityManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityManagementSystem.Persistence.Repositories;

public class RegisterRepository(UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager) : IRegisterRepository
{
    public async Task<IdentityResult> CreateAsync(AppUser user, string password) => await _userManager.CreateAsync(user, password);
    public async Task<IdentityUser> FindUserByEmailAsync(string email) => await _userManager.FindByEmailAsync(email);
    public async Task<SignInResult> PasswordSignInAsync(AppUser user, string password, bool isPersistent, bool lockoutOnFailure) => await _signInManager.PasswordSignInAsync(user, password, isPersistent, lockoutOnFailure);
}
