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
    public class ReporteController : Controller
    {
        private readonly ILogger<ReporteController> Logger;
        public IConfiguration Configuration { get; }

        public ReporteController(IConfiguration vIConfiguration, ILogger<ReporteController> vILogger)
        {
            Configuration = vIConfiguration;
            Logger = vILogger;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> InventarioPAM(int vId = 0)
        {
            try
            {
                ListarEumDTO vRecord = new ListarEumDTO();
                //vRecord = await Services<MaestraDTO>.Obtener("Reporte/GetFull?vId=" + vId);
                vRecord.ListaUbigeo = await Services<Ubigeo_IneiDTO>.Listar("Ubigeo/List_Ubigeo_Inei");                
                ViewBag.Ubigeo = vRecord.ListaUbigeo;
                //if (vId == 0)
                //    vRecord.Eum = new MaestraDTO();

                //ViewBag.CboTipoPam = vRecord.CboTipoPam.ConvertAll(x =>
                //{
                //    return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Pam.ToString() };
                //});

                return View(vRecord);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> InventarioLNR(int vId = 0)
        {
            try
            {
                ListarExpedienteDTO vRecord = new ListarExpedienteDTO();
                vRecord.ListaUbigeo = await Services<Ubigeo_IneiDTO>.Listar("Ubigeo/List_Ubigeo_Inei");
                ViewBag.Ubigeo = vRecord.ListaUbigeo;

                //vRecord = await Services<ExpedienteDTO>.Obtener("Reporte/GetFull?vId=" + vId);
                //if (vId == 0)
                //    vRecord.Eum = new MaestraDTO();

                //ViewBag.CboTipoPam = vRecord.CboTipoPam.ConvertAll(x =>
                //{
                //    return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Pam.ToString() };
                //});

                return View(vRecord);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }


    }
}
