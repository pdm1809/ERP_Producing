using SampleProject.Data.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using SampleProject.Shared.Providers.Abstractions;
using SampleProject.Shared.Providers.Implements;
using SampleProject.Data.Repositories.Abstractions;
using SampleProject.Data.Repositories.Implements;

namespace SampleProject.Data
{
    public static class BootstrapperExtension
    {
        public static void RegisterRepositoryDepedencies(this IServiceCollection services)
        {
            services.AddScoped<ICoreProvider, CoreProvider>();
            services.AddScoped<IIdentityProvider, IdentityProvider>();
            services.AddScoped<IUnitOfWorkService, UnitOfWorkService>();
            services.AddScoped<IAAColumnAliasRepository, AAColumnAliasRepository>();
        }
    }
}
