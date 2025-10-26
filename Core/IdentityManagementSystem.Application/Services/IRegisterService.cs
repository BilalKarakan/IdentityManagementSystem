using IdentityManagementSystem.Application.DTOs;
using Microsoft.AspNetCore.Identity;

namespace IdentityManagementSystem.Application.Services;

public interface IRegisterService
{
    Task<IdentityResult> CreateAsync(SignUpDto signUpDto);
}
