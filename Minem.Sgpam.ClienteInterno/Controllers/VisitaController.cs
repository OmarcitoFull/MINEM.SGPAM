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
            //vRecord.ListaUbigeo = await Services<Ubigeo_IneiDTO>.Listar("Ubigeo/List_Ubigeo_Inei");
            //ViewBag.Ubigeo = vRecord.ListaUbigeo;
            return View(vRecord);
        }

        [HttpGet]
        public async Task<IActionResult> AgregarEditar(int vId = 0)
        {
            RegistrarEumDTO vRecord = new RegistrarEumDTO();

            vRecord = await Services<RegistrarEumDTO>.Obtener("Visita/GetFull?vId=" + vId);
            if (vId == 0)
                vRecord.Eum = new MaestraDTO();

            ViewBag.CboTipoPam = vRecord.CboTipoPam.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Pam.ToString() };
            });
            ViewBag.CboTipoOperacion = vRecord.CboTipoOperacion.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Operacion.ToString() };
            });
            ViewBag.CboTipoSustancia = vRecord.CboTipoSustancia.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Sustancia.ToString() };
            });
            ViewBag.CboConflictoSocial = vRecord.CboConflictoSocial.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Conflicto_Social.ToString() };
            });

            return View(vRecord);
        }

        [HttpPost]
        public async Task<IActionResult> AgregarEditar(VisitaDTO vVisita)
        {
            vVisita.Fec_Ingreso = vVisita.Fec_Modifica = DateTime.Now;
            vVisita.Usu_Ingreso = vVisita.Usu_Modifica = "JPEREZ";
            vVisita.Ip_Ingreso = vVisita.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vVisita = await Services<VisitaDTO>.Grabar("Visita/Save", vVisita);
                return RedirectToAction(nameof(Index));
                //return Ok(new ComponentResultModel(vModel?.Id_Componente ?? 0));
            }
            return View(vVisita);
        }


    }
}
