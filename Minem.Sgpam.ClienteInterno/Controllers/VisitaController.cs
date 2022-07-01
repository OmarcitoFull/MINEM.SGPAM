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
    public class VisitaController : Controller
    {
        public IConfiguration Configuration { get; }

        public VisitaController(IConfiguration vIConfiguration)
        {
            Configuration = vIConfiguration;
        }


        public async Task<IActionResult> Index(string vNombreEUM = "", string vNroExpediente = "0", int vTipo = 0, int vCantAnios = 0, int vNumPag = 1, int vCantRegxPag = 10)
        {
            ListarVisitaDTO vRecord = new ListarVisitaDTO();
            vRecord.ListaVisita = await Services<VisitaDTO>.Listar("Visita/ListarPaginadoVisitaDTO?vFiltro=" + vNombreEUM + "&vNroExpediente=" + vNroExpediente + "&vTipo=" + vTipo + "&vCantAnios=" + vCantAnios + "&vNumPag=" + vNumPag + "&vCantRegxPag=" + vCantRegxPag);
            return View(vRecord);
        }

        [HttpGet]
        public async Task<IActionResult> AgregarEditar(int vId = 0)
        {
            RegistrarVisitaDTO vRecord = new RegistrarVisitaDTO();

            vRecord = await Services<RegistrarVisitaDTO>.Obtener("Visita/GetFull?vId=" + vId);
            if (vId == 0)
                vRecord.Visita = new VisitaDTO();


            ViewBag.CboRegion = vRecord.CboUbigeo.Select(x => new { x.Id_Departamento, x.Departamento }).Distinct().OrderBy(x => x.Departamento).ToList().ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Departamento, Value = x.Id_Departamento.ToString() };
            });

            ViewBag.CboProvincia = vRecord.CboUbigeo.Where(x => x.Id_Departamento == vRecord.Visita.Id_Region).Select(x => new { x.Id_Provincia, x.Provincia }).Distinct().OrderBy(x => x.Provincia).ToList().ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Provincia, Value = x.Id_Provincia.ToString() };
            });

            ViewBag.CboDistrito = vRecord.CboUbigeo.Where(x => x.Id_Provincia == vRecord.Visita.Id_Provincia).Select(x => new { x.Id_Distrito, x.Distrito }).Distinct().OrderBy(x => x.Distrito).ToList().ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Distrito, Value = x.Id_Distrito.ToString() };
            });

            ViewBag.FullUbigeo = vRecord.CboUbigeo.Select(x => new { x.Id_Departamento, x.Departamento, x.Id_Provincia, x.Provincia, x.Id_Distrito, x.Distrito }).Distinct().OrderBy(x => x.Departamento).ThenBy(x => x.Provincia).ThenBy(x => x.Distrito).ToList();


            return View(vRecord);
        }

        [HttpPost]
        public async Task<IActionResult> AgregarEditar(VisitaDTO vModel)
        {
            vModel.Fec_Ingreso = vModel.Fec_Modifica = DateTime.Now;
            vModel.Usu_Ingreso = vModel.Usu_Modifica = Constantes.GuestUser;
            vModel.Ip_Ingreso = vModel.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vModel = await Services<VisitaDTO>.Grabar("Visita/Save", vModel);
                return Ok(new ComponentResultModel(vModel?.Id_Visita ?? 0));
            }
            return View(vModel);
        }



        #region EumExpediente
        [HttpGet]
        public async Task<IActionResult> CrearEumExpediente(int vIdVisita)
        {
            RegistrarVisitaDetDTO vRecord = await Services<RegistrarVisitaDetDTO>.Obtener("VisitaDet/GetFull?vId=" + 0);
            vRecord.Visita_Det = new Visita_DetDTO { Id_Visita = vIdVisita };

            ViewBag.CboTipo = Enum.GetValues(typeof(Tipo)).Cast<Tipo>().ToList().ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.ToString(), Value = ((int)x).ToString() };
            });
            //ViewBag.CboInspector = vRecord.CboInspector.ConvertAll(x =>
            //{
            //    return new SelectListItem() { Text = x.Nombre_Completo, Value = x.Id_Inspector.ToString() };
            //});
            return PartialView("_ModalEumExpediente", vRecord.Visita_Det);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarEumExpediente(Visita_DetDTO vVisita_Det)
        {
            vVisita_Det.Flg_Estado = Constantes.Activo;
            vVisita_Det.Fec_Ingreso = vVisita_Det.Fec_Modifica = DateTime.Now;
            vVisita_Det.Usu_Ingreso = vVisita_Det.Usu_Modifica = Constantes.GuestUser;
            vVisita_Det.Ip_Ingreso = vVisita_Det.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vVisita_Det = await Services<Visita_DetDTO>.Grabar("VisitaDet/Save", vVisita_Det);
                return Json(new ComponentResultModel { Operation = vVisita_Det.Id_Visita_Det > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion


        #region VisitaPersona
        [HttpGet]
        public async Task<IActionResult> CrearVisitaPersona(int vIdVisita)
        {
            RegistrarVisitaPersonaDTO vRecord = await Services<RegistrarVisitaPersonaDTO>.Obtener("VisitaPersona/GetFull?vId=" + 0);
            vRecord.Visita_Persona = new Visita_PersonaDTO { Id_Visita = vIdVisita };





            ViewBag.CboCargo = vRecord.CboCargo.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Cargo.ToString() };
            });
            return PartialView("_ModalVisitaPersona", vRecord.Visita_Persona);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarVisitaPersona(Visita_PersonaDTO vVisita_Persona)
        {
            vVisita_Persona.Flg_Estado = Constantes.Activo;
            vVisita_Persona.Fec_Ingreso = vVisita_Persona.Fec_Modifica = DateTime.Now;
            vVisita_Persona.Usu_Ingreso = vVisita_Persona.Usu_Modifica = Constantes.GuestUser;
            vVisita_Persona.Ip_Ingreso = vVisita_Persona.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vVisita_Persona = await Services<Visita_PersonaDTO>.Grabar("VisitaPersona/Save", vVisita_Persona);
                return Json(new ComponentResultModel { Operation = vVisita_Persona.Id_Visita_Persona > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

    }
}
