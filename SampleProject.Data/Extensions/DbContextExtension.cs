using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SampleProject.Data.Contexts;

namespace SampleProject.Data.Extensions
{
    public static class DbContextExtension
    {
        public static void RegisterDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<SampleDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
