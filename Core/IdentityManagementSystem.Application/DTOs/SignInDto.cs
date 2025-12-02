using System.ComponentModel.DataAnnotations;

namespace IdentityManagementSystem.Application.DTOs;

public class SignInDto
{
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public bool RememberMe { get; set; }
}
