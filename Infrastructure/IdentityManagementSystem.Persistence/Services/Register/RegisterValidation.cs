using FluentValidation;
using IdentityManagementSystem.Application.DTOs;

namespace IdentityManagementSystem.Persistence.Register.Services;

public class RegisterValidation : AbstractValidator<SignUpDto>
{
	public RegisterValidation()
	{
		RuleFor(x => x.UserName).NotNull().WithMessage("Username is required")
			.NotEmpty().WithMessage("Username must not be empty")
            .MinimumLength(3).WithMessage("Username must be at least 3 characters long")
			.MaximumLength(30).WithMessage("Username must not exceed 20 characters");

		RuleFor(x => x.Email).NotNull().WithMessage("Email is required")
			.NotEmpty().WithMessage("Email must not be empty")
			.EmailAddress().WithMessage("Invalid email format");

		RuleFor(x => x.PhoneNumber).NotNull().WithMessage("Phone number is required")
			.NotEmpty().WithMessage("Phone number must not be empty")
			.Matches("^[0-9]+$").WithMessage("Phone number must contain only digits");

		RuleFor(x => x.Password).NotNull().WithMessage("Password is required")
			.NotEmpty().WithMessage("Password must not be empty")
			.MinimumLength(6).WithMessage("Password must be at least 6 characters long")
			.MaximumLength(30).WithMessage("Password must not exceed 20 characters");

		RuleFor(x => x.ConfirmPassword).NotNull().WithMessage("Confirm Password is required")
			.NotEmpty().WithMessage("Confirm Password must not be empty")
			.MinimumLength(6).WithMessage("Confirm Password must be at least 6 characters long")
			.MaximumLength(30).WithMessage("Confirm Password must not exceed 20 characters")
            .Equal(x => x.Password).WithMessage("Passwords do not match");
    }
}
