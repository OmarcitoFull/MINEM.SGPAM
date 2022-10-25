using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Minem.Sgpam.ClienteInterno.Models;
using Minem.Sgpam.InfraEstructura.Utilitarios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WCFSeguridad;

namespace Minem.Sgpam.ClienteInterno.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            //try
            //{
            //    WCFSistemasServiceClient vSeguridad = new WCFSistemasServiceClient(new WCFSistemasServiceClient.EndpointConfiguration());
            //    Sistema ObjSistema = new Sistema();
            //    AddSistemaResult ObjAddSistemaResult = new AddSistemaResult();

            //    //HttpBrowserCapabilitiesBase Bc = Request.Browser;
            //    //HttpBrowserCapabilities bc = Request.Browser;
            //    ObjSistema.ID_Sistema = "6010";
            //    //ObjSistema.IP_Remoto = HttpContext.Connection.LocalIpAddress.ToString();
            //    ObjSistema.IP_Remoto = DnsFullNet.GetIp();
            //    ObjSistema.Nombre_explorador = Request.Headers["User-Agent"].ToString();
            //    ObjSistema.Nombre_pagina_web = Request.Path;
            //    ObjSistema.ID_Codigo_generado_plone = "EXTERNO_SIGEPAM";

            //    ObjAddSistemaResult = vSeguridad.AddSistema(ObjSistema);

            //    UsuarioSistemaDTO Usuario = new UsuarioSistemaDTO();
            //    Usuario.DES_LOGIN = ObjAddSistemaResult.Usuario.ToString().Trim();
            //}
            //catch (Exception ex)
            //{
            //    Response.Redirect("http://intranet.minem.gob.pe");
            //    throw ex;
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
