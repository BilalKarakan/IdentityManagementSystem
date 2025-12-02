using AutoMapper;
using IdentityManagementSystem.Application.DTOs;
using IdentityManagementSystem.Application.Repositories;
using IdentityManagementSystem.Application.Services;
using IdentityManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityManagementSystem.Persistence.Register.Services;

public class RegisterService(IRegisterRepository _repository, IMapper _mapper) : IRegisterService
{
    public async Task<IdentityResult> CreateAsync(SignUpDto signUpDto) => await _repository.CreateAsync(_mapper.Map<AppUser>(signUpDto), signUpDto.Password);
    public async Task<IdentityUser> FindUserByEmailAsync(string email) => await _repository.FindUserByEmailAsync(email);
    public async Task<SignInResult> PasswordSignInAsync(AppUser user, string password, bool isPersistent, bool lockoutOnFailure) => await _repository.PasswordSignInAsync(user, password, isPersistent, lockoutOnFailure);
}
