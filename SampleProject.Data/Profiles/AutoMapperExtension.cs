using Microsoft.Extensions.DependencyInjection;

namespace SampleProject.Data.Profiles
{
    public static class AutoMapperExtension
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperExtension).Assembly);
        }
    }
}
