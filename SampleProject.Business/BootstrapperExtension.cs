using Microsoft.Extensions.DependencyInjection;
using SampleProject.Business.Abstractions;
using SampleProject.Business.Implements;

namespace SampleProject.Business
{
    public static class BootstrapperExtension
    {
        public static void RegisterBusinessDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAAColumnAliasBusiness, AAColumnAliasBusiness>();
        }
    }
}
