using Microsoft.Extensions.Configuration;

namespace IdentityManagementSystem.Persistence;

static class Configuration
{
    public static string ConnectionString 
    {
        get
        {
            ConfigurationManager manager = new();
            manager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/IdentityManagementSystem.Web")).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return manager.GetConnectionString("PostgreSql");
        }
    }
}
