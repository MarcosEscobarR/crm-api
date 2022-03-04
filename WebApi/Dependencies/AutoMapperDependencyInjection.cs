using WebApi.Mapping;

namespace WebApi.Dependencies
{
    public static class AutoMapperDependencyInjection
    {
        public static IServiceCollection AgregarAutoMapper(this IServiceCollection services)
        {
            return services.AddAutoMapper(typeof(SharedProfile));
        }
    }
}
