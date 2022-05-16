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
    public class ExpedienteController : Controller
    {
        public IConfiguration Configuration { get; }

        public ExpedienteController(IConfiguration vIConfiguration)
        {
            Configuration = vIConfiguration;
        }

        public async Task<IActionResult> Index()
        {
            //List<MaestraDTO> vMasters = await Services<MaestraDTO>.Listar("Eum/Listar");
            ListarExpedienteDTO vRecord = new ListarExpedienteDTO();
            vRecord.ListaExpediente = await Services<ExpedienteDTO>.Listar("Expediente/ListarPaginadoExpedienteDTO?vvNroExp=0&vFiltro=''&vNumPag=1&vCantRegxPag=1");
            return View(vRecord);
        }

        [HttpGet]
        public async Task<IActionResult> AgregarEditar(int vId = 0)
        {
            RegistrarExpedienteDTO vRecord = new RegistrarExpedienteDTO();

            vRecord = await Services<RegistrarExpedienteDTO>.Obtener("Expediente/GetFull?vId=" + vId);
            if (vId == 0)
                vRecord.Expediente = new ExpedienteDTO();

            //ViewBag.CboTipoOperacion = vRecord.CboTipoOperacion.ConvertAll(x =>
            //{
            //    return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Operacion.ToString() };
            //});

            return View(vRecord);
        }

    }
}
