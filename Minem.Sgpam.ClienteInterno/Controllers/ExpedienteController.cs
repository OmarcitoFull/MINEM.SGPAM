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


        public async Task<IActionResult> Index(string vNroExp = "", string vZona = "", string vUbigeo = "0")
        {
            ListarExpedienteDTO vRecord = new ListarExpedienteDTO();
            vRecord.ListaExpediente = await Services<ExpedienteDTO>.Listar("Expediente/ListarPaginadoExpedienteDTO?vNroExp=" + vNroExp + "&vZona=" + vZona + "&vUbigeo=" + vUbigeo + "&vNumPag=" + 1 + "&vCantRegxPag=" + 10);
            vRecord.ListaUbigeo = await Services<Ubigeo_IneiDTO>.Listar("Ubigeo/List_Ubigeo_Inei");
            ViewBag.Ubigeo = vRecord.ListaUbigeo;
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

        [HttpPost]
        public async Task<IActionResult> AgregarEditar(ExpedienteDTO vModel)
        {
            vModel.Fec_Ingreso = vModel.Fec_Modifica = DateTime.Now;
            vModel.Usu_Ingreso = vModel.Usu_Modifica = Constantes.GuestUser;
            vModel.Ip_Ingreso = vModel.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vModel = await Services<ExpedienteDTO>.Grabar("Expediente/Save", vModel);
                return Ok(new ComponentResultModel(vModel?.Id_Expediente ?? 0));
            }
            return View(vModel);
        }



    }
}
