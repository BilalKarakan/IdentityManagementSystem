using Microsoft.AspNetCore.Identity;

namespace IdentityManagementSystem.Persistence.Localizations;

public class LocalicationIdentityErrorDescriber : IdentityErrorDescriber
{
    public override IdentityError DuplicateEmail(string email) => new() { Code = nameof(DuplicateEmail), Description = "Bu e-posta adresi zaten kullanılıyor." };
    public override IdentityError DuplicateUserName(string userName) => new() { Code = nameof(DuplicateUserName), Description = $"{userName} kullanıcı adı zaten kullanılıyor." };
    public override IdentityError PasswordRequiresDigit() => new() { Code = nameof(PasswordRequiresDigit), Description = "Şifre en az bir rakam içermelidir (0-9)." };
    public override IdentityError PasswordTooShort(int length) => new() { Code = nameof(PasswordTooShort), Description = $"Şifre en az {length} karakter uzunluğunda olmalıdır." };
    public override IdentityError PasswordRequiresUpper() => new() { Code = nameof(PasswordRequiresUpper), Description = "Şifre en az bir büyük harf içermelidir (A-Z)." };
    public override IdentityError PasswordRequiresLower() => new() { Code = nameof(PasswordRequiresLower), Description = "Şifre en az bir küçük harf içermelidir (a-z)." };
    public override IdentityError PasswordRequiresNonAlphanumeric() => new() { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "Şifre en az bir alfanümerik olmayan karakter içermelidir (örneğin: !, @, #, $)." };
}
