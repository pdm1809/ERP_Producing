using SampleProject.Shared.Constants;
using SampleProject.Shared.Exceptions;
using SampleProject.Shared.Responses;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net;

namespace SampleProject.Api.Extensions
{
    public static class ApplicationBuilderExtension
    {
        private static DefaultContractResolver _contractResolver = new DefaultContractResolver()
        {
            NamingStrategy = new CamelCaseNamingStrategy()
        };

        public static void ConfigGlobalException<TApplicationBuilder>(this TApplicationBuilder applicationBuilder) where TApplicationBuilder : IApplicationBuilder
        {
            applicationBuilder.UseExceptionHandler(config =>
            {
                config.Run(async handler =>
                {
                    if (((int)HttpStatusCode.InternalServerError).Equals(handler.Response.StatusCode))
                    {
                        handler.Response.ContentType = System.Net.Mime.MediaTypeNames.Application.Json;
                        var contextFeature = handler.Features.Get<IExceptionHandlerFeature>();
                        var httpStatusCode = (int)HttpStatusCode.BadRequest;
                        object response = null;

                        if (contextFeature.Error is DomainException domainException)
                        {
                            if (domainException is IResultException resultException)
                            {
                                response = new FailActionResponse<object>()
                                {
                                    Data = resultException.Result,
                                    ErrorCode = domainException.ErrorCode,
                                    SubErrorCode = domainException.SubErrorCode,
                                    SubErrorCodeString = domainException.SubErrorCodeString,
                                    ErrorMessage = domainException.Message
                                };
                            }
                            else
                            {
                                response = new FailActionResponse()
                                {
                                    ErrorCode = domainException.ErrorCode,
                                    SubErrorCode = domainException.SubErrorCode,
                                    SubErrorCodeString = domainException.SubErrorCodeString,
                                    ErrorMessage = domainException.Message
                                };
                            }
                        }
                        else if (contextFeature.Error is not null)
                        {
                            response = new FailActionResponse()
                            {
                                ErrorCode = ErrorCode.System,
                                ErrorMessage = contextFeature.Error.Message
                            };
                        }

                        if (response is not null)
                        {
                            handler.Response.StatusCode = httpStatusCode;
                            await handler.Response.WriteAsync(JsonConvert.SerializeObject(response, new JsonSerializerSettings()
                            {
                                Formatting = Formatting.None,
                                ContractResolver = _contractResolver
                            }));
                        }
                    }
                });
            });
        }
    }
}
