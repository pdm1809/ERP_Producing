using Microsoft.Extensions.DependencyInjection;
using SampleProject.Service.Abstractions;
using SampleProject.Service.Implements;

namespace SampleProject.Service
{
    public static class BootstrapperExtension
    {
        public static void RegisterServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAAColumnAliasService, AAColumnAliasService>();
        }
    }
}
