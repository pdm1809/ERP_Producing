using SampleProject.Shared.Providers.Abstractions;

namespace SampleProject.Api.Middlewares
{
    public class HttpInjectMiddleware
    {
        private readonly RequestDelegate _next;

        public HttpInjectMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext,
#if !DEBUG
            Serilog.ILogger logger,
#endif
            IIdentityProvider identityProvider)
        {
            await _next?.Invoke(httpContext);
        }
    }
}
