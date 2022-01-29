using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Minem.Sgpam.WebApi
{
    public class Program
    {
        public static void Main(string[] vArgs)
        {
            CreateHostBuilder(vArgs).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] vArgs) => Host.CreateDefaultBuilder(vArgs).ConfigureWebHostDefaults(x => { x.UseStartup<Startup>(); });
    }
}
