using System.Web.Http;

namespace Minem.Sgpam.WebApiLF
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "LF/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
