using IdentityManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityManagementSystem.Persistence.Context;

public class IdentityManagementSystemDbContext : IdentityDbContext<AppUser, AppRole, string>
{
    public IdentityManagementSystemDbContext(DbContextOptions<IdentityManagementSystemDbContext> options) : base(options)
    {
            
    }
}
