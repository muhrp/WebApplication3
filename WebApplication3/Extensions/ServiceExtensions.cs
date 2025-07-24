using Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<RepositoryContext>(option => option.UseSqlServer(config.GetConnectionString("default")));
        }
    }
}
