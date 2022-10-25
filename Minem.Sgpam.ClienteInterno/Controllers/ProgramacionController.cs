using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Minem.Sgpam.ClienteInterno.Helpers;
using Minem.Sgpam.ClienteInterno.Models;
using Minem.Sgpam.InfraEstructura;
using Minem.Sgpam.InfraEstructura.Enumerados;
using Minem.Sgpam.InfraEstructura.Utilitarios;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Minem.Sgpam.ClienteInterno.Controllers
{
    [Authorize]
    public class ProgramacionController : Controller
    {
        private readonly ILogger<ProgramacionController> Logger;
        public IConfiguration Configuration { get; }

        public ProgramacionController(IConfiguration vIConfiguration, ILogger<ProgramacionController> vILogger)
        {
            Configuration = vIConfiguration;
            Logger = vILogger;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
