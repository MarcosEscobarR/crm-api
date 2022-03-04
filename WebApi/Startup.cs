using Core;
using Core.Interfaces;
using Infraestructure;
using Serilog;
using WebApi.Dependencies;
using WebApi.Helpers;
using WebApi.Logger;
using WebApi.Mapping;
using WebApi.Middlewares;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AgregarConfiguraciones(Configuration)
                .AgregarCore()
                .AgregarInfraestructura()
                .AgregarDocumentacionSwagger(typeof(Startup).Assembly.FullName)
                .AgregarVersionamientoApi(1, 0)
                .AddAutoMapper(typeof(SharedProfile))
                .AddControllers()
                .AgregarFluentValidation(services)
                .AgregarKeycloak()
                .AddTransient<IIdentityService, IdentityService>()
                .AddMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            app.UseMiddleware<CustomExceptionHandlerMiddleware>();
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSerilogRequestLogging(opts
                => opts.EnrichDiagnosticContext = LogRequestEnricher.EnrichFromRequest);

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseSwagger()
                .UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Continental API");
                });

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
