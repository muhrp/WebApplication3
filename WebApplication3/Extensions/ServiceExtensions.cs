using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepositories;
using Repositories.Repositories;
using WebApplication3.Services;

namespace WebApplication3.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<RepositoryContext>(option => option.UseSqlServer(config.GetConnectionString("default")));
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IHonorRepository, HonorRepository>();

            services.AddScoped<HonorService>();
        }
    }
}
