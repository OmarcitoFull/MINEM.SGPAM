﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class EumController : Controller
    {
        public async Task<IActionResult> Index(string vNombreEUM = "")
        {
            ListarEumDTO vRecord = new ListarEumDTO();
            vRecord.ListaEum = await Services<MaestraDTO>.Listar("Eum/ListarPaginadoMaestraDTO?vFiltro=" + vNombreEUM + "&vNumPag=" + 5 + "&vCantRegxPag=" + 2);

            return View(vRecord);
        }

        [HttpGet]
        public async Task<IActionResult> AgregarEditar(int vId = 0)
        {
            RegistrarEumDTO vRecord = new RegistrarEumDTO();

            vRecord = await Services<RegistrarEumDTO>.Obtener("Eum/GetFull?vId=" + vId);
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
            //ViewBag.CboCuencaPrincipal = Enum.GetValues(typeof(CuencaPrincipal)).Cast<CuencaPrincipal>().ToList().ConvertAll(x =>
            //{
            //    return new SelectListItem() { Text = x.ToString(), Value = ((int)x).ToString() };
            //});

            return View(vRecord);
        }

        [HttpPost]
        public async Task<IActionResult> AgregarEditar(MaestraDTO vEum)
        {
            vEum.Fec_Ingreso = vEum.Fec_Modifica = DateTime.Now;
            vEum.Usu_Ingreso = vEum.Usu_Modifica = "JPEREZ";
            vEum.Ip_Ingreso = vEum.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vEum = await Services<MaestraDTO>.Grabar("Eum/Save", vEum);
                return RedirectToAction(nameof(Index));
                //return Ok(new ComponentResultModel(vModel?.Id_Componente ?? 0));
            }
            return View(vEum);
        }


        [HttpPost]
        public async Task<IActionResult> CreateComponent(int vIdEum, int vIdTipo)
        {
            ComponenteDTO vRegistro = new ComponenteDTO
            {
                Id_Componente = 0,
                Id_Eum = vIdEum,
                Id_Tipo_Pam = vIdTipo,
                Flg_Estado = Constantes.Activo,
                Fec_Ingreso = DateTime.Now,
                Fec_Modifica = DateTime.Now,
                Usu_Ingreso = "ORODRIGUEZ",
                Usu_Modifica = "ORODRIGUEZ",
                Ip_Ingreso = DnsFullNet.GetIp(),
                Ip_Modifica = DnsFullNet.GetIp()
            };

            vRegistro = await Services<ComponenteDTO>.Grabar("Componente/Save", vRegistro);
            return Ok(new ComponentResultModel(vRegistro?.Id_Componente ?? 0));
        }

    }
}
