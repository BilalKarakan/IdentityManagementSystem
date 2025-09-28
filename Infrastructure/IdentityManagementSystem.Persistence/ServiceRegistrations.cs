using IdentityManagementSystem.Persistence.Context;
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
    }
}
