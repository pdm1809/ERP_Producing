using SampleProject.Shared.Providers.Implements;
using System.Security.Claims;

namespace SampleProject.Shared.Providers.Abstractions
{
    public interface IIdentityProvider
    {
        IdentityInfo Identity { get; set; }
        void UpdateIdentity(ClaimsPrincipal user);
    }
}
