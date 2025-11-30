using AutoMapper;
using IdentityManagementSystem.Application.DTOs;
using IdentityManagementSystem.Application.Repositories;
using IdentityManagementSystem.Application.Services;
using IdentityManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityManagementSystem.Persistence.Register.Services;

public class RegisterService(IRegisterRepository _repository, IMapper _mapper) : IRegisterService
{
    public async Task<IdentityResult> CreateAsync(SignUpDto signUpDto)
    {
        var identityResult = await _repository.CreateAsync(_mapper.Map<AppUser>(signUpDto), signUpDto.Password);
        return identityResult;
    }
}
