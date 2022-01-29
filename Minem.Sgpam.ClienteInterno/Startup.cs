using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Minem.Sgpam.InfraEstructura;
using System;

namespace Minem.Sgpam.ClienteInterno
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration vIConfiguration)
        {
            Configuration = vIConfiguration;
        }

        public void ConfigureServices(IServiceCollection vServices)
        {
            Environment.SetEnvironmentVariable(Constantes.ServiceRoute, Configuration.GetValue<string>("BackEndConfig:UrlApi"));
            vServices.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder vApp, IWebHostEnvironment vEnvironment)
        {
            if (vEnvironment.IsDevelopment())
            {
                vApp.UseDeveloperExceptionPage();
            }
            else
            {
                vApp.UseExceptionHandler("/Home/Error");
            }
            vApp.UseStaticFiles();
            vApp.UseRouting();
            vApp.UseAuthorization();
            vApp.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
