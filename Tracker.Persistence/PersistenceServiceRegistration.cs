using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tracker.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceService(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<TrackerDbContext>(builder =>
        {
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        
        return services;
    }
}