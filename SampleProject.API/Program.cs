using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using SampleProject.Api.Extensions;
using SampleProject.Api.Middlewares;
using SampleProject.Api.Swaggers;
using SampleProject.Business;
using SampleProject.Data;
using SampleProject.Data.Extensions;
using SampleProject.Data.Profiles;
using SampleProject.Service;
using SampleProject.Shared.Constants;
using SampleProject.Shared.Responses;
using SampleProject.Shared.Settings;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
#if !DEBUG
builder.Host.UseSerilog((context, config) =>
{
    config.ReadFrom.Configuration(new ConfigurationBuilder()
        .AddJsonFile("appsettings.json").Build());
});
#endif
var configSection = builder.Configuration.GetSection("SampleProject");
var setting = configSection.Get<SampleProjectSetting>();
SampleProjectSetting.Instance = setting;
builder.Services.AddSingleton(setting);
builder.Services.AddMvc(option => option.EnableEndpointRouting = false).AddControllersAsServices();
builder.Services.Configure<ApiBehaviorOptions>(option =>
{
    option.InvalidModelStateResponseFactory = actionContext => new BadRequestObjectResult(new FailActionResponse()
    {
        ErrorCode = ErrorCode.InvalidInput,
        ErrorMessage = actionContext.ModelState.Values.FirstOrDefault().Errors.FirstOrDefault().ErrorMessage
    });
});
builder.Services.RegisterDbContext(builder.Configuration);
builder.Services.RegisterAutoMapper();
builder.Services.RegisterRepositoryDepedencies();
builder.Services.RegisterServiceDependencies();
builder.Services.RegisterBusinessDependencies();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "SampleProject APIs"
    });
    c.OperationFilter<GlobalHeader>();
});
var app = builder.Build();
app.ConfigGlobalException();
app.UseMiddleware<HttpInjectMiddleware>();
app.UseCors(builder => builder
  .AllowAnyOrigin()
  .AllowAnyMethod()
  .AllowAnyHeader());
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseMvcWithDefaultRoute();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.UseSwagger(c =>
{
    c.SerializeAsV2 = true;
});
app.UseSwaggerUI(c =>
{
    var assembly = Assembly.GetEntryAssembly();
    var version = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version;
    var date = File.GetLastWriteTimeUtc(assembly.Location);
    c.SwaggerEndpoint("./v1/swagger.json", $"API - Version: {version} - Date: {date}");
});
app.Run();
