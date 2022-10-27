using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Minem.Sgpam.InfraEstructura;
using System;
using System.Globalization;

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
            Environment.SetEnvironmentVariable(Constantes.ServiceRouteLF, Configuration.GetValue<string>("BackEndConfig:UrlApiLF"));
            Environment.SetEnvironmentVariable(Constantes.ServiceRoute, Configuration.GetValue<string>("BackEndConfig:UrlApi"));
            Environment.SetEnvironmentVariable(Constantes.KeyApp, Configuration.GetValue<string>("BackEndConfig:KeyApp"));
            Environment.SetEnvironmentVariable(Constantes.IntranetWeb, Configuration.GetValue<string>("BackEndConfig:IntranetWeb"));
            vServices.Configure<RequestLocalizationOptions>(vOption => {
                vOption.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en");
                vOption.SupportedCultures = vOption.SupportedUICultures = new[] { new CultureInfo("en"), new CultureInfo("pe") };
            });

            vServices.AddAuthentication(x =>
            {
                x.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                x.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(x => { x.LoginPath = "/Intro"; });

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
            //vApp.UseDeveloperExceptionPage();
            vApp.UseStaticFiles();
            vApp.UseRouting();
            vApp.UseAuthentication();
            vApp.UseAuthorization();
            vApp.UseRequestLocalization(vApp.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>().Value);
            vApp.UseEndpoints(ep => { ep.MapControllerRoute(name: "default", pattern: "{controller=Intro}/{action=Index}/{id?}"); });
        }
    }
}
