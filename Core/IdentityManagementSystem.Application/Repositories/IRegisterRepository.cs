using IdentityManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityManagementSystem.Application.Repositories;

public interface IRegisterRepository
{
    Task<IdentityResult> CreateAsync(AppUser user, string password);
    Task<IdentityUser> FindUserByEmailAsync(string email);
    Task<SignInResult> PasswordSignInAsync(AppUser user, string password, bool isPersistent, bool lockoutOnFailure);
    Task<int> GetAccessFailedCountAsync(AppUser user);
    Task SignOutAsync();
}
