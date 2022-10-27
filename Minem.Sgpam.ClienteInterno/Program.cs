using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Minem.Sgpam.ClienteInterno
{
    public class Program
    {
        public static void Main(string[] vArgs)
        {
            CreateHostBuilder(vArgs).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] vArgs) => Host.CreateDefaultBuilder(vArgs)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); })
            .UseSerilog((HostBuilderContext context, LoggerConfiguration loggerConfiguration) => { loggerConfiguration.ReadFrom.Configuration(context.Configuration.GetSection("Logging")); });
    }
}
