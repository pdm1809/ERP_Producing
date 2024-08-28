using SampleProject.Shared.Providers.Abstractions;
using System.Security.Claims;

namespace SampleProject.Shared.Providers.Implements
{
    public class IdentityProvider : IIdentityProvider
    {
        public IdentityInfo Identity { get; set; } = new IdentityInfo();

        public void UpdateIdentity(ClaimsPrincipal user)
        {
            if (user is null)
            {
                return;
            }
        }
    }
}