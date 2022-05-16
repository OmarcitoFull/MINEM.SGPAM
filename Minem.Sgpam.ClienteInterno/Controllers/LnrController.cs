using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
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
    public class LnrController : Controller
    {
        public IConfiguration Configuration { get; }

        public LnrController(IConfiguration vIConfiguration)
        {
            Configuration = vIConfiguration;
        }


        public IActionResult Index()
        {



            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AgregarEditar(int vId = 0)
        {
            RegistrarLnrDTO vRecord = new RegistrarLnrDTO();

            vRecord = await Services<RegistrarLnrDTO>.Obtener("Lnr/GetFull?vId=" + vId);
            if (vId == 0)
                vRecord.Lnr = new LnrDTO();

            ViewBag.CboTipoLnr = vRecord.CboTipoLnr.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Lnr.ToString() };
            });
            ViewBag.CboSubTipoLnr = vRecord.CboSubTipoLnr.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Sub_Tipo_Lnr.ToString() };
            });
            ViewBag.CboTemporalidad = vRecord.CboTemporalidad.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Temporalidad.ToString() };
            });

            return View(vRecord);
        }

    }
}
