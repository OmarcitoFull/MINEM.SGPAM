using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Minem.Sgpam.WebApi
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
            vServices.AddControllers();
            vServices.Inyecciones();
            vServices.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = Constantes.ApiTitulo, Version = Constantes.ApiVersion });
            });
        }

        public void Configure(IApplicationBuilder vApp, IWebHostEnvironment vEnvironment)
        {
            if (vEnvironment.IsDevelopment())
            {
                vApp.UseDeveloperExceptionPage();
                vApp.UseSwagger();
                vApp.UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json", Constantes.ApiSeleccion));
            }

            vApp.UseRouting();

            vApp.UseAuthorization();

            vApp.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
