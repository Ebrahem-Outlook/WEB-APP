using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WEB_APP.Infrastructure.Database;

namespace WEB_APP.Infrastructure;

public static class DependencyInjection 
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            string connection = configuration.GetConnectionString("Local-SqlServer") ?? throw new InvalidOperationException("ConnectionString does't Exsit....");

            options.UseSqlServer(connection);
        });

        return services;
    }
}
