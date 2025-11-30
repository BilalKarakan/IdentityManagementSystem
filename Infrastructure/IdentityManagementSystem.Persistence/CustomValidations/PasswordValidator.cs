using IdentityManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityManagementSystem.Persistence.CustomValidations;

public class PasswordValidator : IPasswordValidator<AppUser>
{
    public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string? password)
    {
        var errors = new List<IdentityError>();

        if (password!.ToLower().StartsWith("123") || password!.ToLower().EndsWith("789"))
            errors.Add(new IdentityError { Code = "PasswordNoSquential", Description = "Şifre ardışık sayı içeremez" });

        if (errors.Count != 0)
            return Task.FromResult(IdentityResult.Failed(errors.ToArray()));

        return Task.FromResult(IdentityResult.Success);
    }
}
