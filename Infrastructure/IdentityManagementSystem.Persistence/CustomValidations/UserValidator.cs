using IdentityManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityManagementSystem.Persistence.CustomValidations;

public class UserValidator : IUserValidator<AppUser>
{
    public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
    {
        var errors = new List<IdentityError>();
        var isDigit = int.TryParse(user.UserName[0]!.ToString(), out _);
        if (isDigit)
            errors.Add(new IdentityError { Code = "FirstLetterIsNotDigit", Description = "Kullanıcı adı rakam ile başlayamaz" });

        if (errors.Count != 0)
            return Task.FromResult(IdentityResult.Failed(errors.ToArray()));

        return Task.FromResult(IdentityResult.Success);
    }
}
