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

       // public static IHostBuilder CreateHostBuilder(string[] vArgs) => Host.CreateDefaultBuilder(vArgs).ConfigureWebHostDefaults(x => { x.UseStartup<Startup>(); });

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
            //.ConfigureLogging(logging =>
            //{
            //    logging.ClearProviders();
            //    logging.SetMinimumLevel(LogLevel.Debug);
            //})
            .UseSerilog((HostBuilderContext context, LoggerConfiguration loggerConfiguration) => {
                loggerConfiguration.ReadFrom.Configuration(context.Configuration.GetSection("Logging"));
            });


    }
}
