using Microsoft.AspNetCore.Mvc;

namespace WebApi.Dependencies
{
    public static class ApiVersioningDependencyInjection
    {
        public static IServiceCollection AgregarVersionamientoApi(
            this IServiceCollection services,
            int majorVersion,
            int minorVersion)
        {
            return services.AddApiVersioning(c =>
            {
                c.DefaultApiVersion                   = new ApiVersion(majorVersion, minorVersion);
                c.AssumeDefaultVersionWhenUnspecified = true;
                c.ReportApiVersions                   = true;
            });
        }
    }
}
