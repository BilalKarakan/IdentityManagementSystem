using IdentityManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityManagementSystem.Application.Repositories;

public interface IRegisterRepository
{
    Task<IdentityResult> CreateAsync(AppUser user);
}
