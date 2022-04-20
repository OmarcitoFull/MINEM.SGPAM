using System.Web.Configuration;
using System.Web.Http;

namespace Minem.Sgpam.WebApiLF.Controllers
{
    public class BaseController : ApiController
    {
        public string Servidor { get; } = WebConfigurationManager.AppSettings["IPServerLF"].ToString();
        public string Usuario { get; } = WebConfigurationManager.AppSettings["UserLF"].ToString();
        public string Contrasenia { get; } = WebConfigurationManager.AppSettings["PasswordLF"].ToString();
        public string Repositorio { get; } = WebConfigurationManager.AppSettings["RepositoryLF"].ToString();
        public string CarpetaBase { get; } = WebConfigurationManager.AppSettings["BaseDirectoryLF"].ToString();
    }
}