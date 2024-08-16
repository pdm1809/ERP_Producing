using SampleProject.Shared.Settings;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Serilog;
using System.Runtime.CompilerServices;

namespace SampleProject.Shared.Providers.Abstractions
{
    public interface ICoreProvider
    {
        SampleProjectSetting Setting { get; set; }
        IMapper Mapper { get; set; }
        IIdentityProvider IdentityProvider { get; set; }
#if !DEBUG
        ILogger Logger { get; set; }
#endif

        void LogInformation(string message, object data = null, [CallerMemberName] string methodName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0);
    }
}
