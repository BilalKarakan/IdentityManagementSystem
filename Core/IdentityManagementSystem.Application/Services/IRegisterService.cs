using IdentityManagementSystem.Application.DTOs;
using IdentityManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityManagementSystem.Application.Services;

public interface IRegisterService
{
    Task<IdentityResult> CreateAsync(SignUpDto signUpDto);
    Task<IdentityUser> FindUserByEmailAsync(string email);
    Task<SignInResult> PasswordSignInAsync(AppUser user, string password, bool isPersistent, bool lockoutOnFailure);
    Task<int> GetAccessFailedCountAsync(AppUser user);
    Task SignOutAsync();
}
