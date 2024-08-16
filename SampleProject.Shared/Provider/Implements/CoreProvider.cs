using SampleProject.Shared.Providers.Abstractions;
using SampleProject.Shared.Settings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Serilog;
using SampleProject.Shared.Extensions;
using System.IO;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace SampleProject.Shared.Providers.Implements
{
    public class CoreProvider : ICoreProvider
    {
        public IIdentityProvider IdentityProvider { get; set; }
        public SampleProjectSetting Setting { get; set; }
        public IMapper Mapper { get; set; }
#if !DEBUG
        public ILogger Logger { get; set; }
#endif

        public CoreProvider(IIdentityProvider identityProvider,
            SampleProjectSetting setting,
#if !DEBUG
            ILogger logger,
#endif
            IMapper mapper)
        {
            Setting = setting;
            Mapper = mapper;
            IdentityProvider = identityProvider;
#if !DEBUG
            Logger = logger;
#endif
        }

        public void LogInformation(string message, object data = null, [CallerMemberName] string methodName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            var logInfo = new List<string>()
            {
                $"file: {Path.GetFileNameWithoutExtension(filePath)}",
                $"method: {methodName}",
                $"line: {lineNumber}",
                $"message: {message}"
            };

            if (data is not null)
            {
#if !DEBUG
                logInfo.Add("data: {data}");
#else
                logInfo.Add($"data: {data.TrySerializeObject()}");
#endif
            }

            var logMessage = string.Join(", ", logInfo);
#if !DEBUG
            Logger.Information(logMessage, data?.TrySerializeObject());
#else
            Debug.WriteLine(logMessage);
#endif
        }
    }
}
