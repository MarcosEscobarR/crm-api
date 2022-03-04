using Microsoft.AspNetCore;
using Serilog;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger();

            try
            {
                var applicationName = config["Serilog:Properties:ApplicationName"];
                Log.Information($"Iniciando {applicationName}.");
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "La API fallo al iniciar.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog();
    }
}
