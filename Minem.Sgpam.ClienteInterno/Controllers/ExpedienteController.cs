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
    public class ExpedienteController : Controller
    {
        private readonly ILogger<ExpedienteController> Logger;
        public IConfiguration Configuration { get; }

        public ExpedienteController(IConfiguration vIConfiguration, ILogger<ExpedienteController> vILogger)
        {
            Configuration = vIConfiguration;
            Logger = vILogger;
        }


        public async Task<IActionResult> Index(string vNroExp = "", string vZona = "", string vUbigeo = "0")
        {
            try
            {
                ListarExpedienteDTO vRecord = new ListarExpedienteDTO();
                vRecord.ListaExpediente = await Services<ExpedienteDTO>.Listar("Expediente/ListarPaginadoExpedienteDTO?vNroExp=" + vNroExp + "&vZona=" + vZona + "&vUbigeo=" + vUbigeo + "&vNumPag=" + 1 + "&vCantRegxPag=" + 10);
                vRecord.ListaUbigeo = await Services<Ubigeo_IneiDTO>.Listar("Ubigeo/List_Ubigeo_Inei");
                ViewBag.Ubigeo = vRecord.ListaUbigeo;
                return View(vRecord);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> AgregarEditar(int vId = 0)
        {
            try
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
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AgregarEditar(ExpedienteDTO vModel)
        {
            try
            {
                vModel.Fec_Ingreso = vModel.Fec_Modifica = DateTime.Now;
                vModel.Usu_Ingreso = vModel.Usu_Modifica = GlobalAppSession.GetCurrentSesion(User);
                vModel.Ip_Ingreso = vModel.Ip_Modifica = DnsFullNet.GetIp();
                if (ModelState.IsValid)
                {
                    vModel = await Services<ExpedienteDTO>.Grabar("Expediente/Save", vModel);
                    return Ok(new ComponentResultModel(vModel?.Id_Expediente ?? 0));
                }
                else
                {
                    return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
                }
                //return View(vModel);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }


        [HttpGet]
        public async Task<JsonResult> ListaAutocompletar(string vPar)
        {
            List<ExpedienteDTO> lista = await Services<ExpedienteDTO>.Listar("Expediente/ListaAutocompletar?vFiltro=" + vPar);
            var listaRes = (from x in lista
                            select new
                            {
                                label = x.Nro_Expediente,
                                id = x.Id_Expediente
                            }).ToList();
            return Json(listaRes);
        }


    }
}
