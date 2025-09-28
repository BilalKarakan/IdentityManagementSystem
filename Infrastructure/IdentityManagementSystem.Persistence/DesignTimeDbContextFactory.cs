using IdentityManagementSystem.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace IdentityManagementSystem.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<IdentityManagementSystemDbContext>
{
    public IdentityManagementSystemDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<IdentityManagementSystemDbContext> optionsBuilder = new();
        optionsBuilder.UseNpgsql(Configuration.ConnectionString);
        return new(optionsBuilder.Options);
    }
}
