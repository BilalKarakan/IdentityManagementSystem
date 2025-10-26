using FluentValidation;
using IdentityManagementSystem.Application.Repositories;
using IdentityManagementSystem.Application.Services;
using IdentityManagementSystem.Domain.Entities;
using IdentityManagementSystem.Persistence.Context;
using IdentityManagementSystem.Persistence.Register.Services;
using IdentityManagementSystem.Persistence.Repositories;
using IdentityManagementSystem.Persistence.Services.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityManagementSystem.Persistence;

public static class ServiceRegistrations
{
    public static void AddPersistenceServices(this IServiceCollection service)
    {
        service.AddDbContext<IdentityManagementSystemDbContext>(options =>
        {
            options.UseNpgsql(Configuration.ConnectionString, m => m.MigrationsAssembly("IdentityManagementSystem.Persistence"));
        });

        service.AddIdentity<AppUser, AppRole>(options =>
        {
            options.User.RequireUniqueEmail = true;
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireNonAlphanumeric = true;

        }).AddEntityFrameworkStores<IdentityManagementSystemDbContext>();

        service.AddAutoMapper(typeof(AssemblyReference).Assembly);
        service.AddValidatorsFromAssembly(typeof(AssemblyReference).Assembly);

        service.AddScoped<IRegisterService, RegisterService>();
        service.AddScoped<IRegisterRepository, RegisterRepository>();
        service.AddScoped<IUserRepository, UserRepository>();
        service.AddScoped<IUserService, UserService>();
    }
}
